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
        Me.lstTicket = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddItem = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTicket
        '
        Me.lstTicket.FormattingEnabled = True
        Me.lstTicket.Location = New System.Drawing.Point(146, 150)
        Me.lstTicket.Name = "lstTicket"
        Me.lstTicket.Size = New System.Drawing.Size(161, 199)
        Me.lstTicket.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AGREGAR ITEM"
        '
        'txtAddItem
        '
        Me.txtAddItem.Location = New System.Drawing.Point(456, 152)
        Me.txtAddItem.Name = "txtAddItem"
        Me.txtAddItem.Size = New System.Drawing.Size(122, 20)
        Me.txtAddItem.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(456, 275)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 74)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 460)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtAddItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTicket)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTicket As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddItem As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button

End Class
