Module Module1
    Public posicion As Byte = 0
    Public placa(5) As String
    Public marcad(5) As String
    Public dias alquiler(5) As Double
    Public pago parcial(5) As Double
    Public forma de pago(5) As Double
    Public parcial(5) As Double
    Public descuento(5) As String
    Public total(5) As Double

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.TextBox6.Clear()
        Form1.TextBox7.Clear()
        Form1.TextBox8.Clear()
        Form1.ComboBox1.SelectedIndex = -1

        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.TextBox1.Focus()
    End Sub
End Module
Sub renta_autos()
    If (Form1.CheckBox1.Checked) Or (Form1.CheckBox2.Checked) Then
        If Form1.CheckBox1.Checked Then
            forma de pago(posicion) = pdesarrollo
        Else
            forma de pago(posicion) = 0
        End If
        If Form1.CheckBox2.Checked Then
            auditoria(posicion) = pauditoria
        Else
            auditoria(posicion) = 0
        End If
        parcial(posicion) = desarrollo(posicion) + auditoria(posicion)
    Else
        MsgBox("ERROR, NO SELECCIONÓ TEMA(S) DE SOFTWARE")
        Exit Sub
    End If
End Sub
Sub LIMPIAR_VECTORES()
    posicion = 0

    Form1.ListBox1.Items.Clear()
    Form1.ListBox2.Items.Clear()
    Form1.ListBox3.Items.Clear()
    Form1.ListBox4.Items.Clear()
    Form1.ListBox5.Items.Clear()
    Form1.ListBox6.Items.Clear()
    Form1.ListBox7.Items.Clear()
    Form1.ListBox8.Items.Clear()


End Sub
Sub salir()
    If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
End
Else
limpiar_entradas()
LIMPIAR_VECTORES()
End If