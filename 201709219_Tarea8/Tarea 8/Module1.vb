Module Module1
    Public playeras(5, 6) As String
    Public pequenias As Integer
    Public medianas As Integer
    Public grandes As Integer

    Public pagototal As Double

    Public fila As Byte = 0

    Sub limpiar_matriz()


        Dim i As Byte, j As Byte

        For i = 0 To 4
            For j = 0 To 5
                playeras(i, j) = Nothing
            Next j
        Next i


        Form1.DataGridView1.Rows.Clear()

        fila = 0


    End Sub


    Sub limpiar_entradas()

        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False

        Form1.ComboBox1.Text = ""

        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False

    End Sub
    Sub limpiar_estadisticas()

        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()

    End Sub
    Sub Mostrar()
        Dim i As Byte

        For i = 0 To 4

            If playeras(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(playeras(i, 0), playeras(i, 1), playeras(i, 2), playeras(i, 3), playeras(i, 4), playeras(i, 5))
            Else

                Exit For
            End If
        Next i
    End Sub
    Sub Salir()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If

    End Sub

End Module
