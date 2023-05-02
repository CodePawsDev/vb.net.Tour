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
        Me.btn_book = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.L_business_name = New System.Windows.Forms.Label()
        Me.L_business_detail = New System.Windows.Forms.Label()
        Me.l_country = New System.Windows.Forms.Label()
        Me.l_n_tourist = New System.Windows.Forms.Label()
        Me.combo_country = New System.Windows.Forms.ComboBox()
        Me.tb_tourist_no = New System.Windows.Forms.TextBox()
        Me.gb_car = New System.Windows.Forms.GroupBox()
        Me.rb_car_no = New System.Windows.Forms.RadioButton()
        Me.rb_car_yes = New System.Windows.Forms.RadioButton()
        Me.tb_car_day = New System.Windows.Forms.TextBox()
        Me.l_car_day = New System.Windows.Forms.Label()
        Me.tb_no_car = New System.Windows.Forms.TextBox()
        Me.l_no_car = New System.Windows.Forms.Label()
        Me.gb_room = New System.Windows.Forms.GroupBox()
        Me.rb_room_no = New System.Windows.Forms.RadioButton()
        Me.rb_room_yes = New System.Windows.Forms.RadioButton()
        Me.tb_room_day = New System.Windows.Forms.TextBox()
        Me.l_room_day = New System.Windows.Forms.Label()
        Me.tb_no_room = New System.Windows.Forms.TextBox()
        Me.l_no_room = New System.Windows.Forms.Label()
        Me.gb_car.SuspendLayout()
        Me.gb_room.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_book
        '
        Me.btn_book.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_book.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_book.ForeColor = System.Drawing.Color.Transparent
        Me.btn_book.Location = New System.Drawing.Point(161, 661)
        Me.btn_book.Name = "btn_book"
        Me.btn_book.Size = New System.Drawing.Size(102, 38)
        Me.btn_book.TabIndex = 1
        Me.btn_book.Text = "Book"
        Me.btn_book.UseVisualStyleBackColor = False
        '
        'btn_end
        '
        Me.btn_end.BackColor = System.Drawing.Color.Maroon
        Me.btn_end.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.ForeColor = System.Drawing.Color.Transparent
        Me.btn_end.Location = New System.Drawing.Point(318, 750)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(102, 38)
        Me.btn_end.TabIndex = 2
        Me.btn_end.Text = "End"
        Me.btn_end.UseVisualStyleBackColor = False
        '
        'L_business_name
        '
        Me.L_business_name.AutoSize = True
        Me.L_business_name.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_business_name.Location = New System.Drawing.Point(75, 14)
        Me.L_business_name.Name = "L_business_name"
        Me.L_business_name.Size = New System.Drawing.Size(303, 28)
        Me.L_business_name.TabIndex = 3
        Me.L_business_name.Text = "Pleasant Pathways Tours"
        '
        'L_business_detail
        '
        Me.L_business_detail.AutoSize = True
        Me.L_business_detail.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_business_detail.Location = New System.Drawing.Point(118, 57)
        Me.L_business_detail.Name = "L_business_detail"
        Me.L_business_detail.Size = New System.Drawing.Size(219, 22)
        Me.L_business_detail.TabIndex = 4
        Me.L_business_detail.Text = "6 days, 5 nights package"
        '
        'l_country
        '
        Me.l_country.AutoSize = True
        Me.l_country.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_country.Location = New System.Drawing.Point(37, 116)
        Me.l_country.Name = "l_country"
        Me.l_country.Size = New System.Drawing.Size(71, 21)
        Me.l_country.TabIndex = 5
        Me.l_country.Text = "Country"
        '
        'l_n_tourist
        '
        Me.l_n_tourist.AutoSize = True
        Me.l_n_tourist.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_n_tourist.Location = New System.Drawing.Point(37, 164)
        Me.l_n_tourist.Name = "l_n_tourist"
        Me.l_n_tourist.Size = New System.Drawing.Size(92, 21)
        Me.l_n_tourist.TabIndex = 6
        Me.l_n_tourist.Text = "Tourist no."
        '
        'combo_country
        '
        Me.combo_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_country.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_country.FormattingEnabled = True
        Me.combo_country.Items.AddRange(New Object() {"Portugal", "Bulgaria", "Poland", "Monaco", "Spain"})
        Me.combo_country.Location = New System.Drawing.Point(214, 109)
        Me.combo_country.Name = "combo_country"
        Me.combo_country.Size = New System.Drawing.Size(177, 29)
        Me.combo_country.TabIndex = 7
        '
        'tb_tourist_no
        '
        Me.tb_tourist_no.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tourist_no.Location = New System.Drawing.Point(214, 164)
        Me.tb_tourist_no.Name = "tb_tourist_no"
        Me.tb_tourist_no.Size = New System.Drawing.Size(177, 29)
        Me.tb_tourist_no.TabIndex = 8
        Me.tb_tourist_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gb_car
        '
        Me.gb_car.Controls.Add(Me.rb_car_no)
        Me.gb_car.Controls.Add(Me.rb_car_yes)
        Me.gb_car.Controls.Add(Me.tb_car_day)
        Me.gb_car.Controls.Add(Me.l_car_day)
        Me.gb_car.Controls.Add(Me.tb_no_car)
        Me.gb_car.Controls.Add(Me.l_no_car)
        Me.gb_car.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_car.Location = New System.Drawing.Point(48, 216)
        Me.gb_car.Name = "gb_car"
        Me.gb_car.Size = New System.Drawing.Size(343, 202)
        Me.gb_car.TabIndex = 9
        Me.gb_car.TabStop = False
        Me.gb_car.Text = "Car rent"
        '
        'rb_car_no
        '
        Me.rb_car_no.AutoSize = True
        Me.rb_car_no.Location = New System.Drawing.Point(213, 41)
        Me.rb_car_no.Name = "rb_car_no"
        Me.rb_car_no.Size = New System.Drawing.Size(51, 25)
        Me.rb_car_no.TabIndex = 15
        Me.rb_car_no.TabStop = True
        Me.rb_car_no.Text = "No"
        Me.rb_car_no.UseVisualStyleBackColor = True
        '
        'rb_car_yes
        '
        Me.rb_car_yes.AutoSize = True
        Me.rb_car_yes.Location = New System.Drawing.Point(67, 41)
        Me.rb_car_yes.Name = "rb_car_yes"
        Me.rb_car_yes.Size = New System.Drawing.Size(55, 25)
        Me.rb_car_yes.TabIndex = 14
        Me.rb_car_yes.TabStop = True
        Me.rb_car_yes.Text = "Yes"
        Me.rb_car_yes.UseVisualStyleBackColor = True
        '
        'tb_car_day
        '
        Me.tb_car_day.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_car_day.Location = New System.Drawing.Point(213, 136)
        Me.tb_car_day.Name = "tb_car_day"
        Me.tb_car_day.Size = New System.Drawing.Size(102, 29)
        Me.tb_car_day.TabIndex = 13
        Me.tb_car_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'l_car_day
        '
        Me.l_car_day.AutoSize = True
        Me.l_car_day.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_car_day.Location = New System.Drawing.Point(63, 139)
        Me.l_car_day.Name = "l_car_day"
        Me.l_car_day.Size = New System.Drawing.Size(91, 21)
        Me.l_car_day.TabIndex = 12
        Me.l_car_day.Text = "No. of day"
        '
        'tb_no_car
        '
        Me.tb_no_car.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_no_car.Location = New System.Drawing.Point(213, 88)
        Me.tb_no_car.Name = "tb_no_car"
        Me.tb_no_car.Size = New System.Drawing.Size(102, 29)
        Me.tb_no_car.TabIndex = 11
        Me.tb_no_car.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'l_no_car
        '
        Me.l_no_car.AutoSize = True
        Me.l_no_car.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_no_car.Location = New System.Drawing.Point(63, 91)
        Me.l_no_car.Name = "l_no_car"
        Me.l_no_car.Size = New System.Drawing.Size(87, 21)
        Me.l_no_car.TabIndex = 10
        Me.l_no_car.Text = "No. of car"
        '
        'gb_room
        '
        Me.gb_room.Controls.Add(Me.rb_room_no)
        Me.gb_room.Controls.Add(Me.rb_room_yes)
        Me.gb_room.Controls.Add(Me.tb_room_day)
        Me.gb_room.Controls.Add(Me.l_room_day)
        Me.gb_room.Controls.Add(Me.tb_no_room)
        Me.gb_room.Controls.Add(Me.l_no_room)
        Me.gb_room.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_room.Location = New System.Drawing.Point(48, 435)
        Me.gb_room.Name = "gb_room"
        Me.gb_room.Size = New System.Drawing.Size(343, 202)
        Me.gb_room.TabIndex = 16
        Me.gb_room.TabStop = False
        Me.gb_room.Text = "Accommodation"
        '
        'rb_room_no
        '
        Me.rb_room_no.AutoSize = True
        Me.rb_room_no.Location = New System.Drawing.Point(213, 41)
        Me.rb_room_no.Name = "rb_room_no"
        Me.rb_room_no.Size = New System.Drawing.Size(51, 25)
        Me.rb_room_no.TabIndex = 15
        Me.rb_room_no.TabStop = True
        Me.rb_room_no.Text = "No"
        Me.rb_room_no.UseVisualStyleBackColor = True
        '
        'rb_room_yes
        '
        Me.rb_room_yes.AutoSize = True
        Me.rb_room_yes.Location = New System.Drawing.Point(67, 41)
        Me.rb_room_yes.Name = "rb_room_yes"
        Me.rb_room_yes.Size = New System.Drawing.Size(55, 25)
        Me.rb_room_yes.TabIndex = 14
        Me.rb_room_yes.TabStop = True
        Me.rb_room_yes.Text = "Yes"
        Me.rb_room_yes.UseVisualStyleBackColor = True
        '
        'tb_room_day
        '
        Me.tb_room_day.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_room_day.Location = New System.Drawing.Point(213, 136)
        Me.tb_room_day.Name = "tb_room_day"
        Me.tb_room_day.Size = New System.Drawing.Size(102, 29)
        Me.tb_room_day.TabIndex = 13
        Me.tb_room_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'l_room_day
        '
        Me.l_room_day.AutoSize = True
        Me.l_room_day.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_room_day.Location = New System.Drawing.Point(63, 139)
        Me.l_room_day.Name = "l_room_day"
        Me.l_room_day.Size = New System.Drawing.Size(91, 21)
        Me.l_room_day.TabIndex = 12
        Me.l_room_day.Text = "No. of day"
        '
        'tb_no_room
        '
        Me.tb_no_room.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_no_room.Location = New System.Drawing.Point(213, 88)
        Me.tb_no_room.Name = "tb_no_room"
        Me.tb_no_room.Size = New System.Drawing.Size(102, 29)
        Me.tb_no_room.TabIndex = 11
        Me.tb_no_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'l_no_room
        '
        Me.l_no_room.AutoSize = True
        Me.l_no_room.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_no_room.Location = New System.Drawing.Point(63, 91)
        Me.l_no_room.Name = "l_no_room"
        Me.l_no_room.Size = New System.Drawing.Size(104, 21)
        Me.l_no_room.TabIndex = 10
        Me.l_no_room.Text = "No. of room"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 809)
        Me.Controls.Add(Me.gb_car)
        Me.Controls.Add(Me.tb_tourist_no)
        Me.Controls.Add(Me.combo_country)
        Me.Controls.Add(Me.l_n_tourist)
        Me.Controls.Add(Me.l_country)
        Me.Controls.Add(Me.L_business_detail)
        Me.Controls.Add(Me.L_business_name)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_book)
        Me.Controls.Add(Me.gb_room)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gb_car.ResumeLayout(False)
        Me.gb_car.PerformLayout()
        Me.gb_room.ResumeLayout(False)
        Me.gb_room.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_book As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents L_business_name As Label
    Friend WithEvents L_business_detail As Label
    Friend WithEvents l_country As Label
    Friend WithEvents l_n_tourist As Label
    Friend WithEvents combo_country As ComboBox
    Friend WithEvents tb_tourist_no As TextBox
    Friend WithEvents gb_car As GroupBox
    Friend WithEvents rb_car_no As RadioButton
    Friend WithEvents rb_car_yes As RadioButton
    Friend WithEvents tb_car_day As TextBox
    Friend WithEvents l_car_day As Label
    Friend WithEvents tb_no_car As TextBox
    Friend WithEvents l_no_car As Label
    Friend WithEvents gb_room As GroupBox
    Friend WithEvents rb_room_no As RadioButton
    Friend WithEvents rb_room_yes As RadioButton
    Friend WithEvents tb_room_day As TextBox
    Friend WithEvents l_room_day As Label
    Friend WithEvents tb_no_room As TextBox
    Friend WithEvents l_no_room As Label
End Class
