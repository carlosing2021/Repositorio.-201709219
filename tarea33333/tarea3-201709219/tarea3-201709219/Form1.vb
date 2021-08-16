Public Class calcular
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then

            tiposelecccionado = True

        ElseIf RadioButton2.Checked = True Then

            tiposeleccionado = True
        ElseIf RadioButton3.Checked = True Then

            tiposeleccionado = True
        End If

        If tiposeleccionado = True Then
            If CheckBox1.cheked = True Then
                montoCp.Enabled = True
            ElseIf CheckBox2.Checked = True Then
                montoCOB.Enabled = True
            ElseIf CheckBox3.Checked = True Then
                montoEF.Enabled = True
            End If

            If CheckBox1.Checked = False Then
                montoCp.Enabled = False
            ElseIf CheckBox2.Checked = False Then
                montoCOB.Enabled = False
            ElseIf CheckBox3.Checked = False Then
                montoEF.Enabled = False
            End If

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        MessageBox.Show("You are in the CheckBox.CheckedChanged event.");
End Sub
End Class
