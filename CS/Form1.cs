using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
// ...


namespace EUD_NewReport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XRDesignFormEx form = new XRDesignFormEx();
            XRDesignPanel panel = form.DesignPanel;

            panel.AddCommandHandler(new NewReportCommandHandler(panel));

            form.Load += new EventHandler(form_Load);

            form.ShowDialog();
        }

        void form_Load(object sender, EventArgs e) {
            ((XRDesignFormEx)sender).DesignPanel.ExecCommand(ReportCommand.NewReport);
        }

        public class NewReportCommandHandler : ICommandHandler {
            XRDesignPanel panel;
            ReportChooser chooser;

            public NewReportCommandHandler(XRDesignPanel panel) {
                this.panel = panel;
                this.chooser = new ReportChooser();
            }

            public virtual bool CanHandleCommand(ReportCommand command) {
                return command == ReportCommand.NewReport;
            }

            public virtual void HandleCommand(ReportCommand command, object[] args, ref bool handled) {
                if (!CanHandleCommand(command)) return;

                int i = ChooseReport();
                if (i != -1) {
                    this.panel.OpenReport(CreateReport(i));
                }

                handled = true;
            }

            private int ChooseReport() {
                this.chooser.ShowDialog();
                return this.chooser.Index;
            }

            private XtraReport CreateReport(int index) {
                XtraReport report = new XtraReport();

                switch (index) {
                    case 1:
                        report = new Report1();
                        break;
                    case 2:
                        report = new Report2();
                        break;
                    default:
                        report.Bands.Add(new DetailBand());
                        break;
                }

                return report;
            }

        }
    }
}