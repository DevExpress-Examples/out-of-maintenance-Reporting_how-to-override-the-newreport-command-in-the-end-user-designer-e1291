Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace EUD_NewReport
	Partial Public Class ReportChooser
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub


        Private _index As Integer = -1

        Public Property Index() As Integer
            Get
                Return Me._index
            End Get
            Set(ByVal value As Integer)
                Me._index = value
            End Set
        End Property

        Private Sub ReportChooser_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.listBoxControl1.SelectedIndex = 0
        End Sub

        Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.SelectedIndexChanged
            Me._index = Me.listBoxControl1.SelectedIndex
        End Sub

        Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxControl1.DoubleClick, OKButton.Click
            Me.Close()
        End Sub

        Private Sub CancButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CancButton.Click
            Me._index = -1
            Me.Close()
        End Sub
	End Class
End Namespace