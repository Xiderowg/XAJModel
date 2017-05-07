namespace XAJModel.ParamsDlg
{
    partial class D2ParamsDlg
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.FCEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DTEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.FCEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 97);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(322, 52);
            this.simpleButton1.TabIndex = 35;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FCEdit
            // 
            this.FCEdit.EditValue = "";
            this.FCEdit.Location = new System.Drawing.Point(200, 12);
            this.FCEdit.Name = "FCEdit";
            this.FCEdit.Size = new System.Drawing.Size(128, 24);
            this.FCEdit.TabIndex = 34;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 18);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "稳定下渗率FC";
            // 
            // DTEdit
            // 
            this.DTEdit.EditValue = "";
            this.DTEdit.Location = new System.Drawing.Point(200, 50);
            this.DTEdit.Name = "DTEdit";
            this.DTEdit.Size = new System.Drawing.Size(128, 24);
            this.DTEdit.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 18);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "计算时段dt";
            // 
            // D2ParamsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 161);
            this.Controls.Add(this.DTEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.FCEdit);
            this.Controls.Add(this.labelControl1);
            this.Name = "D2ParamsDlg";
            this.Text = "二分水源参数";
            this.Load += new System.EventHandler(this.D2ParamsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FCEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit FCEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit DTEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}