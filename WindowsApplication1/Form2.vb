Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' процедура выводящая 2 вкладки информации и проверяющая на целостность переноса данных 

        TextBox1.Multiline = True

        Try
            FileOpen(1, "logic.txt", OpenMode.Input)
            Do While Not EOF(1)
                TextBox1.Text &= (LineInput(1)) & vbCrLf
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox("Ошибка чтения файла")
        End Try
        TextBox2.Multiline = True

        Try
            FileOpen(1, "about.txt", OpenMode.Input)
            Do While Not EOF(1)
                TextBox2.Text &= (LineInput(1)) & vbCrLf
            Loop
            FileClose(1)
        Catch ex As Exception
            MsgBox("Ошибка чтения файла")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show() 'процедура открывающая "Обучающую подформу " "and"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show() 'процедура открывающая "Обучающую подформу " "or"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show() 'процедура открывающая "Обучающую подформу " "xor"
    End Sub




End Class