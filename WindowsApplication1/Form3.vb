Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Multiline = True ' процедура вывода файла "обучения" проверяющая на целостность переноса данных 

        Try
            FileOpen(1, "and.txt", OpenMode.Input)
            Do While Not EOF(1)
                TextBox1.Text &= (LineInput(1)) & vbCrLf
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox("Ошибка чтения файла")
        End Try
    End Sub
End Class