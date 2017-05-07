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
    public partial class D2ParamsDlg : DevExpress.XtraEditors.XtraForm
    {
        public D2ParamsDlg()
        {
            InitializeComponent();
        }

        public double FC { get; private set; }
        public double DT { get; private set; }
        private void D2ParamsDlg_Load(object sender, EventArgs e)
        {
            FCEdit.Text = "17.8";
            DTEdit.Text = "24";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FC = double.Parse(FCEdit.Text);
            DT = double.Parse(DTEdit.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}