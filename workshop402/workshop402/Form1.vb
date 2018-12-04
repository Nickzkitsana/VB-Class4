Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Faculty() As String = {"คณะวิศวกรรมศาสตร์", "คณะเทคโนโลยีสารสนเทศ", "คณะบริหารธุรกิจ"}
        ComboBoxFaculty.Items.Add(Faculty)
    End Sub

    Private Sub ComboBoxFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFaculty.SelectedIndexChanged
        Dim EN() As String = {"สาขาวิศวกรรมยานยนต์", "สาขาวิศวกรรมการผลิต", "สาขาวิศวกรรมคอมพิวเตอร์", "สาขาวิศวกรรมไฟฟ้า"}
        Dim IT() As String = {"สาขาเทคโนโลยีสารสนเทศ", "สาขาเทคโนโลยีมัลติมิเดีย", "สาขาเทคโนโลยีสารสนเทศทางธุรกิจ"}
        Dim BA() As String = {"สาขาบริหารธุรกิจญี่ปุ่น", "สาขาการจัดการอุตสาหกรรม", "สาขาการบัญชี", "สาขาการจัดการทรัพยากรมนุษย์"}

        If ComboBoxFaculty.SelectedIndex = 0 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(EN)
        ElseIf ComboBoxFaculty.SelectedIndex = 1 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(IT)
        ElseIf ComboBoxFaculty.SelectedIndex = 2 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(BA)
        End If

    End Sub
End Class
