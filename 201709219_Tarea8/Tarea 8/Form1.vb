Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pagototal = 0

        If (fila <= 4) Then
            If (CheckBox1.Checked) Or (CheckBox2.Checked) Or (CheckBox3.Checked) Then

                If (CheckBox1.Checked) Then
                    playeras(fila, 0) = Str(Round(pequenias * 95.5, 2))
                Else
                    playeras(fila, 0) = "0"
                End If
                If (CheckBox2.Checked) Then
                    playeras(fila, 1) = Str(Round(medianas * 115.25, 2))
                Else
                    playeras(fila, 1) = "0"
                End If
                If (CheckBox3.Checked) Then
                    playeras(fila, 2) = Str(Round(grandes * 150.99, 2))
                Else
                    playeras(fila, 2) = "0"
                End If
            Else
                MsgBox("Error, no seleccionó ninguna talla de playera")
                Exit Sub
            End If
            playeras(fila, 3) = ComboBox1.Text
            If (RadioButton1.Checked) Then
                playeras(fila, 4) = RadioButton1.Text
            ElseIf (RadioButton2.Checked) Then
                playeras(fila, 4) = RadioButton2.Text
            ElseIf (RadioButton3.Checked) Then
                playeras(fila, 4) = RadioButton3.Text
            Else
                MsgBox("Error, no seleccionó marca")
                Exit Sub
            End If

            playeras(fila, 5) = Str(Val(playeras(fila, 0)) + Val(playeras(fila, 1)) + Val(playeras(fila, 2)))
            fila = fila + 1
        End If
        If (fila = 5) Then
            MsgBox("Matriz llena")
        End If
        limpiar_entradas()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mostrar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar_entradas()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        limpiar_matriz()
    End Sub
End Class
