using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace XAJModel.Misc
{
    public class DataGridHelper
    {
        public DataGridHelper(GridControl gc)
        {
            GC = gc;
        }
        private GridControl GC;
        /// <summary>
        /// 从GridControl中导出Excel
        /// </summary>
        /// <param name="fileName">导出的文件名</param>
        /// <param name="GC">GridControl</param>
        public void exportExcel(string fileName)
        {
            string saveFileName = "";
            //bool fileSaved = false;  
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx;*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            ExcelHelper EH = new ExcelHelper(saveFileName);
            EH.DataTableToExcel(GC.DataSource as DataTable, "处理后的数据", true);
            MessageBox.Show("导出Excel数据成功，位置位于：" + saveFileName, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MetroMessageBox.Show(this, "导出Excel数据成功，位置位于：" + saveFileName, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 将Excel导入到GridControl中
        /// </summary>
        /// <param name="fileName">导入文件名</param>
        /// <param name="GC">GridControl</param>
        /// <returns></returns>
        public int importExcel(string fileName)
        {
            GC.DataSource = null;
            string openFileName;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = "xlsx";
            openDialog.Filter = "Excel文件|*.xlsx;*.xls";
            openDialog.FileName = fileName;
            openDialog.ShowDialog();
            openFileName = openDialog.FileName;
            if (openFileName.IndexOf(":") < 0) return -1; //被点了取消
            ExcelHelper EH = new ExcelHelper(openFileName);
            DataTable ExcelData = EH.ExcelToDataTable("", true);
            if (ExcelData != null)
            {
                GC.DataSource = EH.ExcelToDataTable("", true);
                return 1;
            }
            else
            {
                MessageBox.Show("加载数据文件出错，请关闭一切可能打开数据文件的软件后重试", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MetroMessageBox.Show(this, "加载数据文件出错，请关闭一切可能打开数据文件的软件后重试", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="DT"></param>
        public void updataDT(DataTable DT)
        {
            GC.DataSource = null;
            GC.DataSource = DT;
        }
    }
}
