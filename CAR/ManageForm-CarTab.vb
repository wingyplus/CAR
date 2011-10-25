Imports CarClassLibrary
'
' สร้าง Car Tab
'
Partial Public Class ManageForm

    Private Function CheckFileExtension(ByVal PictureName As String) As Boolean
        Dim ext = System.IO.Path.GetExtension(PictureName)
        Select Case ext
            Case ".png", ".jpg", ".jpeg"
                Return True
        End Select
        Return False
    End Function

    Private Function CopyAndRenameImage(ByVal PictureName As String) As String
        Return ""
    End Function

    '
    ' Browse หารูป
    '
    Private Sub Browse_Button_Click(sender As System.Object, e As System.EventArgs) Handles Browse_Button.Click
        OpenFileDialog.Filter = "Images (*.jpeg, *.jpg, *.png)|*.jpeg;*.jpg;*.png"
        OpenFileDialog.Title = "Open Images"
        OpenFileDialog.ShowDialog()
        Path_TextBox.Text = OpenFileDialog.FileName
    End Sub

    '
    ' Save Data to Database
    '
    Private Sub CarSave_Button_Click(sender As System.Object, e As System.EventArgs) Handles CarSave_Button.Click
        If CheckFileExtension(Path_TextBox.Text) Then
            Try
                Dim car As New CarClassLibrary.Car
                Using entity As New DataCarEntities
                    car.Id = Plate_TextBox.Text
                    car.TagId = IDTag_TextBox.Text
                    car.Brand = Brand_TextBox.Text
                    car.Student_Id = StudentOwner_ComboBox.Text.Split(New Char() {" "c})(0)
                    car.Picture = CopyAndRenameImage(Path_TextBox.Text)
                    entity.Cars.AddObject(car)
                    entity.SaveChanges()
                End Using
            Catch ex As UpdateException
                MsgBox("ข้อมูลนี้มีอยู่แล้ว")
            End Try
        Else
            MsgBox("นามสกุลของรูปภาพไม่ถูกต้อง")
        End If
    End Sub
End Class
