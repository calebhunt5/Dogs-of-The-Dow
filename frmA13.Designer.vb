<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmA13
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
        Me.grpDogs = New System.Windows.Forms.GroupBox()
        Me.lstDogs = New System.Windows.Forms.ListBox()
        Me.grpDogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDogs
        '
        Me.grpDogs.Controls.Add(Me.lstDogs)
        Me.grpDogs.Font = New System.Drawing.Font("Ebrima", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDogs.Location = New System.Drawing.Point(12, 12)
        Me.grpDogs.Name = "grpDogs"
        Me.grpDogs.Size = New System.Drawing.Size(1034, 598)
        Me.grpDogs.TabIndex = 0
        Me.grpDogs.TabStop = False
        Me.grpDogs.Text = "Dogs of the Dow"
        '
        'lstDogs
        '
        Me.lstDogs.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDogs.FormattingEnabled = True
        Me.lstDogs.ItemHeight = 23
        Me.lstDogs.Location = New System.Drawing.Point(6, 30)
        Me.lstDogs.Name = "lstDogs"
        Me.lstDogs.Size = New System.Drawing.Size(1018, 556)
        Me.lstDogs.TabIndex = 0
        '
        'frmA13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 622)
        Me.Controls.Add(Me.grpDogs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmA13"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment 13 - Dogs of the Dow"
        Me.grpDogs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDogs As GroupBox
    Friend WithEvents lstDogs As ListBox
End Class
