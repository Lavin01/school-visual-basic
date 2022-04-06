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
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNServicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUDni = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUPhone = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrevio = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.DGTabla = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.Location = New System.Drawing.Point(39, 72)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(138, 26)
        Me.txtMatricula.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MATRICULA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha de Salida"
        '
        'txtSalida
        '
        Me.txtSalida.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalida.Location = New System.Drawing.Point(38, 196)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.Size = New System.Drawing.Size(138, 26)
        Me.txtSalida.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(989, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "(ID) Num. Servicio"
        '
        'txtNServicio
        '
        Me.txtNServicio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNServicio.Location = New System.Drawing.Point(993, 85)
        Me.txtNServicio.Name = "txtNServicio"
        Me.txtNServicio.Size = New System.Drawing.Size(150, 26)
        Me.txtNServicio.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Entrada"
        '
        'txtEntrada
        '
        Me.txtEntrada.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.Location = New System.Drawing.Point(38, 274)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(138, 26)
        Me.txtEntrada.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DNI"
        '
        'txtUDni
        '
        Me.txtUDni.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtUDni.Location = New System.Drawing.Point(17, 54)
        Me.txtUDni.Name = "txtUDni"
        Me.txtUDni.Size = New System.Drawing.Size(138, 23)
        Me.txtUDni.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Teléfono"
        '
        'txtUPhone
        '
        Me.txtUPhone.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtUPhone.Location = New System.Drawing.Point(17, 110)
        Me.txtUPhone.Name = "txtUPhone"
        Me.txtUPhone.Size = New System.Drawing.Size(138, 23)
        Me.txtUPhone.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUPhone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUDni)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(984, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 150)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBox1.Location = New System.Drawing.Point(405, 368)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(273, 96)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(474, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Observaciones"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SQL_RentACar.My.Resources.Resources.Logo_hd_rent_a_car
        Me.PictureBox1.Location = New System.Drawing.Point(355, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(362, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnPrevio
        '
        Me.btnPrevio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevio.Location = New System.Drawing.Point(38, 369)
        Me.btnPrevio.Name = "btnPrevio"
        Me.btnPrevio.Size = New System.Drawing.Size(136, 54)
        Me.btnPrevio.TabIndex = 16
        Me.btnPrevio.Text = "PREVIO"
        Me.btnPrevio.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.Transparent
        Me.btnSiguiente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(993, 382)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(150, 54)
        Me.btnSiguiente.TabIndex = 17
        Me.btnSiguiente.Text = "SIGUIENTE"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'DGTabla
        '
        Me.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTabla.Location = New System.Drawing.Point(197, 90)
        Me.DGTabla.Name = "DGTabla"
        Me.DGTabla.Size = New System.Drawing.Size(764, 248)
        Me.DGTabla.TabIndex = 18
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(197, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 54)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "LIMPIAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 473)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.DGTabla)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnPrevio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNServicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMatricula)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUDni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUPhone As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrevio As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents DGTabla As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
