<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.Import = New System.Windows.Forms.Button()
        Me.Generate = New System.Windows.Forms.Button()
        Me.Export = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Import
        '
        Me.Import.Location = New System.Drawing.Point(107, 62)
        Me.Import.Name = "Import"
        Me.Import.Size = New System.Drawing.Size(75, 23)
        Me.Import.TabIndex = 0
        Me.Import.Text = "Import"
        Me.Import.UseVisualStyleBackColor = True
        '
        'Generate
        '
        Me.Generate.Location = New System.Drawing.Point(105, 120)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(75, 23)
        Me.Generate.TabIndex = 1
        Me.Generate.Text = "Generate"
        Me.Generate.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Location = New System.Drawing.Point(107, 180)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(75, 23)
        Me.Export.TabIndex = 2
        Me.Export.Text = "Export"
        Me.Export.UseVisualStyleBackColor = True
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.Generate)
        Me.Controls.Add(Me.Import)
        Me.Name = "StartForm"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Import As Button
    Friend WithEvents Generate As Button
    Friend WithEvents Export As Button
End Class
