using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace XAJModel.Modules
{
    public class RunoffDivision
    {
        public RunoffDivision(GridControl gc)
        {
            GC = gc;
            DGH = new Misc.DataGridHelper(gc);
        }

        private GridControl GC;
        private DataTable DT;
        private Misc.DataGridHelper DGH;
        private Params.Division DParams;
        private Params.Division2 D2Params;
        private int rowCount, DivisionType;

        public void importExcel()
        {
            DGH.importExcel("蒸散发及产流计算结果.xls");
            DT = GC.DataSource as DataTable;
            GC.MainView.PopulateColumns();
        }
        public void exportExcel()
        {
            DGH.exportExcel("蒸散发、产流及水源划分计算结果.xls");
        }
        public void initParams(Params.Division dparams)
        {
            DParams = dparams;
            DivisionType = 3;
        }
        public void initParams(Params.Division2 d2params)
        {
            D2Params = d2params;
            DivisionType = 2;
        }

        public void Start()
        {
            if (DParams == null && D2Params==null)
            {
                System.Windows.Forms.MessageBox.Show("请设置参数后再进行计算", "错误！", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            rowCount = DT.Rows.Count - 1;

            Anchor.DAnchor Col = new Anchor.DAnchor();
            DTable DTab = new DTable(DT);
            if (DivisionType == 3)
            {
                double FR0 = DTab.getCell(0, Col.RPE);
                double FR;
                for (int i = 0; i < rowCount; i++)
                {

                    double AU, S0;
                    double RS, RI, RG, S;
                    double R = DTab.getCell(i, Col.R);
                    double RB = DTab.getCell(i, Col.RB);
                    double PE = DTab.getCell(i, Col.PE);

                    if (i == 0)
                        S0 = DTab.getCell(i, Col.R);
                    else
                    {
                        FR0 = DTab.getCell(i - 1, Col.FR);
                        S0 = DTab.getCell(i - 1, Col.S0) * (1 - DParams.KI - DParams.KG);
                    }

                    calFR(PE, R, FR0, out FR);
                    DTab.setCell(i, Col.FR, FR);
                    calAU(DParams.MS, S0, DParams.SM, DParams.MS, FR0, FR, DParams.EX, out AU);
                    calR(RB, AU, FR, R, PE, S0, FR0, DParams.SM, DParams.MS, DParams.EX, DParams.KI, DParams.KG, out RS, out RI, out RG, out S);
                    DTab.setCell(i, Col.S0, S); DTab.setCell(i, Col.RS, RS); DTab.setCell(i, Col.RI, RI); DTab.setCell(i, Col.RG, RG);
                }
            }else
            {
                for(int i = 0; i < rowCount; i++)
                {
                    double Rs, Rg;
                    double PE = DTab.getCell(i, Col.PE);
                    double R = DTab.getCell(i, Col.R);
                    calRSplit(PE, D2Params.FC, D2Params.DT, R, out Rs, out Rg);
                    DTab.setCell(i, Col.RS, Rs);DTab.setCell(i, Col.RG, Rg);
                }
            }
            
        }
        /// <summary>
        /// 计算AU
        /// </summary>
        /// <param name="MS"></param>
        /// <param name="S0"></param>
        /// <param name="SM"></param>
        /// <param name="FR0"></param>
        /// <param name="FR"></param>
        /// <param name="EX"></param>
        /// <param name="AU"></param>
        private void calAU(double MS, double S0, double SM, double SMM, double FR0, double FR, double EX, out double AU)
        {
            if (S0 >= MS)
                AU = MS;
            else
                AU = MS * (1 - Math.Pow(1 - S0 * FR0 / (FR * SM), (1 / (1 + EX))));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="AU"></param>
        /// <param name="FR"></param>
        /// <param name="R"></param>
        /// <param name="PE"></param>
        /// <param name="S0"></param>
        /// <param name="FR0"></param>
        /// <param name="SM"></param>
        /// <param name="MS"></param>
        /// <param name="EX"></param>
        /// <param name="KI"></param>
        /// <param name="KG"></param>
        /// <param name="Rs"></param>
        /// <param name="Ri"></param>
        /// <param name="Rg"></param>
        /// <param name="S"></param>
        private void calR(double RB, double AU, double FR, double R, double PE, double S0, double FR0, double SM, double MS, double EX, double KI, double KG, out double Rs, out double Ri, out double Rg, out double S)
        {
            if (PE <= 0)
            {
                Rs = 0;
                Rg = S0 * KG * FR;
                Ri = S0 * KI * FR;
                S = S0 - (Rg + Ri) / FR;
            } else
            {
                if (PE + AU < MS)
                    Rs = FR * (PE + S0 * FR0 / FR - SM + SM * Math.Pow(1 - (PE + AU) / MS, 1 + EX)) + RB;
                else
                    Rs = FR * (PE + S0 * FR0 / FR - SM) + RB;
                S = S0 * FR0 / FR + (R - Rs) / FR;
                Ri = KI * S * FR; Rg = KG * S * FR;
            }
        }
        /// <summary>
        /// 计算产流面积
        /// </summary>
        /// <param name="PE"></param>
        /// <param name="R"></param>
        /// <param name="FR0"></param>
        /// <param name="FR"></param>
        private void calFR(double PE, double R, double FR0, out double FR)
        {
            if (PE <= 0 && R <= 0)
                FR = FR0;
            else
                FR = R / PE;
        }
        /// <summary>
        /// 二水源划分
        /// </summary>
        /// <param name="PE"></param>
        /// <param name="fc"></param>
        /// <param name="dt"></param>
        /// <param name="R"></param>
        /// <param name="Rs"></param>
        /// <param name="Rg"></param>
        private void calRSplit(double PE,double fc,double dt, double R, out double Rs, out double Rg)
        {
            double FC = fc * dt;
            if (PE > FC)
            {
                Rg = fc * R / PE; Rs = (PE - fc) * R / PE;
            }
            else
            {
                Rs = 0; Rg = R;
            }
        }
    }
}
