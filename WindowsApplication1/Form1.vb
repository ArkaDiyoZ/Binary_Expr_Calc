
Public Class Form1

    Dim tb(7) As TextBox ' массив Textbox(ов) для создания первого выражения
    Dim tb2(7) As TextBox ' массив Textbox(ов) для создания первого выражения
    Dim first(7) As CheckBox 'массив Checkbox(ов) для создания выражения 
    Dim second(7) As CheckBox 'массив Checkbox(ов) для создания выражения 
    Dim result(7) As TextBox 'массив для вывода результата 

    Function MakeArray(n, a, b) As Integer() 'подпрограмма для создания массива случайных значений выражения 
        Randomize()

        Dim arr(n) As Integer

        For i = 0 To UBound(arr)
            arr(i) = a + Int((b - a + 1) * Rnd())
        Next
        Return arr

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb(0) = TextBox1 ' присваивание каждому элементу свое окно вывода
        tb(1) = TextBox2
        tb(2) = TextBox3
        tb(3) = TextBox4
        tb(4) = TextBox5
        tb(5) = TextBox6
        tb(6) = TextBox7
        tb(7) = TextBox8
        tb2(0) = TextBox9
        tb2(1) = TextBox10
        tb2(2) = TextBox11
        tb2(3) = TextBox12
        tb2(4) = TextBox13
        tb2(5) = TextBox14
        tb2(6) = TextBox15
        tb2(7) = TextBox16
        For i = 0 To UBound(tb) 'цикл заполнения дефолтными значениями первого выражения 
            tb(i).Text = "0"
        Next
        For i = 0 To UBound(tb2) 'цикл заполнения дефолтными значениями второго выражения 
            tb2(i).Text = "0"
        Next
        first(0) = CheckBox1 ' присваиивание каждому элементу свой блок выбора(первого выражения)
        first(1) = CheckBox2
        first(2) = CheckBox3
        first(3) = CheckBox4
        first(4) = CheckBox5
        first(5) = CheckBox6
        first(6) = CheckBox7
        first(7) = CheckBox8


        second(0) = CheckBox9 ' присваиивание каждому элементу свой блок выбора (второго выражения )
        second(1) = CheckBox10
        second(2) = CheckBox11
        second(3) = CheckBox12
        second(4) = CheckBox13
        second(5) = CheckBox14
        second(6) = CheckBox15
        second(7) = CheckBox16


        result(0) = TextBox17 ' присваивание элементам блок вывода результата
        result(1) = TextBox18
        result(2) = TextBox19
        result(3) = TextBox20
        result(4) = TextBox21
        result(5) = TextBox22
        result(6) = TextBox23
        result(7) = TextBox24







    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged 'с помощью этой части кода реализован выбор значений при создании выражения 

        If CheckBox1.Checked = True Then
            TextBox1.Text = "1"
        ElseIf CheckBox1.Checked = False Then
            TextBox1.Text = "0"
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            TextBox2.Text = "1"
        ElseIf CheckBox2.Checked = False Then
            TextBox2.Text = "0"
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            TextBox3.Text = "1"
        ElseIf CheckBox3.Checked = False Then
            TextBox3.Text = "0"
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            TextBox4.Text = "1"
        ElseIf CheckBox4.Checked = False Then
            TextBox4.Text = "0"
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox5.Checked = True Then
            TextBox5.Text = "1"
        ElseIf CheckBox5.Checked = False Then
            TextBox5.Text = "0"
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

        If CheckBox6.Checked = True Then
            TextBox6.Text = "1"
        ElseIf CheckBox6.Checked = False Then
            TextBox6.Text = "0"
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged

        If CheckBox7.Checked = True Then
            TextBox7.Text = "1"
        ElseIf CheckBox7.Checked = False Then
            TextBox7.Text = "0"
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged

        If CheckBox8.Checked = True Then
            TextBox8.Text = "1"
        ElseIf CheckBox8.Checked = False Then
            TextBox8.Text = "0"
        End If
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            TextBox9.Text = "1"
        ElseIf CheckBox9.Checked = False Then
            TextBox9.Text = "0"
        End If
    End Sub
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            TextBox10.Text = "1"
        ElseIf CheckBox10.Checked = False Then
            TextBox10.Text = "0"
        End If
    End Sub
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            TextBox11.Text = "1"
        ElseIf CheckBox11.Checked = False Then
            TextBox11.Text = "0"
        End If
    End Sub
    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            TextBox12.Text = "1"
        ElseIf CheckBox12.Checked = False Then
            TextBox12.Text = "0"
        End If
    End Sub
    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            TextBox13.Text = "1"
        ElseIf CheckBox13.Checked = False Then
            TextBox13.Text = "0"
        End If
    End Sub
    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            TextBox14.Text = "1"
        ElseIf CheckBox14.Checked = False Then
            TextBox14.Text = "0"
        End If
    End Sub
    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            TextBox15.Text = "1"
        ElseIf CheckBox15.Checked = False Then
            TextBox15.Text = "0"
        End If
    End Sub
    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            TextBox16.Text = "1"
        ElseIf CheckBox16.Checked = False Then
            TextBox16.Text = "0"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) ' процедура создания массива случайных значений первого выражения
        Dim n, m As Integer
        n = 0
        m = 1

        Dim d() As Integer = MakeArray(7, n, m)
        For i = 0 To UBound(d)
            TextBox18.Text = TextBox18.Text & d(i) & " " & vbCrLf

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click  'процедура выполнения логической операции and


        For i = 0 To UBound(first)

            If first(i).Checked And second(i).Checked Then
                result(i).Text = "1"
            Else
                result(i).Text = "0"
            End If

        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click  'процедура выполнения логической операции or
        For i = 0 To UBound(first)
            If first(i).Checked And second(i).Checked Then
                result(i).Text = "1"
            ElseIf Not first(i).Checked And Not second(i).Checked Then
                result(i).Text = "0"
            Else
                result(i).Text = "1"
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'процедура выполнения логической операции xor
        For i = 0 To UBound(first)
            If first(i).Checked And Not second(i).Checked Then
                result(i).Text = "1"
            ElseIf Not first(i).Checked And second(i).Checked Then
                result(i).Text = "1"
            Else
                result(i).Text = "0"
            End If


        Next
    End Sub
    Sub ran(a() As TextBox, b() As CheckBox)
        Randomize() ' процедура генерирующая случайное значение выражения и преобразующая его в нужный нам вид 
        Dim r As Integer = 0 + Int((255 - 0 + 1) * Rnd())
        For i = 0 To 7
            If r Mod 2 = 1 Then
                b(i).Checked = True
            Else
                b(i).Checked = False
            End If
            r = r \ 2

        Next


    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click ' прцедура заполения первого выражения случайными значениями 
        ran(tb, first)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click ' прцедура заполения второго выражения случайными значениями 
        ran(tb2, second)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click ' процедура открытия "обучающей "формы(справки)
        Form2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click 'процедура выхода из программы
        End

    End Sub
End Class
