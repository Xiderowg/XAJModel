using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace XAJModel.Modules
{
    public class RConverge
    {
        public RConverge(GridControl gc)
        {
            GC = gc;
            DGH = new Misc.DataGridHelper(gc);
        }

        private GridControl GC;
        private DataTable DT;
        private Misc.DataGridHelper DGH;
        private Params.RConverge RParams;
        private int rowCount;
        public void importExcel()
        {
            DGH.importExcel("坡地汇流计算结果.xls");
            DT = GC.DataSource as DataTable;
            GC.MainView.PopulateColumns();
        }
        public void exportExcel()
        {
            DGH.exportExcel("河网汇流计算结果.xls");
        }
        public void initParams(Params.RConverge rparams)
        {
            RParams = rparams;
        }

        public void Start()
        {
            if (RParams == null)
            {
                System.Windows.Forms.MessageBox.Show("请设置参数后再进行计算", "错误！", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            rowCount = DT.Rows.Count - 1;

            Anchor.RAnchor Col = new Anchor.RAnchor();
            DTable DTab = new DTable(DT);
            double[] IData = DT.AsEnumerable().Select(d => double.Parse(d.Field<string>("I(m3/s)"))).ToArray();
            double O0 = IData[0];
            double[] Q = new double[IData.Length];
            Maskinen(IData, O0, RParams.DT, RParams.KE, RParams.XE, (int)RParams.N, out Q);
            for (int i = 0; i < rowCount; i++)
                DTab.setCell(i, Col.O, Q[i]);
        }
        /// <summary>
        /// 马斯京根
        /// </summary>
        /// <param name="IData"></param>
        /// <param name="O0"></param>
        /// <param name="dt"></param>
        /// <param name="Kl"></param>
        /// <param name="xl"></param>
        /// <param name="n"></param>
        /// <param name="Q"></param>
        private void Maskinen(double[] IData,double O0,double dt,double Kl,double xl,int n,out double[] Q)
        {
            double[] C = new double[3];
            C[0] = (0.5 * dt - Kl * xl) / (0.5 * dt + Kl - Kl * xl);
            C[1] = (0.5 * dt + Kl * xl) / (0.5 * dt + Kl - Kl * xl);
            C[2] = (-0.5 * dt + Kl - Kl * xl) / (0.5 * dt + Kl - Kl * xl);
            double[,] EMatrix = new double[n, IData.Length];
            Q = new double[IData.Length];
            for (int i = 0; i < IData.Length; i++)
                EMatrix[0, i] = IData[i];
            for (int i = 0; i < n - 1; i++)
                EMatrix[i + 1, 0] = O0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < IData.Length; j++)
                    EMatrix[i, j] = C[0] * EMatrix[i - 1, j] + C[1] * EMatrix[i - 1, j - 1] + C[2] * EMatrix[i, j - 1];
            }
            for (int i = 0; i < IData.Length; i++)
                Q[i] = EMatrix[n - 1, i];
        }
    }
}
