namespace EUD_NewReport {
    partial class ReportChooser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.CancButton = new DevExpress.XtraEditors.SimpleButton();
            this.OKButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxControl1.Items.AddRange(new object[] {
            "Blank Report",
            "Report1 (inherited from BaseReport1)",
            "Report2 (inherited from BaseReport2)"});
            this.listBoxControl1.Location = new System.Drawing.Point(8, 8);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(347, 208);
            this.listBoxControl1.TabIndex = 0;
            this.listBoxControl1.DoubleClick += new System.EventHandler(this.OKButton_Click);
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // CancButton
            // 
            this.CancButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancButton.Location = new System.Drawing.Point(264, 224);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(88, 32);
            this.CancButton.TabIndex = 2;
            this.CancButton.Text = "Cancel";
            this.CancButton.Click += new System.EventHandler(this.CancButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(160, 224);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 32);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ReportChooser
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancButton;
            this.ClientSize = new System.Drawing.Size(362, 264);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "ReportChooser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Report";
            this.Load += new System.EventHandler(this.ReportChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton CancButton;
        private DevExpress.XtraEditors.SimpleButton OKButton;
    }
}