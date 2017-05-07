namespace XAJModel.ParamsDlg
{
    partial class ERParamsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.KEdit = new DevExpress.XtraEditors.TextEdit();
            this.CEdit = new DevExpress.XtraEditors.TextEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.WMText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.WUMText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.WLMText = new DevExpress.XtraEditors.TextEdit();
            this.WDMText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.bText = new DevExpress.XtraEditors.TextEdit();
            this.IMEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.KEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WUMText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WLMText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WDMText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "蒸散发折算系数K";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "蒸发扩散系数C";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 296);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(322, 51);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // KEdit
            // 
            this.KEdit.EditValue = "";
            this.KEdit.Location = new System.Drawing.Point(206, 6);
            this.KEdit.Name = "KEdit";
            this.KEdit.Size = new System.Drawing.Size(128, 24);
            this.KEdit.TabIndex = 3;
            // 
            // CEdit
            // 
            this.CEdit.EditValue = "";
            this.CEdit.Location = new System.Drawing.Point(206, 43);
            this.CEdit.Name = "CEdit";
            this.CEdit.Size = new System.Drawing.Size(128, 24);
            this.CEdit.TabIndex = 4;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(154, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "土壤蓄水容量WM(mm)";
            // 
            // WMText
            // 
            this.WMText.Location = new System.Drawing.Point(206, 79);
            this.WMText.Name = "WMText";
            this.WMText.Size = new System.Drawing.Size(128, 24);
            this.WMText.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(164, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "上层蓄水容量WUM(mm)";
            // 
            // WUMText
            // 
            this.WUMText.Location = new System.Drawing.Point(206, 119);
            this.WUMText.Name = "WUMText";
            this.WUMText.Size = new System.Drawing.Size(128, 24);
            this.WUMText.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(161, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "下层蓄水容量WLM(mm)";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(164, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "深层蓄水容量WDM(mm)";
            // 
            // WLMText
            // 
            this.WLMText.Location = new System.Drawing.Point(206, 156);
            this.WLMText.Name = "WLMText";
            this.WLMText.Size = new System.Drawing.Size(128, 24);
            this.WLMText.TabIndex = 11;
            // 
            // WDMText
            // 
            this.WDMText.Location = new System.Drawing.Point(206, 194);
            this.WDMText.Name = "WDMText";
            this.WDMText.Size = new System.Drawing.Size(128, 24);
            this.WDMText.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 234);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(128, 18);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "蓄水容量曲线系数b";
            // 
            // bText
            // 
            this.bText.Location = new System.Drawing.Point(206, 231);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(128, 24);
            this.bText.TabIndex = 14;
            // 
            // IMEdit
            // 
            this.IMEdit.Location = new System.Drawing.Point(206, 265);
            this.IMEdit.Name = "IMEdit";
            this.IMEdit.Size = new System.Drawing.Size(128, 24);
            this.IMEdit.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 268);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(124, 18);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "不透水面积比例Im";
            // 
            // ERParamsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 359);
            this.Controls.Add(this.IMEdit);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.bText);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.WDMText);
            this.Controls.Add(this.WLMText);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.WUMText);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.WMText);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.CEdit);
            this.Controls.Add(this.KEdit);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ERParamsDlg";
            this.Text = "蒸散发&产流参数设置";
            this.Load += new System.EventHandler(this.EParamsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WUMText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WLMText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WDMText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit KEdit;
        private DevExpress.XtraEditors.TextEdit CEdit;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit WMText;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit WUMText;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit WLMText;
        private DevExpress.XtraEditors.TextEdit WDMText;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit bText;
        private DevExpress.XtraEditors.TextEdit IMEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}