Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub ProcesosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesosToolStripMenuItem.Click
        Dim car As Double = 0

        If (posicion <= 4) Then
            If (TextBox1.Text <> "") And (TextBox2.Text <> "") Then
                participante(posicion) = TextBox1.Text + " " + TextBox2.Text

            Else
                MsgBox("ERROR, NIT,PLACA,MARCA,dia de alquiler")
                TextBox1.Focus()
                Exit Sub
            End If
            If (ComboBox1.SelectedIndex > -1) Then
                conferencia(posicion) = ComboBox1.Text
            Else
                MsgBox("ERROR, NO SELECCIONO FORMA DE PAGO")
                ComboBox1.Focus()
                Exit Sub
            End If

            descuento(posicion) = calculardescuentorecargo()

            total(posicion) = totalfinal()
            muestre_totales()
            posicion = posicion + 1
        End If
        If posicion = 5 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()
        End If
    End Sub
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub LimpirarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpirarVectoresToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
