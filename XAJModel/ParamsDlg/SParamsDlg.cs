using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace XAJModel.ParamsDlg
{
    public partial class SParamsDlg : DevExpress.XtraEditors.XtraForm
    {
        public SParamsDlg()
        {
            InitializeComponent();
        }

        public double CS { get; private set; }
        public double CI { get; private set; }
        public double CG { get; private set; }
        public double CR { get; private set; }
        public double U { get; private set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CS = double.Parse(CSEdit.Text);
            CI = double.Parse(CIEdit.Text);
            CG = double.Parse(CGEdit.Text);
            CR = double.Parse(CREdit.Text);
            // TO DO //
            U = double.Parse(FEdit.Text) / 3.6 / 24;
            this.DialogResult = DialogResult.OK;
        }

        private void SParamsDlg_Load(object sender, EventArgs e)
        {
            CSEdit.Text = "0.2";
            CIEdit.Text = "0.6";
            CGEdit.Text = "0.994";
            CREdit.Text = "0.1";
            FEdit.Text = "100";
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}