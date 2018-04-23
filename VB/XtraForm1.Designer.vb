Namespace EUD_NewReport
	Partial Public Class ReportChooser
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			Me.CancButton = New DevExpress.XtraEditors.SimpleButton()
			Me.OKButton = New DevExpress.XtraEditors.SimpleButton()
			DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.listBoxControl1.Items.AddRange(New Object() { "Blank Report", "Report1 (inherited from BaseReport1)", "Report2 (inherited from BaseReport2)"})
			Me.listBoxControl1.Location = New System.Drawing.Point(8, 8)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(347, 208)
			Me.listBoxControl1.TabIndex = 0
'			Me.listBoxControl1.DoubleClick += New System.EventHandler(Me.OKButton_Click)
'			Me.listBoxControl1.SelectedIndexChanged += New System.EventHandler(Me.listBoxControl1_SelectedIndexChanged)
			' 
			' CancButton
			' 
			Me.CancButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.CancButton.Location = New System.Drawing.Point(264, 224)
			Me.CancButton.Name = "CancButton"
			Me.CancButton.Size = New System.Drawing.Size(88, 32)
			Me.CancButton.TabIndex = 2
			Me.CancButton.Text = "Cancel"
'			Me.CancButton.Click += New System.EventHandler(Me.CancButton_Click)
			' 
			' OKButton
			' 
			Me.OKButton.Location = New System.Drawing.Point(160, 224)
			Me.OKButton.Name = "OKButton"
			Me.OKButton.Size = New System.Drawing.Size(88, 32)
			Me.OKButton.TabIndex = 1
			Me.OKButton.Text = "OK"
'			Me.OKButton.Click += New System.EventHandler(Me.OKButton_Click)
			' 
			' ReportChooser
			' 
			Me.AcceptButton = Me.OKButton
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CancelButton = Me.CancButton
			Me.ClientSize = New System.Drawing.Size(362, 264)
			Me.Controls.Add(Me.OKButton)
			Me.Controls.Add(Me.CancButton)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Name = "ReportChooser"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Choose Report"
'			Me.Load += New System.EventHandler(Me.ReportChooser_Load)
			DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
		Private WithEvents CancButton As DevExpress.XtraEditors.SimpleButton
		Private WithEvents OKButton As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace