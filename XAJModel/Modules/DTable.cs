using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAJModel.Modules
{
    public class DTable
    {
        public DTable(DataTable dt)
        {
            DT = dt;
            RowCount = dt.Rows.Count;
            ColCount = dt.Columns.Count;
        }
        private DataTable DT;
        private int RowCount, ColCount;
        /// <summary>
        /// 获取指定行列的值
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="rowNum">行</param>
        /// <param name="colNum">列</param>
        /// <returns></returns>
        public double getCell(int rowNum, int colNum)
        {
            return Convert.ToDouble(DT.Rows[rowNum][colNum]);
        }
        /// <summary>
        /// 设置指定单元格的值
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="rowNum"></param>
        /// <param name="colNum"></param>
        /// <param name="value"></param>
        /// <param name="validnum"></param>
        public void setCell(int rowNum, int colNum, double value, int validnum = 2)
        {
            value = NumTrim.Trim(value, validnum);
            DT.Rows[rowNum][colNum] = value.ToString("F" + validnum.ToString());
        }
        /// <summary>
        /// 计算行数据的和
        /// </summary>
        /// <param name="rowNum"></param>
        /// <returns></returns>
        public double sumRow(int rowNum,int startCol,int endCol)
        {
            double sum=0;
            for (int i = startCol; i < endCol; i++)
                sum += getCell(rowNum, i);
            return sum;
        }
        public double sumCol(int colNum,int startRow,int endRow)
        {
            double sum = 0;
            for (int i = startRow; i < endRow; i++)
                sum += getCell(i, colNum);
            return sum;
        }
    }
}
