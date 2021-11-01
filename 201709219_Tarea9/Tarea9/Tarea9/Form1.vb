Public Class Form1
    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarInfo()
            LimpiarEstadisticas()
            LimpiarVectores()
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        LimpiarEstadisticas()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MostrarDatosVectores()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim existe As Boolean = True
        INDICE = 0
        While (INDICE <= 11) And (existe)
            If (NumeroEtapa(INDICE) <> Nothing) Then
                If (NumeroEtapa(INDICE) = Str(TextBox14.Text)) Then
                    existe = False
                Else
                    INDICE = INDICE + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("Número de etapa no encontrado")
            TextBox8.Focus()
        Else
            MsgBox("Numero de etapa encontrado exitosamente")

            TextBox1.Text = NumeroEtapa(INDICE)
            ComboBox1.Text = Equipo(INDICE)
            TextBox2.Text = KmsRecorridos(INDICE)
            TextBox3.Text = TiempoMinutos(INDICE)

            If Nacionalidad(INDICE) = "Guatemalteco" Then
                RadioButton1.Checked = True
            ElseIf Nacionalidad(INDICE) = "Extranjero" Then
                RadioButton2.Checked = True
            End If

            TextBox14.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(NumeroEtapa(INDICE), Equipo(INDICE), KmsRecorridos(INDICE), TiempoMinutos(INDICE), Nacionalidad(INDICE), Penalización(INDICE), Reduccion(INDICE), TotalMinutos(INDICE))
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim FILA As Byte

        NumeroEtapa(FILA) = Nothing
        Equipo(FILA) = Nothing
        KmsRecorridos(FILA) = Nothing
        TiempoMinutos(FILA) = Nothing
        Nacionalidad(FILA) = Nothing
        Penalización(FILA) = Nothing
        Reduccion(FILA) = Nothing
        TotalMinutos(FILA) = Nothing

        For INDICE = FILA To 10
            NumeroEtapa(INDICE) = NumeroEtapa(INDICE + 1)
            Equipo(INDICE) = Equipo(INDICE + 1)
            KmsRecorridos(INDICE) = KmsRecorridos(INDICE + 1)
            TiempoMinutos(INDICE) = TiempoMinutos(INDICE + 1)
            Nacionalidad(INDICE) = Nacionalidad(INDICE + 1)
            Penalización(INDICE) = Penalización(INDICE + 1)
            Reduccion(INDICE) = Reduccion(INDICE + 1)
            TotalMinutos(INDICE) = TotalMinutos(INDICE + 1)
        Next INDICE
        MsgBox("Registro eliminado exitosamente")

        NumeroEtapa(INDICE) = Nothing
        Equipo(INDICE) = Nothing
        KmsRecorridos(INDICE) = Nothing
        TiempoMinutos(INDICE) = Nothing
        Nacionalidad(INDICE) = Nothing
        Penalización(INDICE) = Nothing
        Reduccion(INDICE) = Nothing
        TotalMinutos(INDICE) = Nothing

        INDICE = FILA
        LimpiarInfo()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If VerificarRepetido() Then
        Else
            MsgBox("Número de etapa repetido, debe ingresar uno diferente")
        End If

        If (INDICE < 12) Then
            NumeroEtapa(INDICE) = Str(Val(TextBox1.Text))
            Equipo(INDICE) = ComboBox1.SelectedItem
            KmsRecorridos(INDICE) = Str(Val(TextBox2.Text))
            TiempoMinutos(INDICE) = Str(Val(TextBox3.Text))
        End If

        If RadioButton1.Checked Then
            Nacionalidad(INDICE) = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            Nacionalidad(INDICE) = RadioButton2.Text
        End If

        If Val(TiempoMinutos(INDICE)) > 120 Then
            Penalización(INDICE) = 30
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 140 Then
            Penalización(INDICE) = 40
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 160 Then
            Penalización(INDICE) = 50
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Movistar" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 15
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Pro Team" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 10
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        Else
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        End If

        INDICE = INDICE + 1
        LimpiarInfo()
        If (INDICE = 11) Then
            MsgBox("MATRIZ LLENA", vbExclamation, "IMPORTANTE")
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If VerificarRepetido() Then
        Else
            MsgBox("Número de etapa repetido, debe ingresar uno diferente")
        End If

        NumeroEtapa(INDICE) = Str(Val(TextBox1.Text))
        Equipo(INDICE) = ComboBox1.SelectedItem
        KmsRecorridos(INDICE) = Str(Val(TextBox2.Text))
        TiempoMinutos(INDICE) = Str(Val(TextBox3.Text))

        If RadioButton1.Checked Then
            Nacionalidad(INDICE) = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            Nacionalidad(INDICE) = RadioButton2.Text
        End If

        If Val(TiempoMinutos(INDICE)) > 120 Then
            Penalización(INDICE) = 30
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 140 Then
            Penalización(INDICE) = 40
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) > 160 Then
            Penalización(INDICE) = 50
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Movistar" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 15
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        ElseIf Val(TiempoMinutos(INDICE)) < 85 And Equipo(INDICE) = "Pro Team" Then
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 10
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        Else
            Penalización(INDICE) = 0
            Reduccion(INDICE) = 0
            TotalMinutos(INDICE) = Str(Val(TiempoMinutos(INDICE)) + Val(Penalización(INDICE)) - Val(Reduccion(INDICE)))
        End If

        MsgBox("Numero de etapa actualizado correctamente en los vectores", vbExclamation, "IMPORTANTE")
        INDICE = 12
    End Sub
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        MostrarEstadisticas()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        LimpiarInfo()
    End Sub
End Class
