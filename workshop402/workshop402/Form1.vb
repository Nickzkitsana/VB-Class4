Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Faculty() As String = {"คณะวิศวกรรมศาสตร์", "คณะเทคโนโลยีสารสนเทศ", "คณะบริหารธุรกิจ"}
        ComboBoxFaculty.Items.AddRange(Faculty)

    End Sub

    Private Sub ComboBoxFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFaculty.SelectedIndexChanged
        Dim Engineer() As String = {"สาขาวิชาวิศวกรรมยานยนต์ (AE)", "สาขาวิชาวิศวกรรมการผลิต (PE)", "สาขาวิชาวิศวกรรมคอมพิวเตอร์ (CE)", "สาขาวิชาวิศวกรรมอุตสาหการ (IE)", "สาขาวิชาวิศวกรรมไฟฟ้า (EE)", "สาขาวิชาเทคโนโลยีวิศวกรรม (MET)(ป.โท)"}
        Dim Information() As String = {"สาขาวิชาเทคโนโลยีสารสนเทศ (IT)", "สาขาวิชาเทคโนโลยีมัลติมิเดีย (MT)", "สาขาวิชาเทคโนโลยีสารสนเทศทางธุรกิจ (BI)", "สาขาวิชาเทคโนโลยีดิจิทัลทางสื่อสารมวลชน (DC)", "Data Science And Analytics (International Program)", "สาขาวิชาเทคโนโลยีสารสนเทศ (MIT) (ป.ตรี)"}
        Dim business() As String = {"สาขาวิชาการจัดการเทคโนโลยี และนวัตกรรมการผลิต (MI)", "สาขาวิชาบริหารธุรกิจอุตสาหกรรม (BM)", "สาขาวิชาบริหารธุรกิจญี่ปุ่น (BJ)", "สาขาวิชาการจัดการธุรกิจระหว่างประเทศ (IB)", "สาขาวิชาการบัญชี (AC)", "สาขาวิชาการจัดการทรัพยากรมนุษย์แบบญี่ปุ่น (HRJ)", "สาขาวิชาการจัดการโลจิสติกส์และโซ่อุปทาน (LM)", "สาขาวิชาการตลาดเชิงสร้างสรรค์ (CM)", "สาขาการจัดการท่องเที่ยวและการบริการเชิงนวัตกรรม (TH)", "สาขาวิชานวัตกรรมการจัดการธุรกิจและอุตสาหกรรม (MBI) (ป.ตรี)", "สาขาวิชาบริหารธุรกิจญี่ปุ่น (MBJ) (ป.ตรี)"}

        If ComboBoxFaculty.SelectedIndex = 0 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(Engineer)
        ElseIf ComboBoxFaculty.SelectedIndex = 1 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(Information)
        ElseIf ComboBoxFaculty.SelectedIndex = 2 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(business)
        End If

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        Dim confirm As DialogResult
        confirm = MessageBox.Show("ยืนยันข้อมูลหรือไม่", "ยืนยันข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then

            Dim type As String = ComboBoxFaculty.SelectedItem
            Dim subject As String = ComboBoxMajor.SelectedItem
            Dim number As String = TextBoxId.Text
            Dim name As String = TextBoxName.Text

            MessageBox.Show("เลขบัตรประชาชน : " & number & vbNewLine &
                            "ชื่อ นามสกุล : " & name & vbNewLine &
                            "คณะ : " & type & vbNewLine &
                            "สาขา : " & subject)
            TextBoxId.Text = ""
            TextBoxName.Text = ""
            ComboBoxFaculty.Items.Clear()
            Dim Faculty() As String = {"คณะวิศวกรรมศาสตร์", "คณะเทคโนโลยีสารสนเทศ", "คณะบริหารธุรกิจ"}
            ComboBoxFaculty.Items.AddRange(Faculty)
            ComboBoxMajor.Items.Clear()
            ButtonOK.Enabled = False
            ButtonReset.Enabled = False
        End If

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        TextBoxId.Text = ""
        TextBoxName.Text = ""
        ComboBoxFaculty.Items.Clear()
        Dim Faculty() As String = {"คณะวิศวกรรมศาสตร์", "คณะเทคโนโลยีสารสนเทศ", "คณะบริหารธุรกิจ"}
        ComboBoxFaculty.Items.AddRange(Faculty)
        ComboBoxMajor.Items.Clear()
        ButtonOK.Enabled = False
        ButtonReset.Enabled = False
    End Sub

    Private Sub TextBoxId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged, ComboBoxMajor.SelectedIndexChanged, TextBoxId.TextChanged, TextBoxName.TextChanged, ComboBoxFaculty.SelectedIndexChanged
        If TextBoxId.Text <> "" And TextBoxName.Text <> "" And ComboBoxFaculty.SelectedItem <> "" And ComboBoxMajor.SelectedItem <> "" Then
            ButtonOK.Enabled = True
        ElseIf TextBoxId.Text <> "" Or TextBoxName.Text <> "" Or ComboBoxFaculty.SelectedItem <> "" Or ComboBoxMajor.SelectedItem <> "" Then
            ButtonReset.Enabled = True
        Else
            ButtonOK.Enabled = False
            ButtonReset.Enabled = False
        End If
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub ComboBoxMajor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMajor.SelectedIndexChanged

    End Sub
End Class
