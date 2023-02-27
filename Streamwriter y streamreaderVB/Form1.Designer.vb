<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.rtbCampo = New System.Windows.Forms.RichTextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbCampo
        '
        Me.rtbCampo.Location = New System.Drawing.Point(191, 167)
        Me.rtbCampo.Name = "rtbCampo"
        Me.rtbCampo.Size = New System.Drawing.Size(360, 141)
        Me.rtbCampo.TabIndex = 0
        Me.rtbCampo.Text = ""
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(149, 57)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(107, 52)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Leer"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(502, 57)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(107, 52)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "Escribir"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.rtbCampo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbCampo As RichTextBox
    Friend WithEvents btnRead As Button
    Friend WithEvents btnWrite As Button
End Class
