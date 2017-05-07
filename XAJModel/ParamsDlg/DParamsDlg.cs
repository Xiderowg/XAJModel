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
    public partial class DParamsDlg : XtraForm
    {
        public DParamsDlg()
        {
            InitializeComponent();
        }

        public double SM { get; private set; }
        public double EX { get; private set; }
        public double KI { get; private set; }
        public double KG { get; private set; }
        public double IM { get; private set; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SM = double.Parse(SMEdit.Text);
            EX = double.Parse(EXEdit.Text);
            KI = double.Parse(KIEdit.Text);
            KG = double.Parse(KGEdit.Text);
            IM = double.Parse(IMEdit.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void DParamsDlg_Load(object sender, EventArgs e)
        {
            EXEdit.Text = "1.0";
            KGEdit.Text = "0.4";
            KIEdit.Text = "0.3";
            SMEdit.Text = "15";
            IMEdit.Text = "0.1";
        }
    }
}