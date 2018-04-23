using DevExpress.XtraReports.UI;
// ...

namespace SideBySideReport {
    public partial class MasterReport : DevExpress.XtraReports.UI.XtraReport {
        public MasterReport() {
            InitializeComponent();
        }

        private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRSubreport)sender).ReportSource.FilterString = "[EmployeeID] = 1";
        }

        private void xrSubreport2_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e) {
            ((XRSubreport)sender).ReportSource.FilterString = "[EmployeeID] = 2";
        }
    }
}
