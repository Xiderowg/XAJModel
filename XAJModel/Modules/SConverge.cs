using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace XAJModel.Modules
{
    public class SConverge
    {
        public SConverge(GridControl gc, int divisionType)
        {
            GC = gc;
            DGH = new Misc.DataGridHelper(gc);
            DivisionType = divisionType;
        }

        private GridControl GC;
        private DataTable DT;
        private Misc.DataGridHelper DGH;
        private Params.SConverge SParams;
        private int DivisionType;
        private int rowCount;

        public void importExcel()
        {
            DGH.importExcel("产流量过程数据.xls");
            DT = GC.DataSource as DataTable;
            Anchor.SAnchor Col = new Anchor.SAnchor();
            DTable DTab = new DTable(DT);
            GC.MainView.PopulateColumns();
        }
        public void exportExcel()
        {
            DGH.exportExcel("坡地汇流计算结果.xls");
        }
        public void initParams(Params.SConverge sparams)
        {
            SParams = sparams;
        }

        public void Start()
        {
            if (SParams == null)
            {
                System.Windows.Forms.MessageBox.Show("请设置参数后再进行计算", "错误！", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            rowCount = DT.Rows.Count;

            Anchor.SAnchor Col = new Anchor.SAnchor();
            DTable DTab = new DTable(DT);
            if (DivisionType == 3)
            {
                //初值
                double QS0 = DTab.getCell(0, Col.RS) * SParams.U;
                double QG0 = DTab.getCell(0, Col.RG) * SParams.U;
                double QI0 = DTab.getCell(0, Col.RI) * SParams.U;
                double QS = QS0; double QG = QG0; double QI = QI0;
                double QT = QS0 + QG0 + QI0;
                // TO DO //
                double Q0 = QT; double Q = Q0;
                DTab.setCell(0, Col.QS, QS); DTab.setCell(0, Col.QI, QI); DTab.setCell(0, Col.QG, QG);
                DTab.setCell(0, Col.QT, QT); DTab.setCell(0, Col.Q, Q);
                for (int i = 1; i < rowCount; i++)
                {
                    calQS(QS0, SParams.CS, DTab.getCell(i, Col.RS), SParams.U, out QS);
                    calQI(QI0, SParams.CI, DTab.getCell(i, Col.RI), SParams.U, out QI);
                    calQG(QG0, SParams.CG, DTab.getCell(i, Col.RG), SParams.U, out QG);
                    calQ(Q0, SParams.CR, DTab.getCell(i, Col.RS) + DTab.getCell(i, Col.RI) + DTab.getCell(i, Col.RG), SParams.U, out Q);
                    QS0 = QS; QI0 = QI; QG0 = QG;
                    QT = QS + QI + QG; Q0 = Q;
                    DTab.setCell(i, Col.QS, QS); DTab.setCell(i, Col.QI, QI); DTab.setCell(i, Col.QG, QG);
                    DTab.setCell(i, Col.QT, QT); DTab.setCell(i, Col.Q, Q);
                }
            }else
            {
                double[] q = DT.AsEnumerable().Select(d => double.Parse(d.Field<string>("q (m3/s)"))).ToArray();
                double[] rs= DT.AsEnumerable().Select(d => double.Parse(d.Field<string>("Rs (mm)"))).ToArray();
                double[,] Matrix = calUHMatrix(rs.Length, q, rs);
                double QG0 = DTab.getCell(0, Col.RG) * SParams.U;
                double QG = QG0;
                DTab.setCell(0, Col.QG, QG0);
                for (int i = 0; i < rowCount; i++)
                {
                    double QS = 0;
                    for (int j = 0; j < rs.Length; j++)
                        QS += Matrix[j, i];
                    DTab.setCell(i, Col.QS, QS);
                }
                double QT0=QG+ DTab.getCell(0, Col.QS);
                double Q0 = QT0;
                DTab.setCell(0, Col.QT, QT0); DTab.setCell(0, Col.Q, QT0);
                for (int i = 1; i < rowCount; i++)
                {
                    calQG(QG0, SParams.CG, DTab.getCell(i, Col.RG), SParams.U, out QG);
                    QG0 = QG;
                    double QS= DTab.getCell(i, Col.QS);
                    double QT = QS + QG;
                    double Q = 0;
                    calQ(Q0, SParams.CR, DTab.getCell(i, Col.RS) + DTab.getCell(i, Col.RG), SParams.U, out Q);
                    Q0 = Q;
                    DTab.setCell(i, Col.QG, QG); DTab.setCell(i, Col.QT, QT); DTab.setCell(i, Col.Q, Q);
                }
                
                
            }
            
        }
        /// <summary>
        /// 地表径流汇流计算
        /// </summary>
        /// <param name="QS0"></param>
        /// <param name="CS"></param>
        /// <param name="U"></param>
        private void calQS(double QS0,double CS,double RS,double U,out double QS)
        {
            QS = CS * QS0 + (1 - CS) * RS * U;
        }
        /// <summary>
        /// 壤中流汇流计算
        /// </summary>
        /// <param name="QI0"></param>
        /// <param name="CI"></param>
        /// <param name="RI"></param>
        /// <param name="U"></param>
        /// <param name="QI"></param>
        private void calQI(double QI0,double CI,double RI,double U,out double QI)
        {
            QI = CI * QI0 + (1 - CI) * RI * U;
        }
        /// <summary>
        /// 地下径流汇流计算
        /// </summary>
        /// <param name="QG0"></param>
        /// <param name="CG"></param>
        /// <param name="RG"></param>
        /// <param name="U"></param>
        /// <param name="QG"></param>
        private void calQG(double QG0,double CG,double RG,double U,out double QG)
        {
            QG = CG * QG0 + (1 - CG) * RG * U;
        }
        /// <summary>
        /// 单位面积河网汇流
        /// </summary>
        /// <param name="Q0"></param>
        /// <param name="CR"></param>
        /// <param name="R"></param>
        /// <param name="U"></param>
        /// <param name="Q"></param>
        private void calQ(double Q0,double CR,double R,double U,out double Q)
        {
            Q = CR * Q0 + (1 - CR) * R * U;
        }

        private double[,] calUHMatrix(int rsCount,double[] q,double[] rs)
        {
            double[,] Matrix = new double[rowCount, rsCount];
            for (int t = 1; t < rowCount; t++)
            {
                for (int x = 1; x <= t; x++)
                {
                    Matrix[t,x] = rs[x] * q[t - x + 1] / 10;   
                }
            }
            return Matrix;
        }
    }
}
