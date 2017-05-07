namespace XAJModel.ParamsDlg
{
    partial class DParamsDlg
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
            this.KIEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SMEdit = new DevExpress.XtraEditors.TextEdit();
            this.EXEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.KGEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.IMEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.KIEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KGEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // KIEdit
            // 
            this.KIEdit.Location = new System.Drawing.Point(206, 79);
            this.KIEdit.Name = "KIEdit";
            this.KIEdit.Size = new System.Drawing.Size(128, 24);
            this.KIEdit.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(120, 18);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "壤中流出流系数KI";
            // 
            // SMEdit
            // 
            this.SMEdit.EditValue = "";
            this.SMEdit.Location = new System.Drawing.Point(206, 43);
            this.SMEdit.Name = "SMEdit";
            this.SMEdit.Size = new System.Drawing.Size(128, 24);
            this.SMEdit.TabIndex = 10;
            // 
            // EXEdit
            // 
            this.EXEdit.EditValue = "";
            this.EXEdit.Location = new System.Drawing.Point(206, 6);
            this.EXEdit.Name = "EXEdit";
            this.EXEdit.Size = new System.Drawing.Size(128, 24);
            this.EXEdit.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(155, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "自由水蓄量曲线参数SM";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 18);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "自由水蓄量曲线参数EX";
            // 
            // KGEdit
            // 
            this.KGEdit.Location = new System.Drawing.Point(206, 118);
            this.KGEdit.Name = "KGEdit";
            this.KGEdit.Size = new System.Drawing.Size(128, 24);
            this.KGEdit.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 124);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 18);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "地下水出流系数KG";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 195);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(322, 52);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // IMEdit
            // 
            this.IMEdit.Location = new System.Drawing.Point(206, 156);
            this.IMEdit.Name = "IMEdit";
            this.IMEdit.Size = new System.Drawing.Size(128, 24);
            this.IMEdit.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(123, 18);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "不透水面积占比IM";
            // 
            // DParamsDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 257);
            this.Controls.Add(this.IMEdit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.KGEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.KIEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.SMEdit);
            this.Controls.Add(this.EXEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "DParamsDlg";
            this.Text = "三分水源参数设置";
            this.Load += new System.EventHandler(this.DParamsDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KIEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KGEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit KIEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit SMEdit;
        private DevExpress.XtraEditors.TextEdit EXEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit KGEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit IMEdit;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}