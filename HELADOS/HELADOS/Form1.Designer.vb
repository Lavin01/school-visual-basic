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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cB1 = New System.Windows.Forms.CheckBox()
        Me.rTipoCono = New System.Windows.Forms.RadioButton()
        Me.rTipoVaso = New System.Windows.Forms.RadioButton()
        Me.cB2 = New System.Windows.Forms.CheckBox()
        Me.cB3 = New System.Windows.Forms.CheckBox()
        Me.cB4 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.optChico = New System.Windows.Forms.RadioButton()
        Me.optMediano = New System.Windows.Forms.RadioButton()
        Me.optGrande = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cB1
        '
        Me.cB1.AutoSize = True
        Me.cB1.BackColor = System.Drawing.SystemColors.Window
        Me.cB1.Location = New System.Drawing.Point(29, 30)
        Me.cB1.Name = "cB1"
        Me.cB1.Size = New System.Drawing.Size(72, 17)
        Me.cB1.TabIndex = 0
        Me.cB1.Text = "CHISPAS"
        Me.cB1.UseVisualStyleBackColor = False
        '
        'rTipoCono
        '
        Me.rTipoCono.AutoSize = True
        Me.rTipoCono.Location = New System.Drawing.Point(20, 30)
        Me.rTipoCono.Name = "rTipoCono"
        Me.rTipoCono.Size = New System.Drawing.Size(56, 17)
        Me.rTipoCono.TabIndex = 1
        Me.rTipoCono.TabStop = True
        Me.rTipoCono.Text = "CONO"
        Me.rTipoCono.UseVisualStyleBackColor = True
        '
        'rTipoVaso
        '
        Me.rTipoVaso.AutoSize = True
        Me.rTipoVaso.Location = New System.Drawing.Point(94, 30)
        Me.rTipoVaso.Name = "rTipoVaso"
        Me.rTipoVaso.Size = New System.Drawing.Size(54, 17)
        Me.rTipoVaso.TabIndex = 2
        Me.rTipoVaso.TabStop = True
        Me.rTipoVaso.Text = "VASO"
        Me.rTipoVaso.UseVisualStyleBackColor = True
        '
        'cB2
        '
        Me.cB2.AutoSize = True
        Me.cB2.BackColor = System.Drawing.SystemColors.Window
        Me.cB2.Location = New System.Drawing.Point(29, 71)
        Me.cB2.Name = "cB2"
        Me.cB2.Size = New System.Drawing.Size(80, 17)
        Me.cB2.TabIndex = 3
        Me.cB2.Text = "M AND M's"
        Me.cB2.UseVisualStyleBackColor = False
        '
        'cB3
        '
        Me.cB3.AutoSize = True
        Me.cB3.BackColor = System.Drawing.SystemColors.Window
        Me.cB3.Location = New System.Drawing.Point(29, 119)
        Me.cB3.Name = "cB3"
        Me.cB3.Size = New System.Drawing.Size(57, 17)
        Me.cB3.TabIndex = 4
        Me.cB3.Text = "OREO"
        Me.cB3.UseVisualStyleBackColor = False
        '
        'cB4
        '
        Me.cB4.AutoSize = True
        Me.cB4.BackColor = System.Drawing.SystemColors.Window
        Me.cB4.Location = New System.Drawing.Point(29, 167)
        Me.cB4.Name = "cB4"
        Me.cB4.Size = New System.Drawing.Size(64, 17)
        Me.cB4.TabIndex = 5
        Me.cB4.Text = "KISSES"
        Me.cB4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TOTAL A PAGAR:"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(272, 360)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(36, 25)
        Me.lblResultado.TabIndex = 10
        Me.lblResultado.Text = "$0"
        '
        'optChico
        '
        Me.optChico.AutoSize = True
        Me.optChico.Location = New System.Drawing.Point(20, 35)
        Me.optChico.Name = "optChico"
        Me.optChico.Size = New System.Drawing.Size(58, 17)
        Me.optChico.TabIndex = 6
        Me.optChico.TabStop = True
        Me.optChico.Text = "CHICO"
        Me.optChico.UseVisualStyleBackColor = True
        '
        'optMediano
        '
        Me.optMediano.AutoSize = True
        Me.optMediano.Location = New System.Drawing.Point(20, 76)
        Me.optMediano.Name = "optMediano"
        Me.optMediano.Size = New System.Drawing.Size(75, 17)
        Me.optMediano.TabIndex = 7
        Me.optMediano.TabStop = True
        Me.optMediano.Text = "MEDIANO"
        Me.optMediano.UseVisualStyleBackColor = True
        '
        'optGrande
        '
        Me.optGrande.AutoSize = True
        Me.optGrande.Location = New System.Drawing.Point(20, 118)
        Me.optGrande.Name = "optGrande"
        Me.optGrande.Size = New System.Drawing.Size(71, 17)
        Me.optGrande.TabIndex = 8
        Me.optGrande.TabStop = True
        Me.optGrande.Text = "GRANDE"
        Me.optGrande.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.optGrande)
        Me.GroupBox1.Controls.Add(Me.optMediano)
        Me.GroupBox1.Controls.Add(Me.optChico)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(117, 153)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Controls.Add(Me.rTipoVaso)
        Me.GroupBox2.Controls.Add(Me.rTipoCono)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 63)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TIPO"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnNuevo.FlatAppearance.BorderSize = 2
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(32, 414)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(76, 38)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Tomato
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(317, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 38)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(48, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "HELADOS EL CONO FELIZ"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"FRESA", "VAINILLA", "CHOCOLATE", "LIMON", "ALGODON", "PLATANO", "GANSITO"})
        Me.ComboBox1.Location = New System.Drawing.Point(235, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.cB4)
        Me.GroupBox3.Controls.Add(Me.cB3)
        Me.GroupBox3.Controls.Add(Me.cB2)
        Me.GroupBox3.Controls.Add(Me.cB1)
        Me.GroupBox3.Location = New System.Drawing.Point(235, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(135, 200)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EXTRAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(403, 468)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "HELADERIA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cB1 As System.Windows.Forms.CheckBox
    Friend WithEvents rTipoCono As System.Windows.Forms.RadioButton
    Friend WithEvents rTipoVaso As System.Windows.Forms.RadioButton
    Friend WithEvents cB2 As System.Windows.Forms.CheckBox
    Friend WithEvents cB3 As System.Windows.Forms.CheckBox
    Friend WithEvents cB4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents optChico As System.Windows.Forms.RadioButton
    Friend WithEvents optMediano As System.Windows.Forms.RadioButton
    Friend WithEvents optGrande As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
