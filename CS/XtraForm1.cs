using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EUD_NewReport {
    public partial class ReportChooser : DevExpress.XtraEditors.XtraForm {
        public ReportChooser() {
            InitializeComponent();
        }

        private int index = -1;

        public int Index {
            get { return this.index; }
            set { this.index = value; }
        }

        private void ReportChooser_Load(object sender, EventArgs e) {
            this.listBoxControl1.SelectedIndex = 0;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            this.index = this.listBoxControl1.SelectedIndex;
        }

        private void OKButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CancButton_Click(object sender, EventArgs e) {
            this.index = -1;
            this.Close();
        }
    }
}