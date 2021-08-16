Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton3.cheked = True Then
            Select Case saldo_nuevo
                Case 1.01 To 1000.99
                    interes = 1.5 / 100
                Case 1001 To 5000.99
                    interes = 2.5 / 100
                Case 5001 To 15000.99
                    interes = 7.5 / 100
                Case Is >= 15001
                    interes = 10 / 100
            End Select
            saldo_nuevo = Val(montoCp.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoanterior.Text)
            saldo_nuevo = saldo_nuevo + saldo_nuevo * interes
            saldo_nuevo.Text = Str(saldo_nuevo)
        End If

        If RadioButton2.Checked = True Then
            Select Case Val(saldoanterior.Text)
                Case 1.01 To 10000.99
                    interes = 2.5 / 100
                Case 10001 To 15000.99
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100
            End Select
            saldo_nuevo = Val(montoCp.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoanterior.Text) + interes
        End If
        If RadioButton1.Checked = True Then
            saldo_nuevo = Val(montoCp.Text) + Val(montoCOB.Text) + Val(montoEF.Text) + Val(saldoanterior.Text) + interes

        End If
        txtinteres.Text = Str(interes * 100) + "%"


    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If RadioButton1.Checked = True Then
            tiposeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tiposeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tiposeleccionado = True
        End If

        If tiposeleccionado = True Then
            If CheckBox1.Checked = True Then
                montoCp.Enabled = True
            End If

            If CheckBox1.Checked = False Then
                montoCp.Enabled = False
            End If
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If RadioButton1.Checked = True Then
            tiposeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tiposeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tiposeleccionado = True
        End If

        If tiposeleccionado = True Then
            If CheckBox2.Checked = True Then
                montoCOB.Enabled = True
            End If

            If CheckBox2.Checked = False Then
                montoCOB.Enabled = False
            End If
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If RadioButton1.Checked = True Then
            tiposeleccionado = True
        ElseIf RadioButton2.Checked = True Then
            tiposeleccionado = True
        ElseIf RadioButton3.Checked = True Then
            tiposeleccionado = True
        End If

        If tiposeleccionado = True Then
            If CheckBox3.Checked = True Then
                montoEF.Enabled = True
            End If

            If CheckBox3.Checked = False Then
                montoEF.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        montoCp.Text = ""
        montoCOB.Text = ""
        montoEF.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
        MessageBox.Show("Desea cerrar este aplicación")
    End Sub