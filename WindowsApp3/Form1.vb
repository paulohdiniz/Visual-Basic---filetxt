Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FILE_NAME As String = "C:\Users\phdin\Documents\text.txt"

        Dim TextLine As String

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1

                TextLine = TextLine & objReader.ReadLine() & vbNewLine

            Loop

            TextBox1.Text = TextLine

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FILE_NAME As String = "C:\Users\phdin\Documents\novo.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)

            objWriter.Write(TextBox2.Text)
            objWriter.Close()
            MessageBox.Show("Text written to file")

        Else

            MessageBox.Show("File Does Not Exist")

        End If
    End Sub
End Class
