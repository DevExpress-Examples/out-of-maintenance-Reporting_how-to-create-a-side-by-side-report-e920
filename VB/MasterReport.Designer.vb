Imports Microsoft.VisualBasic
Imports System
Namespace SideBySideReport
	Partial Public Class MasterReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
			Me.detailReport2 = New SideBySideReport.DetailReport()
			Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
			Me.detailReport1 = New SideBySideReport.DetailReport()
			CType(Me.detailReport2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.detailReport1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrSubreport2, Me.xrSubreport1})
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel1})
			Me.PageHeader.Height = 59
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(400, 25)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Employee Comparison"
			' 
			' xrLine1
			' 
			Me.xrLine1.Location = New System.Drawing.Point(8, 42)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.Size = New System.Drawing.Size(633, 17)
			' 
			' xrSubreport2
			' 
			Me.xrSubreport2.Location = New System.Drawing.Point(333, 8)
			Me.xrSubreport2.Name = "xrSubreport2"
			Me.xrSubreport2.ReportSource = Me.detailReport2
			Me.xrSubreport2.Size = New System.Drawing.Size(300, 58)
'			Me.xrSubreport2.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrSubreport2_BeforePrint_1);
			' 
			' xrSubreport1
			' 
			Me.xrSubreport1.Location = New System.Drawing.Point(8, 8)
			Me.xrSubreport1.Name = "xrSubreport1"
			Me.xrSubreport1.ReportSource = Me.detailReport1
			Me.xrSubreport1.Size = New System.Drawing.Size(300, 58)
'			Me.xrSubreport1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrSubreport1_BeforePrint);
			' 
			' MasterReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.DrawGrid = False
			Me.Version = "8.3"
			CType(Me.detailReport2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.detailReport1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
		Private WithEvents xrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
		Private detailReport2 As DetailReport
		Private detailReport1 As DetailReport
	End Class
End Namespace
