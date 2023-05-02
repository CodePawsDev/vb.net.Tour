Public Class Form2
    Public Property total_price_f1 As Integer

    ' when form2 loaded, the content show
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l_total_show.Text = $"{total_price_f1:n0}"
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Dim paid As Integer
        Dim change As Integer

        paid = Integer.Parse(tb_paid.Text)

        ' check payment 
        If paid < total_price_f1 Then
            Dim error_paid_txt As String = $"Please pay at least {total_price_f1:n0} THB."
            MessageBox.Show(error_paid_txt, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tb_paid.Clear()
            tb_paid.Focus()
            Return
        End If

        tb_paid.Text = paid ' update show payment if user does not fully paid at first

        change = paid - total_price_f1
        l_change_show.Text = $"{change:n0}"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show("Order has been successfully place", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub
End Class