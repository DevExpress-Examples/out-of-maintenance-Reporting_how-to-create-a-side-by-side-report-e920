Imports DevExpress.XtraReports.UI
' ...

Public Class MasterReport

    Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e _
    As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        CType(sender, XRSubreport).ReportSource.FilterString = "[EmployeeID] = 1"
    End Sub

    Private Sub xrSubreport2_BeforePrint(ByVal sender As Object, ByVal e _
    As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        CType(sender, XRSubreport).ReportSource.FilterString = "[EmployeeID] = 2"
    End Sub
End Class