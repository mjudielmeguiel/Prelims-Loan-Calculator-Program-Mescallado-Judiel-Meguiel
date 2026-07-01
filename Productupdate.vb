Public Class Productupdate
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim S As New Shop()

        S.lblProductname.Text = txtupdateproductname.Text
        S.btnProduct1.Text = txtupdateprice.Text
        S.picproduct1.Image = picUpdate.Image
        MsgBox("Product Updated Successfully!", MsgBoxStyle.Information, "Update Successful")
        Me.Hide()

        Home.Panel2.Controls.Clear()
        S.TopLevel = False
        S.FormBorderStyle = FormBorderStyle.None
        S.Dock = DockStyle.Fill
        Home.Panel2.Controls.Add(S)
        S.Show()
    End Sub

    Private Sub picProduct_DoubleClick(sender As Object, e As EventArgs) Handles picUpdate.DoubleClick
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Choose Image"

            If ofd.ShowDialog() = DialogResult.OK Then

                Using stream As New IO.FileStream(ofd.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                    picUpdate.Image = Image.FromStream(stream)
                End Using
                picUpdate.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using
    End Sub
End Class