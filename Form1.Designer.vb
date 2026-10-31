<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tabla1 = New ajedrez.tabla
        Me.SuspendLayout()
        '
        'Tabla1
        '
        Me.Tabla1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tabla1.Location = New System.Drawing.Point(9, 9)
        Me.Tabla1.Margin = New System.Windows.Forms.Padding(0)
        Me.Tabla1.Name = "Tabla1"
        Me.Tabla1.Size = New System.Drawing.Size(579, 575)
        Me.Tabla1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 587)
        Me.Controls.Add(Me.Tabla1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabla1 As ajedrez.tabla

    Private Sub Tabla1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabla1.Load

    End Sub
End Class
