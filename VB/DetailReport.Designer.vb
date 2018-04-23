Imports Microsoft.VisualBasic
Imports System
Namespace SideBySideReport
	Partial Public Class DetailReport
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
			Me.nwindDataSet1 = New SideBySideReport.Data.nwindDataSet()
			Me.employeesTableAdapter = New SideBySideReport.Data.nwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1, Me.xrPictureBox1})
			Me.Detail.Height = 242
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
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
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' xrPictureBox1
			' 
			Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Employees.Photo", "")})
			Me.xrPictureBox1.Location = New System.Drawing.Point(8, 17)
			Me.xrPictureBox1.Name = "xrPictureBox1"
			Me.xrPictureBox1.Size = New System.Drawing.Size(142, 92)
			Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.Location = New System.Drawing.Point(158, 17)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.Size = New System.Drawing.Size(150, 25)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "[FirstName] [LastName]"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel2.Location = New System.Drawing.Point(158, 50)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.Size = New System.Drawing.Size(150, 25)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "Birth Date: [BirthDate!MM/dd/yyyy]"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.xrLabel3.Location = New System.Drawing.Point(158, 83)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel3.Size = New System.Drawing.Size(150, 25)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.Text = "Phone: [HomePhone]"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Location = New System.Drawing.Point(8, 133)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel4.Size = New System.Drawing.Size(300, 25)
			Me.xrLabel4.Text = "Position: [Title]"
			' 
			' xrLabel5
			' 
			Me.xrLabel5.Location = New System.Drawing.Point(8, 167)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel5.Size = New System.Drawing.Size(300, 25)
			Me.xrLabel5.Text = "HireDate: [HireDate!MM/dd/yyyy]"
			' 
			' xrLabel6
			' 
			Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Notes", "")})
			Me.xrLabel6.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic)
			Me.xrLabel6.Location = New System.Drawing.Point(8, 200)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel6.Size = New System.Drawing.Size(300, 25)
			Me.xrLabel6.StylePriority.UseFont = False
			Me.xrLabel6.Text = "xrLabel6"
			' 
			' DetailReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.DataAdapter = Me.employeesTableAdapter
			Me.DataMember = "Employees"
			Me.DataSource = Me.nwindDataSet1
			Me.DrawGrid = False
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Margins = New System.Drawing.Printing.Margins(100, 430, 100, 100)
			Me.Version = "8.3"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As SideBySideReport.Data.nwindDataSet
		Private employeesTableAdapter As SideBySideReport.Data.nwindDataSetTableAdapters.EmployeesTableAdapter
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
