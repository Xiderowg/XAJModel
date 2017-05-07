using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace XAJModel.Modules
{
    public class EvaporRunoff
    {
        public EvaporRunoff(GridControl gc)
        {
            GC = gc;
            DGH = new Misc.DataGridHelper(GC);
        }

        private GridControl GC;
        private DataTable DT;
        private Misc.DataGridHelper DGH;
        private Params.ERunoff EParams;
        private int rowCount;

        public void importExcel()
        {
            DGH.importExcel("蒸散发数据.xls");
            DT = GC.DataSource as DataTable;
            GC.MainView.PopulateColumns();
        }
        public void exportExcel()
        {
            DGH.exportExcel("蒸散发及产流计算结果.xls");
        }
        public void initParams(Params.ERunoff eparams)
        {
            EParams = eparams;
        }

        public void Start()
        {
            if (EParams == null)
            {
                System.Windows.Forms.MessageBox.Show("请设置参数后再进行计算", "错误！", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            rowCount = DT.Rows.Count-1;
            Anchor.EAnchor Col = new Anchor.EAnchor();
            DTable DTab = new DTable(DT);
            //计算蒸散发及产流量
            for (int i = 0; i < rowCount; i++)
            {
                //蒸发
                double WU = DTab.getCell(i, Col.WU);double WL = DTab.getCell(i, Col.WL);double WD = DTab.getCell(i, Col.WD);
                double W = WU + WL + WD;
                double P = DTab.getCell(i, Col.P);double E0 = DTab.getCell(i, Col.E0);
                double Ep = 0, Eu = 0, El = 0, Ed = 0, E = 0;
                calEvaporation(WU, P, EParams.C, WL, EParams.WLM, E0, EParams.Kc, out Ep, out Eu, out El, out Ed, out E);
                DTab.setCell(i, Col.PE, (P - E) * (1 - EParams.IM));
                DTab.setCell(i, Col.Ep, Ep);DTab.setCell(i, Col.Eu, Eu);DTab.setCell(i, Col.El, El);
                DTab.setCell(i, Col.Ed, Ed);DTab.setCell(i, Col.E, E);
                //产流
                double a = 0, R = 0, RB = 0;
                calRB(P, E, EParams.IM, out RB);
                calA(EParams.WMM, W, EParams.WM, EParams.b, out a);
                calR((P - E) * (1 - EParams.IM), a, EParams.WMM, EParams.WM, W, EParams.b, out R);
                DTab.setCell(i, Col.R, R);
                DTab.setCell(i, Col.RB, RB);
                DTab.setCell(i, Col.RPE, R/((P-E)* (1 - EParams.IM)));
                //计算下一时段土壤蓄量
                double WUNext, WLNext, WDNext, WNext;
                calW(P, E, EParams.IM, R, WU, WD, WL, EParams.WUM, EParams.WDM, EParams.WLM, out WUNext, out WLNext, out WDNext, out WNext);
                DTab.setCell(i+1, Col.WU, WUNext); DTab.setCell(i + 1, Col.WD, WDNext); DTab.setCell(i + 1, Col.WL, WLNext);
                DTab.setCell(i + 1, Col.W, WNext);
            }

        }
        /// <summary>
        /// 计算蒸散发量
        /// </summary>
        /// <param name="WU">上层土壤蓄水量</param>
        /// <param name="P">时段内降雨量</param>
        /// <param name="C">系数C</param>
        /// <param name="WL">中层土壤蓄水量</param>
        /// <param name="WLM">中层土壤蓄水容量</param>
        /// <param name="E0">水面蒸发量</param>
        /// <param name="K">蒸发折算系数</param>
        /// <param name="Ep">水面蒸发能力</param>
        /// <param name="Eu">上层蒸散发量</param>
        /// <param name="El">中层蒸散发量</param>
        /// <param name="Ed">底层蒸散发量</param>
        /// <param name="E">总蒸散发量</param>
        private void calEvaporation(double WU, double P, double C, double WL, double WLM, double E0, double K, out double Ep, out double Eu, out double El, out double Ed, out double E)
        {
            //计算Ep
            Ep = NumTrim.Trim(E0 * K,2);
            if (WU + P >= Ep)
            {
                Eu = Ep; El = 0; Ed = 0;
            }
            else
            {
                Eu = WU + P;
                if (WL > (C * WLM))
                {
                    El = NumTrim.Trim((Ep - Eu) * WL / WLM); Ed = 0;
                }
                else if (WL >= (C * (Ep - Eu)))
                {
                    El = NumTrim.Trim(C * (Ep - Eu)); Ed = 0;
                }
                else
                {
                    El = WL; Ed = NumTrim.Trim(C * (Ep - Eu) - El);
                }
            }
            //计算总的蒸发量
            E = Eu + El + Ed;
        }
        /// <summary>
        /// 计算初试蓄水容量a
        /// </summary>
        /// <param name="WMM"></param>
        /// <param name="W"></param>
        /// <param name="WM"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        private void calA(double WMM, double W, double WM, double b, out double a)
        {
            a = WMM * (1 - Math.Pow((1 - W / WM), (1 / (1 + b))));
        }
        /// <summary>
        /// 计算产流量
        /// </summary>
        /// <param name="rowNum"></param>
        /// <param name="PE"></param>
        /// <param name="a"></param>
        /// <param name="WMM"></param>
        /// <param name="W"></param>
        /// <param name="b"></param>
        /// <param name="R"></param>
        private void calR(double PE, double a, double WMM,double WM, double W, double b, out double R)
        {
            //蒸发强于降水
            if (PE > 0)
            {
                //流域未蓄满
                if (a + PE <= WMM)
                {
                    R = PE - WM * Math.Pow((1 - a / WMM), (b + 1)) + WM * Math.Pow((1 - (PE + a) / WMM), (b + 1));
                }
                else
                {
                    //流域已蓄满
                    R = PE - WM + W;
                }
            }
            else
                R = 0;
        }
        /// <summary>
        /// 计算下一时刻土壤蓄水量
        /// </summary>
        /// <param name="Eu">这一时刻的上层蒸发量</param>
        /// <param name="El">这一时刻的中层蒸发量</param>
        /// <param name="Ed">这一时刻的下层蒸发量</param>
        /// <param name="WU">这一时刻的上层蓄水量</param>
        /// <param name="WD">这一时刻的下层蓄水量</param>
        /// <param name="WL">这一时刻的中层蓄水量</param>
        /// <param name="WUNext">下一时刻的上层蓄水量</param>
        /// <param name="WLNext">下一时刻的中层蓄水量</param>
        /// <param name="WDNext">下一时刻的下层蓄水量</param>
        /// <param name="WNext">下一时刻的总蓄水量</param>
        private void calW(double P, double E,double IM, double R, double WU, double WD, double WL, double WUM, double WDM, double WLM, out double WUNext, out double WLNext, out double WDNext, out double WNext)
        {
            double PE = (P - E) * (1 - IM);
            double resident = PE - R;

            if (WU + resident < 0)
            {
                WUNext = 0; resident = WU + resident;
                if (WL + resident < 0)
                {
                    WLNext = 0; resident = WL + resident;
                    WDNext = WD + resident;
                }
                else
                {
                    WLNext = WL + resident;
                    WDNext = WD;
                }
            }
            else
            {
                if (WU + resident > WUM)
                {
                    WUNext = WUM; resident = WU + resident - WUM;
                    if (WL + resident > WLM)
                    {
                        WLNext = WLM; resident = WL + resident - WLM;
                        WDNext = WD + resident;
                    }
                    else
                    {
                        WLNext = WL + resident; WDNext = WD;
                    }
                }
                else
                {
                    WUNext = WU + resident;
                    WLNext = WL; WDNext = WD;
                }
            }

            WNext = WLNext + WUNext + WDNext;
        }
        /// <summary>
        /// 不透水面积直接径流
        /// </summary>
        /// <param name="P"></param>
        /// <param name="E"></param>
        /// <param name="IM"></param>
        /// <param name="RB"></param>
        private void calRB(double P,double E,double IM,out double RB)
        {
            if (P - E <= 0)
                RB = 0;
            else
                RB = (P - E) * IM;
        }
    }
}
