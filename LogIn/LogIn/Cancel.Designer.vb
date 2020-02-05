<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnYes
        '
        Me.BtnYes.Location = New System.Drawing.Point(12, 25)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(75, 23)
        Me.BtnYes.TabIndex = 0
        Me.BtnYes.Text = "Yes"
        Me.BtnYes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Are you sure you want to close the Login?"
        '
        'BtnNo
        '
        Me.BtnNo.Location = New System.Drawing.Point(204, 25)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNo.TabIndex = 3
        Me.BtnNo.Text = "No"
        Me.BtnNo.UseVisualStyleBackColor = True
        '
        'Close
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 56)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnYes)
        Me.Name = "Close"
        Me.Text = "Close"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnYes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNo As Button
End Class
