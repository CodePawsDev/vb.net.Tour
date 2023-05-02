<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.L_business_detail = New System.Windows.Forms.Label()
        Me.l_paid = New System.Windows.Forms.Label()
        Me.l_total = New System.Windows.Forms.Label()
        Me.l_change = New System.Windows.Forms.Label()
        Me.tb_paid = New System.Windows.Forms.TextBox()
        Me.l_total_show = New System.Windows.Forms.Label()
        Me.l_change_show = New System.Windows.Forms.Label()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L_business_detail
        '
        Me.L_business_detail.AutoSize = True
        Me.L_business_detail.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_business_detail.Location = New System.Drawing.Point(136, 21)
        Me.L_business_detail.Name = "L_business_detail"
        Me.L_business_detail.Size = New System.Drawing.Size(73, 22)
        Me.L_business_detail.TabIndex = 6
        Me.L_business_detail.Text = "Bill Info"
        '
        'l_paid
        '
        Me.l_paid.AutoSize = True
        Me.l_paid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_paid.Location = New System.Drawing.Point(34, 111)
        Me.l_paid.Name = "l_paid"
        Me.l_paid.Size = New System.Drawing.Size(43, 21)
        Me.l_paid.TabIndex = 8
        Me.l_paid.Text = "Paid"
        '
        'l_total
        '
        Me.l_total.AutoSize = True
        Me.l_total.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_total.Location = New System.Drawing.Point(34, 62)
        Me.l_total.Name = "l_total"
        Me.l_total.Size = New System.Drawing.Size(48, 21)
        Me.l_total.TabIndex = 7
        Me.l_total.Text = "Total"
        '
        'l_change
        '
        Me.l_change.AutoSize = True
        Me.l_change.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_change.Location = New System.Drawing.Point(34, 160)
        Me.l_change.Name = "l_change"
        Me.l_change.Size = New System.Drawing.Size(66, 21)
        Me.l_change.TabIndex = 9
        Me.l_change.Text = "Change"
        '
        'tb_paid
        '
        Me.tb_paid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_paid.Location = New System.Drawing.Point(140, 108)
        Me.tb_paid.Name = "tb_paid"
        Me.tb_paid.Size = New System.Drawing.Size(132, 29)
        Me.tb_paid.TabIndex = 10
        '
        'l_total_show
        '
        Me.l_total_show.AutoSize = True
        Me.l_total_show.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_total_show.Location = New System.Drawing.Point(146, 62)
        Me.l_total_show.Name = "l_total_show"
        Me.l_total_show.Size = New System.Drawing.Size(130, 21)
        Me.l_total_show.TabIndex = 11
        Me.l_total_show.Text = "____________"
        Me.l_total_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_change_show
        '
        Me.l_change_show.AutoSize = True
        Me.l_change_show.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_change_show.Location = New System.Drawing.Point(146, 160)
        Me.l_change_show.Name = "l_change_show"
        Me.l_change_show.Size = New System.Drawing.Size(130, 21)
        Me.l_change_show.TabIndex = 12
        Me.l_change_show.Text = "____________"
        Me.l_change_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_check.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.ForeColor = System.Drawing.Color.Transparent
        Me.btn_check.Location = New System.Drawing.Point(53, 216)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(102, 38)
        Me.btn_check.TabIndex = 13
        Me.btn_check.Text = "Check"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(170, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 38)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Invoice"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 296)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.l_change_show)
        Me.Controls.Add(Me.l_total_show)
        Me.Controls.Add(Me.tb_paid)
        Me.Controls.Add(Me.l_change)
        Me.Controls.Add(Me.l_paid)
        Me.Controls.Add(Me.l_total)
        Me.Controls.Add(Me.L_business_detail)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L_business_detail As Label
    Friend WithEvents l_paid As Label
    Friend WithEvents l_total As Label
    Friend WithEvents l_change As Label
    Friend WithEvents tb_paid As TextBox
    Friend WithEvents l_total_show As Label
    Friend WithEvents l_change_show As Label
    Friend WithEvents btn_check As Button
    Friend WithEvents Button1 As Button
End Class
