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
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxRequerida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSolicitud = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxCantidadMasDeuda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxPorcentaje = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE DEL EMPLEADO"
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(172, 25)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(100, 20)
        Me.tbxName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CANTIDAD REQUERIDA"
        '
        'tbxRequerida
        '
        Me.tbxRequerida.Location = New System.Drawing.Point(172, 66)
        Me.tbxRequerida.Name = "tbxRequerida"
        Me.tbxRequerida.Size = New System.Drawing.Size(100, 20)
        Me.tbxRequerida.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PLAZO DEL PRESTAMO"
        '
        'btnSolicitud
        '
        Me.btnSolicitud.Location = New System.Drawing.Point(29, 191)
        Me.btnSolicitud.Name = "btnSolicitud"
        Me.btnSolicitud.Size = New System.Drawing.Size(243, 23)
        Me.btnSolicitud.TabIndex = 7
        Me.btnSolicitud.Text = "SOLICITAR PRESTAMO"
        Me.btnSolicitud.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(493, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DATOS GENERALES ESTAMADOS DEL PRESTAMO"
        '
        'tbxCantidadMasDeuda
        '
        Me.tbxCantidadMasDeuda.Location = New System.Drawing.Point(636, 63)
        Me.tbxCantidadMasDeuda.Name = "tbxCantidadMasDeuda"
        Me.tbxCantidadMasDeuda.ReadOnly = True
        Me.tbxCantidadMasDeuda.Size = New System.Drawing.Size(100, 20)
        Me.tbxCantidadMasDeuda.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(493, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DINERO TOTAL A PAGAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(493, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "PORCENTAJE"
        '
        'tbxPorcentaje
        '
        Me.tbxPorcentaje.Location = New System.Drawing.Point(636, 109)
        Me.tbxPorcentaje.Name = "tbxPorcentaje"
        Me.tbxPorcentaje.ReadOnly = True
        Me.tbxPorcentaje.Size = New System.Drawing.Size(100, 20)
        Me.tbxPorcentaje.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"30 dias", "60 dias", "90 dias"})
        Me.ComboBox1.Location = New System.Drawing.Point(29, 128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 238)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.tbxPorcentaje)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxCantidadMasDeuda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSolicitud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxRequerida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxRequerida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSolicitud As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbxCantidadMasDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbxPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
