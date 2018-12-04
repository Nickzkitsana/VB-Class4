Public Class Form1
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim price As Double = 399 * CInt(TextBoxCustomer.Text)

        Dim member As DialogResult

        member = MessageBox.Show("ลูกค้ามีบัตรสมาชิกหรือไม่", "Member Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If member = DialogResult.Yes Then
            price = price - (price * 10) / 100
        End If
        MessageBox.Show("ราคารวม " & price & " บาท")

    End Sub
End Class
