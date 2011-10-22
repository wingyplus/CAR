Public Class ManageForm

    Private Sub Index_Button_Click(sender As System.Object, e As System.EventArgs) Handles Index_Button.Click
        Me.Hide()
        IndexForm.Show()
    End Sub

    Private Sub Reset_Button_Click(sender As System.Object, e As System.EventArgs) Handles Reset_Button.Click
        ClearForm()
    End Sub

    Private Sub Submit_Button_Click(sender As System.Object, e As System.EventArgs) Handles Submit_Button.Click

    End Sub

    Private Sub ClearForm()
        IDTag_TextBox.Text = ""
        IDName_TextBox.Text = ""
        FName_TextBox.Text = ""
        LName_TextBox.Text = ""
        Dorm_TextBox.Text = ""
        Ins_ComboBox.Text = ""
        Phone_TextBox.Text = ""
        Brand_TextBox.Text = ""
        Plate_TextBox.Text = ""
    End Sub


End Class