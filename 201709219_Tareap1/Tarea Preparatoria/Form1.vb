Public Class Form1
    Private Sub HiloCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles HiloCrudo.CheckedChanged
        If HiloCrudo.Checked = True Then
            txtHilo.Enabled = True
            txtHilo.Text = 0
        Else
            txtHilo.Enabled = False
            txtHilo.Text = "0"
        End If
    End Sub
    Private Sub Seda_CheckedChanged(sender As Object, e As EventArgs) Handles Seda.CheckedChanged
        If Seda.Checked = True Then
            txtseda.Enabled = True
            txtseda.Text = "0"
        Else
            txtseda.Enabled = False
            txtseda.Text = "0"

        End If
    End Sub
    Private Sub Algodon_CheckedChanged(sender As Object, e As EventArgs) Handles Algodon.CheckedChanged
        If Algodon.Checked = True Then
            txtAlgodon.Enabled = True
            txtAlgodon.Text = "0"
        Else
            txtAlgodon.Enabled = False
            txtAlgodon.Text = "0"

        End If
    End Sub
    Private Sub Lino_CheckedChanged(sender As Object, e As EventArgs) Handles Lino.CheckedChanged
        If Lino.Checked = True Then
            txtLino.Enabled = True
            txtAlgodon.Text = "0"
        Else
            txtLino.Enabled = False
            txtLino.Text = "0"

        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Lblpreciocosto.Text = "0.00"
        sumaYardas = Val(txtAlgodon.Text) + Val(txtHilo.Text) + Val(txtLino.Text) + Val(txtseda.Text)
        If King.Checked = True Then
            If sumaYardas = matKing Then
                preciocosto = precioking + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtseda.Text) * precioSeda
            Else MsgBox"faltan o sobran mateiales"
            End If
        ElseIf Queen.Checked = True Then
            If sumaYardas = matQuen Then

                preciocosto = precioQueen + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtseda.Text) * precioSeda
            Else MsgBox"faltan o sobran mateiales"
            End If
        ElseIf Matrimonial.Checked = True Then
            If sumaYardas = natMat Then
                preciocosto = precioMatr + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtseda.Text) * precioSeda
            Else MsgBox"faltan o sobran mateiales"
            End If
        ElseIf Imperial.cheked = True Then
            If sumaYardas = matInp Then
                preciocosto = precioImp + Val(txtAlgodon.Text) * precioAlgodon + Val(txtHilo.Text) * precioHilo + Val(txtLino.Text) * precioLino + Val(txtseda.Text) * precioSeda
            Else MsgBox"faltan o sobran mateiales"
            End If
        End If
        lbPrecioCosto.Text = Str(preciocosto)
        Aceptar.Visible = True
    End Sub