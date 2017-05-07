namespace XAJModel.ParamsDlg
{
    partial class SParamsDlg
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
            this.CGEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CIEdit = new DevExpress.XtraEditors.TextEdit();
            this.CSEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.FEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CREdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.CGEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CIEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CGEdit
            // 
            this.CGEdit.Location = new System.Drawing.Point(206, 88);
            this.CGEdit.Name = "CGEdit";
            this.CGEdit.Size = new System.Drawing.Size(128, 24);
            this.CGEdit.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(137, 18);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "地下径流消退系数Cg";
            // 
            // CIEdit
            // 
            this.CIEdit.EditValue = "";
            this.CIEdit.Location = new System.Drawing.Point(206, 52);
            this.CIEdit.Name = "CIEdit";
            this.CIEdit.Size = new System.Drawing.Size(128, 24);
            this.CIEdit.TabIndex = 18;
            // 
            // CSEdit
            // 
            this.CSEdit.EditValue = "";
            this.CSEdit.Location = new System.Drawing.Point(206, 15);
            this.CSEdit.Name = "CSEdit";
            this.CSEdit.Size = new System.Drawing.Size(128, 24);
            this.CSEdit.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(146, 18);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "壤中流径流消退系数Ci";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 18);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "地面径流消退系数Cs";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 211);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(322, 52);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FEdit
            // 
            this.FEdit.Location = new System.Drawing.Point(206, 163);
            this.FEdit.Name = "FEdit";
            this.FEdit.Size = new System.Drawing.Size(128, 24);
            this.FEdit.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 166);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 18);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "流域面积F(km^2)";
            // 
            // CREdit
            // 
            this.CREdit.Location = new System.Drawing.Point(206, 128);
            this.CREdit.Name = "CREdit";
            this.CREdit.Size = new System.Drawing.Size(128, 24);
            this.CREdit.TabIndex = 25;
            this.CREdit.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 131);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 18);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "河网蓄水消退系数CR";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // SParamsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 275);
            this.Controls.Add(this.CREdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.FEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.CGEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.CIEdit);
            this.Controls.Add(this.CSEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "SParamsDlg";
            this.Text = "坡面汇流参数";
            this.Load += new System.EventHandler(this.SParamsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CGEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CIEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CREdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit CGEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit CIEdit;
        private DevExpress.XtraEditors.TextEdit CSEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit FEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit CREdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}