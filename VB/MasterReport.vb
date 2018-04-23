Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace SideBySideReport
	Partial Public Class MasterReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
			CType(sender, XRSubreport).ReportSource.FilterString = "[EmployeeID] = 1"
		End Sub

		Private Sub xrSubreport2_BeforePrint_1(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport2.BeforePrint
			CType(sender, XRSubreport).ReportSource.FilterString = "[EmployeeID] = 2"
		End Sub
	End Class
End Namespace
