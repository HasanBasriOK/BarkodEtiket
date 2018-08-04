namespace BarkodEtiket
{
    partial class frmEtiketYazdir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiketYazdir));
            this.txtBaslangicBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEtiket = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslangicBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaslangicBarkod
            // 
            this.txtBaslangicBarkod.Location = new System.Drawing.Point(135, 25);
            this.txtBaslangicBarkod.Name = "txtBaslangicBarkod";
            this.txtBaslangicBarkod.Size = new System.Drawing.Size(137, 20);
            this.txtBaslangicBarkod.TabIndex = 0;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(135, 62);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Properties.Mask.EditMask = "d";
            this.txtAdet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAdet.Size = new System.Drawing.Size(137, 20);
            this.txtAdet.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Başlangıç Barkod :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Adet :";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(32, 143);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(240, 49);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbEtiket
            // 
            this.cmbEtiket.FormattingEnabled = true;
            this.cmbEtiket.Location = new System.Drawing.Point(135, 98);
            this.cmbEtiket.Name = "cmbEtiket";
            this.cmbEtiket.Size = new System.Drawing.Size(137, 21);
            this.cmbEtiket.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(85, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Etiket :";
            // 
            // frmEtiketYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbEtiket);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtBaslangicBarkod);
            this.Name = "frmEtiketYazdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiket Yazdır";
            this.Load += new System.EventHandler(this.frmEtiketYazdir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslangicBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBaslangicBarkod;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.ComboBox cmbEtiket;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}