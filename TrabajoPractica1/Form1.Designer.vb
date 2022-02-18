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
        Me.buttonCalcSueldo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.Label()
        Me.sueldoResultadoText = New System.Windows.Forms.Label()
        Me.txtbName = New System.Windows.Forms.TextBox()
        Me.txtbDepartment = New System.Windows.Forms.TextBox()
        Me.txtbTurno = New System.Windows.Forms.TextBox()
        Me.txtbWorkedHours = New System.Windows.Forms.TextBox()
        Me.txtbPayHour = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'buttonCalcSueldo
        '
        Me.buttonCalcSueldo.Location = New System.Drawing.Point(643, 381)
        Me.buttonCalcSueldo.Name = "buttonCalcSueldo"
        Me.buttonCalcSueldo.Size = New System.Drawing.Size(145, 57)
        Me.buttonCalcSueldo.TabIndex = 0
        Me.buttonCalcSueldo.Text = "Calcular sueldo"
        Me.buttonCalcSueldo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Turno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Horas trabajadas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pago por hora"
        '
        'txtSueldo
        '
        Me.txtSueldo.AutoSize = True
        Me.txtSueldo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSueldo.Location = New System.Drawing.Point(25, 390)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(98, 30)
        Me.txtSueldo.TabIndex = 6
        Me.txtSueldo.Text = "SUELDO:"
        '
        'sueldoResultadoText
        '
        Me.sueldoResultadoText.AutoSize = True
        Me.sueldoResultadoText.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sueldoResultadoText.Location = New System.Drawing.Point(129, 390)
        Me.sueldoResultadoText.Name = "sueldoResultadoText"
        Me.sueldoResultadoText.Size = New System.Drawing.Size(34, 28)
        Me.sueldoResultadoText.TabIndex = 7
        Me.sueldoResultadoText.Text = "$0"
        '
        'txtbName
        '
        Me.txtbName.Location = New System.Drawing.Point(214, 53)
        Me.txtbName.Name = "txtbName"
        Me.txtbName.Size = New System.Drawing.Size(174, 23)
        Me.txtbName.TabIndex = 8
        '
        'txtbDepartment
        '
        Me.txtbDepartment.Location = New System.Drawing.Point(214, 92)
        Me.txtbDepartment.Name = "txtbDepartment"
        Me.txtbDepartment.Size = New System.Drawing.Size(174, 23)
        Me.txtbDepartment.TabIndex = 9
        '
        'txtbTurno
        '
        Me.txtbTurno.Location = New System.Drawing.Point(214, 152)
        Me.txtbTurno.Name = "txtbTurno"
        Me.txtbTurno.Size = New System.Drawing.Size(174, 23)
        Me.txtbTurno.TabIndex = 10
        '
        'txtbWorkedHours
        '
        Me.txtbWorkedHours.Location = New System.Drawing.Point(214, 201)
        Me.txtbWorkedHours.Name = "txtbWorkedHours"
        Me.txtbWorkedHours.Size = New System.Drawing.Size(75, 23)
        Me.txtbWorkedHours.TabIndex = 11
        '
        'txtbPayHour
        '
        Me.txtbPayHour.Location = New System.Drawing.Point(214, 254)
        Me.txtbPayHour.Name = "txtbPayHour"
        Me.txtbPayHour.Size = New System.Drawing.Size(75, 23)
        Me.txtbPayHour.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtbPayHour)
        Me.Controls.Add(Me.txtbWorkedHours)
        Me.Controls.Add(Me.txtbTurno)
        Me.Controls.Add(Me.txtbDepartment)
        Me.Controls.Add(Me.txtbName)
        Me.Controls.Add(Me.sueldoResultadoText)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonCalcSueldo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonCalcSueldo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSueldo As Label
    Friend WithEvents sueldoResultadoText As Label
    Friend WithEvents txtbName As TextBox
    Friend WithEvents txtbDepartment As TextBox
    Friend WithEvents txtbTurno As TextBox
    Friend WithEvents txtbWorkedHours As TextBox
    Friend WithEvents txtbPayHour As TextBox
End Class
