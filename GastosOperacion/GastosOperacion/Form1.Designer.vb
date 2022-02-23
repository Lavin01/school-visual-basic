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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxTotal = New System.Windows.Forms.TextBox()
        Me.tbxAgua = New System.Windows.Forms.TextBox()
        Me.tbxLuz = New System.Windows.Forms.TextBox()
        Me.tbxMaterial = New System.Windows.Forms.TextBox()
        Me.tbxMObra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGUA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LUZ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MATERIAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MANO DE OBRA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(365, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TOTAL DE GASTOS"
        '
        'tbxTotal
        '
        Me.tbxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTotal.Location = New System.Drawing.Point(418, 116)
        Me.tbxTotal.Name = "tbxTotal"
        Me.tbxTotal.ReadOnly = True
        Me.tbxTotal.Size = New System.Drawing.Size(100, 29)
        Me.tbxTotal.TabIndex = 5
        '
        'tbxAgua
        '
        Me.tbxAgua.Location = New System.Drawing.Point(158, 38)
        Me.tbxAgua.Name = "tbxAgua"
        Me.tbxAgua.Size = New System.Drawing.Size(100, 20)
        Me.tbxAgua.TabIndex = 6
        '
        'tbxLuz
        '
        Me.tbxLuz.Location = New System.Drawing.Point(158, 85)
        Me.tbxLuz.Name = "tbxLuz"
        Me.tbxLuz.Size = New System.Drawing.Size(100, 20)
        Me.tbxLuz.TabIndex = 7
        '
        'tbxMaterial
        '
        Me.tbxMaterial.Location = New System.Drawing.Point(158, 133)
        Me.tbxMaterial.Name = "tbxMaterial"
        Me.tbxMaterial.Size = New System.Drawing.Size(100, 20)
        Me.tbxMaterial.TabIndex = 8
        '
        'tbxMObra
        '
        Me.tbxMObra.Location = New System.Drawing.Point(158, 188)
        Me.tbxMObra.Name = "tbxMObra"
        Me.tbxMObra.Size = New System.Drawing.Size(100, 20)
        Me.tbxMObra.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 252)
        Me.Controls.Add(Me.tbxMObra)
        Me.Controls.Add(Me.tbxMaterial)
        Me.Controls.Add(Me.tbxLuz)
        Me.Controls.Add(Me.tbxAgua)
        Me.Controls.Add(Me.tbxTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Gastos de Operacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbxTotal As System.Windows.Forms.TextBox
    Friend WithEvents tbxAgua As System.Windows.Forms.TextBox
    Friend WithEvents tbxLuz As System.Windows.Forms.TextBox
    Friend WithEvents tbxMaterial As System.Windows.Forms.TextBox
    Friend WithEvents tbxMObra As System.Windows.Forms.TextBox

End Class
