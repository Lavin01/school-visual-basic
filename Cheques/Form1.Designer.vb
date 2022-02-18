<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cantidadCheque = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cantidadComision = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dineroComision = New System.Windows.Forms.TextBox()
        Me.tBXResultado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL BANCO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 23)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CANTIDAD DEL CHEQUE"
        '
        'cantidadCheque
        '
        Me.cantidadCheque.Location = New System.Drawing.Point(12, 128)
        Me.cantidadCheque.Name = "cantidadCheque"
        Me.cantidadCheque.Size = New System.Drawing.Size(184, 23)
        Me.cantidadCheque.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(261, 27)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 23)
        Me.TextBox3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIPO DE BANCO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "BANCO"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(473, 27)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 7
        '
        'cantidadComision
        '
        Me.cantidadComision.Location = New System.Drawing.Point(261, 128)
        Me.cantidadComision.Name = "cantidadComision"
        Me.cantidadComision.Size = New System.Drawing.Size(100, 23)
        Me.cantidadComision.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "COMISION"
        '
        'dineroComision
        '
        Me.dineroComision.Location = New System.Drawing.Point(12, 212)
        Me.dineroComision.Name = "dineroComision"
        Me.dineroComision.ReadOnly = True
        Me.dineroComision.Size = New System.Drawing.Size(100, 23)
        Me.dineroComision.TabIndex = 10
        '
        'tBXResultado
        '
        Me.tBXResultado.Location = New System.Drawing.Point(12, 303)
        Me.tBXResultado.Name = "tBXResultado"
        Me.tBXResultado.ReadOnly = True
        Me.tBXResultado.Size = New System.Drawing.Size(100, 23)
        Me.tBXResultado.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "DINERO COBRADO POR LA COMISION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "DINERO TOTAL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cheques.My.Resources.Resources._6160630_0
        Me.PictureBox1.Location = New System.Drawing.Point(336, 269)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 221)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 348)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tBXResultado)
        Me.Controls.Add(Me.dineroComision)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cantidadComision)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cantidadCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cantidadCheque As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cantidadComision As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dineroComision As TextBox
    Friend WithEvents tBXResultado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
