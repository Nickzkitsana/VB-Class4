Public Class Form1
    Private Sub LisBoxMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LisBoxMenu.SelectedIndexChanged

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim menu As String = LisBoxMenu.SelectedItem
        LisBoxOrder.Items.Add(menu)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Menu() As String = {"ข้าวกระเพราหมู", "ข้าวกระเพราไก่", "ข้าวกระเพราเนื้อ", "ข้าวกระเพราทะเล", "ข้าวกระเพรามังสวิรัติ", "ข้าวกระเพราเจ", "น้ำเปล่า", "น้ำผลไม้รวม", "น้ำชา"}
        LisBoxOrder.Items.Clear()
        LisBoxMenu.Items.Clear()
        LisBoxMenu.Items.AddRange(Menu)
    End Sub

    Private Sub LisBoxOrder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LisBoxOrder.SelectedIndexChanged

    End Sub

    Private Sub ButtonOut_Click(sender As Object, e As EventArgs) Handles ButtonOut.Click
        Dim menudelete As String = LisBoxOrder.SelectedItem
        LisBoxOrder.Items.Remove(menudelete)
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        Dim message As String = ""
        For Each items In LisBoxOrder.SelectedItems
            message &= items & vbNewLine
        Next


        Dim Confirm As DialogResult
        Confirm = MessageBox.Show("ยืนยันการสั่งอาหารหรือไม่", "ยืนยันรายการ", MessageBoxButtons.YesNo)
        If Confirm = DialogResult.Yes Then
            MessageBox.Show("รายการอาหารของคุณ" & vbNewLine & message, "รายการอาหาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LisBoxOrder.Items.Clear()
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        LisBoxOrder.Items.Clear()
    End Sub
End Class
