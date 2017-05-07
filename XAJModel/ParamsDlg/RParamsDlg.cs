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
    public partial class RParamsDlg : DevExpress.XtraEditors.XtraForm
    {
        public RParamsDlg()
        {
            InitializeComponent();
        }

        public double DT { get; private set; }
        private double K { get; set; }
        private double X { get; set; }
        public double N { get; private set; }
        public double KE { get; private set; }
        public double XE { get; private set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DT = double.Parse(DTEdit.Text);
            K = double.Parse(KEdit.Text);
            X = double.Parse(XEdit.Text);
            N = double.Parse(NEdit.Text);

            KE = K / N;
            XE = 0.5 - N * (1 - 2 * X) / 2;
            this.DialogResult = DialogResult.OK;
        }

        private void RParamsDlg_Load(object sender, EventArgs e)
        {
            DTEdit.Text = "24";
            KEdit.Text = "18";
            XEdit.Text = "0.3";
            NEdit.Text = "3";
        }
    }
}