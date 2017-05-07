namespace XAJModel.ParamsDlg
{
    partial class RParamsDlg
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
            this.NEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.XEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.KEdit = new DevExpress.XtraEditors.TextEdit();
            this.DTEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.NEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NEdit
            // 
            this.NEdit.Location = new System.Drawing.Point(206, 123);
            this.NEdit.Name = "NEdit";
            this.NEdit.Size = new System.Drawing.Size(128, 24);
            this.NEdit.TabIndex = 36;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 18);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "子河段数目n";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(13, 165);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(322, 52);
            this.simpleButton1.TabIndex = 32;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XEdit
            // 
            this.XEdit.Location = new System.Drawing.Point(206, 83);
            this.XEdit.Name = "XEdit";
            this.XEdit.Size = new System.Drawing.Size(128, 24);
            this.XEdit.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 18);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "河段参数X";
            // 
            // KEdit
            // 
            this.KEdit.EditValue = "";
            this.KEdit.Location = new System.Drawing.Point(206, 47);
            this.KEdit.Name = "KEdit";
            this.KEdit.Size = new System.Drawing.Size(128, 24);
            this.KEdit.TabIndex = 29;
            // 
            // DTEdit
            // 
            this.DTEdit.EditValue = "";
            this.DTEdit.Location = new System.Drawing.Point(206, 10);
            this.DTEdit.Name = "DTEdit";
            this.DTEdit.Size = new System.Drawing.Size(128, 24);
            this.DTEdit.TabIndex = 28;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(119, 18);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "河段传播时间K(h)";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 18);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "计算时段长dt(h)";
            // 
            // RParamsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 233);
            this.Controls.Add(this.NEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.XEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.KEdit);
            this.Controls.Add(this.DTEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "RParamsDlg";
            this.Text = "河道汇流参数";
            this.Load += new System.EventHandler(this.RParamsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit NEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit XEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit KEdit;
        private DevExpress.XtraEditors.TextEdit DTEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}