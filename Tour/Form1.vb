Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim n_car, car_day As Integer
    Dim rent_car As Char

    Dim n_room, room_day As Integer
    Dim rent_room As Char

    Dim country As String
    Dim n_tourist As Integer

    Dim package_price, country_room_price As Integer ' price depend on condition
    Public total_price As Integer ' use public to send it to Form2, too
    Dim total_pack_price, total_car_price, total_room_price As Integer

    ' sell summary var 
    Dim total_income As Integer
    Dim total_pack As Integer
    Dim tp_1, tp_2, tp_3, tp_4, tp_5 As Integer

    Private Sub ResetForm()
        combo_country.SelectedIndex = -1
        tb_tourist_no.Clear()
        rb_car_yes.Checked = False
        rb_car_no.Checked = False
        rb_room_yes.Checked = False
        rb_room_no.Checked = False

        tb_no_car.Clear()
        tb_car_day.Clear()
        tb_no_room.Clear()
        tb_room_day.Clear()
    End Sub

    Private Sub rb_car_yes_CheckedChanged(sender As Object, e As EventArgs) Handles rb_car_yes.CheckedChanged

        rent_car = "Y"

        ' check and clear default 0 in Textbox in case user pick no first
        If tb_no_car IsNot "" Then
            tb_no_car.Clear()
            tb_car_day.Clear()
        End If

    End Sub

    Private Sub rb_car_no_CheckedChanged(sender As Object, e As EventArgs) Handles rb_car_no.CheckedChanged

        rent_car = "N"
        n_car = 0
        car_day = 0
        tb_no_car.Text = n_car ' auto fill 0 in Textbox
        tb_car_day.Text = car_day

    End Sub

    Private Sub rb_room_yes_CheckedChanged(sender As Object, e As EventArgs) Handles rb_room_yes.CheckedChanged

        rent_room = "Y"

        ' check and clear default 0 in Textbox in case user pick no first
        If tb_no_room IsNot "" Then
            tb_no_room.Clear()
            tb_room_day.Clear()
        End If

    End Sub

    Private Sub rb_room_no_CheckedChanged(sender As Object, e As EventArgs) Handles rb_room_no.CheckedChanged

        rent_room = "N"
        n_room = 0
        room_day = 0

        tb_no_room.Text = n_room ' auto fill 0 in Textbox
        tb_room_day.Text = room_day

    End Sub

    Private Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click

        country = combo_country.SelectedItem.ToString() ' get country from comboBox
        n_tourist = Integer.Parse(tb_tourist_no.Text)
        n_car = Integer.Parse(tb_no_car.Text)
        car_day = Integer.Parse(tb_car_day.Text)
        n_room = Integer.Parse(tb_no_room.Text)
        room_day = Integer.Parse(tb_room_day.Text)

        ' check each input if not correct reset form1 and let's the user input info again
        Dim error_txt As String
        If n_tourist < 1 Then
            error_txt = "Number of tourist can not be 0" & vbNewLine & "please fill the form again"
            MessageBox.Show(error_txt, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetForm()
            Return
        ElseIf rent_car = "Y" AndAlso (n_car < 1 Or car_day < 1 Or car_day > 6) Then
            error_txt = "Number of car or day is invalid" & vbNewLine & "please fill the form again"
            MessageBox.Show(error_txt, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetForm()
            Return
        ElseIf rent_room = "Y" AndAlso (n_room < 1 Or room_day < 1 Or room_day > 5) Then
            error_txt = "Number of room or day is invalid" & vbNewLine & "please fill the form again"
            MessageBox.Show(error_txt, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetForm()
            Return
        End If

        ' calculate base on country choice
        Select Case country

            Case " Portugal"
                package_price = 50000
                country_room_price = 2000 ' room price base on choice
            Case " Bulgaria"
                package_price = 45000
                country_room_price = 1500
            Case " Poland"
                package_price = 46000
                country_room_price = 1200
            Case " Monaco"
                package_price = 51000
                country_room_price = 1600
            Case Else
                package_price = 55000
                country_room_price = 2100

        End Select

        total_pack_price = package_price * n_tourist 'total package price with out additional service
        total_car_price = n_car * car_day * 2000 ' car price for this group 
        total_room_price = n_room * room_day * country_room_price ' room price for this group

        total_price = (total_pack_price) + (total_car_price) + (total_room_price) ' total price for this group

        ' show base book_txt info
        Dim book_txt As String = $"{country} package for {n_tourist:n0} people" & vbNewLine & $"cost {total_pack_price:n0}" & vbNewLine & vbNewLine

        ' display book_txt due to case (car_rent and accommodation)
        Select Case rent_car & "," & rent_room

            Case "Y,Y"
                book_txt += $"{n_car} car for {car_day} day" & vbNewLine & $"cost {total_car_price:n0}" & vbNewLine & vbNewLine & $"{n_room} room for {room_day} day" & vbNewLine & $"cost {total_room_price:n0}" & vbNewLine & vbNewLine
            Case "Y,N"
                book_txt += $"{n_car} car for {car_day} day" & vbNewLine & $"cost {total_car_price:n0}" & vbNewLine & vbNewLine
            Case "N,Y"
                book_txt += $"{n_room} room for {room_day} day" & vbNewLine & $"cost {total_room_price:n0}" & vbNewLine & vbNewLine
            Case "N,N"
                book_txt += "No additional services" & vbNewLine & vbNewLine

        End Select

        ' last line of book_txt
        book_txt += $"Total cost {total_price:n0}"

        ' to confirm booking
        Dim book_info As DialogResult = MessageBox.Show(book_txt, "Booking Info.", MessageBoxButtons.YesNo)

        ' action after confirm / not confirm booking
        If book_info = DialogResult.Yes Then
            total_income += total_price ' update total_income only when client purchase 
            total_pack += n_tourist ' update total_pack only when client purchase

            ' update sold for each pack
            Select Case country

                Case "Portugal"
                    tp_1 += n_tourist ' update each country pack base on choice only when client purchase
                Case "Bulgaria"
                    tp_2 += n_tourist
                Case "Poland"
                    tp_3 += n_tourist
                Case "Monaco"
                    tp_4 += n_tourist
                Case Else
                    tp_5 += n_tourist

            End Select

            Dim f2 As New Form2 ' to create f2 
            f2.total_price_f1 = total_price ' send total_price to f2

            f2.ShowDialog() ' show form2 
            Me.Show() ' show form1 after form2 close

        End If

        ResetForm() ' reset form for next booking 

    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click

        ' sum_txt for today sell
        Dim sum_txt As String = $"Total income: {total_income:n0}" & vbNewLine & $"Total package sold: {total_pack:n0}" & vbNewLine & vbNewLine & $"Sold info. for each package" & vbNewLine & "--------------------" & vbNewLine & $"Portugal: {tp_1:n0}" & vbNewLine & $"Bulgaria: {tp_2:n0}" & vbNewLine & $"Poland: {tp_3:n0}" & vbNewLine & $"Monaco: {tp_4:n0}" & vbNewLine & $"Spain: {tp_5:n0}"

        MessageBox.Show(sum_txt, "Sell Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class
