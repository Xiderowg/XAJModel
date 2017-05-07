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
    public partial class ERParamsDlg : XtraForm
    {

        public ERParamsDlg()
        {
            InitializeComponent();
        }

        public double Kc { get; set; }
        public double C { get; set; }
        public double WM { get; set; }
        public double WUM { get; set; }
        public double WLM { get; set; }
        public double WDM { get; set; }
        public double b { get; set; }
        public double IM { get; set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Kc = double.Parse(KEdit.Text);
            C = double.Parse(CEdit.Text);
            WM = double.Parse(WMText.Text);
            WUM = double.Parse(WUMText.Text);
            WLM = double.Parse(WLMText.Text);
            WDM = double.Parse(WDMText.Text);
            b = double.Parse(bText.Text);
            IM = double.Parse(IMEdit.Text);
            this.DialogResult = DialogResult.OK;
            
        }

        private void EParamsDlg_Load(object sender, EventArgs e)
        {
            KEdit.Text = "1";
            CEdit.Text = "0.167";
            WMText.Text = "120";
            WUMText.Text = "20";
            WLMText.Text = "60";
            WDMText.Text = "40";
            bText.Text = "0.3";
            IMEdit.Text = "0.1";
        }
    }
}