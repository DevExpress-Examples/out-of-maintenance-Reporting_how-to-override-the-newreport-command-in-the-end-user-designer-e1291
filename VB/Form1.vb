Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
' ...


Namespace EUD_NewReport
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim form As New XRDesignFormEx()
			Dim panel As XRDesignPanel = form.DesignPanel

			panel.AddCommandHandler(New NewReportCommandHandler(panel))

			AddHandler form.Load, AddressOf form_Load

			form.ShowDialog()
		End Sub

		Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs)
			CType(sender, XRDesignFormEx).DesignPanel.ExecCommand(ReportCommand.NewReport)
		End Sub

		Public Class NewReportCommandHandler
			Implements ICommandHandler
			Private panel As XRDesignPanel
			Private chooser As ReportChooser

			Public Sub New(ByVal panel As XRDesignPanel)
				Me.panel = panel
				Me.chooser = New ReportChooser()
			End Sub

			Public Overridable Function CanHandleCommand(ByVal command As ReportCommand) As Boolean Implements ICommandHandler.CanHandleCommand
				Return command = ReportCommand.NewReport
			End Function

			Public Overridable Sub HandleCommand(ByVal command As ReportCommand, ByVal args() As Object, ByRef handled As Boolean) Implements ICommandHandler.HandleCommand
				If (Not CanHandleCommand(command)) Then
					Return
				End If

				Dim i As Integer = ChooseReport()
				If i <> -1 Then
					Me.panel.OpenReport(CreateReport(i))
				End If

				handled = True
			End Sub

			Private Function ChooseReport() As Integer
				Me.chooser.ShowDialog()
				Return Me.chooser.Index
			End Function

			Private Function CreateReport(ByVal index As Integer) As XtraReport
				Dim report As New XtraReport()

				Select Case index
					Case 1
						report = New Report1()
					Case 2
						report = New Report2()
					Case Else
						report.Bands.Add(New DetailBand())
				End Select

				Return report
			End Function

		End Class
	End Class
End Namespace