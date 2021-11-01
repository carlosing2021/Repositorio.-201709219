Module Module1
    Imports System.Math
    Module Module1
        Public INDICE As Byte = 0

        Public NumeroEtapa(12) As Integer
        Public Equipo(12) As String
        Public KmsRecorridos(12) As Integer
        Public TiempoMinutos(12) As Integer
        Public Nacionalidad(12) As String
        Public Penalización(12) As Integer
        Public Reduccion(12) As Integer
        Public TotalMinutos(12) As Integer
        Sub LimpiarInfo()
            Form1.TextBox1.Clear()
            Form1.TextBox2.Clear()
            Form1.TextBox3.Clear()
            Form1.ComboBox1.Text = ""
            Form1.RadioButton1.Checked = 0
            Form1.RadioButton2.Checked = 0
            Form1.TextBox1.Focus()
        End Sub
        Sub LimpiarEstadisticas()
            Form1.TextBox4.Clear()
            Form1.TextBox5.Clear()
            Form1.TextBox6.Clear()
            Form1.TextBox7.Clear()
            Form1.TextBox8.Clear()
            Form1.TextBox9.Clear()
            Form1.TextBox10.Clear()
            Form1.TextBox11.Clear()
            Form1.TextBox12.Clear()
            Form1.TextBox13.Clear()
            Form1.TextBox15.Clear()
            Form1.TextBox16.Clear()
            Form1.TextBox17.Clear()
        End Sub

        Sub LimpiarVectores()
            Form1.DataGridView1.Rows.Clear()

            For INDICE = 0 To 11
                NumeroEtapa(INDICE) = Nothing
                Equipo(INDICE) = Nothing
                KmsRecorridos(INDICE) = Nothing
                TiempoMinutos(INDICE) = Nothing
                Nacionalidad(INDICE) = Nothing
                Penalización(INDICE) = Nothing
                Reduccion(INDICE) = Nothing
                TotalMinutos(INDICE) = Nothing
            Next INDICE
        End Sub

        Sub MostrarDatosVectores()

            Form1.DataGridView1.Rows.Clear()
            For INDICE = 0 To 11

                If (NumeroEtapa(INDICE) <> Nothing) Then
                    Form1.DataGridView1.Rows.Add(NumeroEtapa(INDICE), Equipo(INDICE), KmsRecorridos(INDICE), TiempoMinutos(INDICE), Nacionalidad(INDICE), Penalización(INDICE), Reduccion(INDICE), TotalMinutos(INDICE))
                Else
                    Exit For
                End If
            Next INDICE
        End Sub

        Sub MostrarEstadisticas()

            Dim E1 As Integer = 0
            Dim E2 As Integer = 0
            Dim E3 As Integer = 0
            Dim E4 As Integer = 0
            Dim E5 As Integer = 0
            Dim HoraSky As Integer = 0
            Dim HoraMovistar As Integer = 0
            Dim HoraProcycling As Integer = 0
            Dim HoraProteam As Integer = 0
            Dim E6 As Double = 0
            Dim E61 As Double = 0
            Dim E7 As Double = 0
            Dim E71 As Double = 0
            Dim E8 As Double = 0
            Dim E81 As Double = 0
            Dim E9 As Double = 0
            Dim E91 As Double = 0


            For INDICE = 0 To 11
                If (NumeroEtapa(INDICE) <> Nothing) Then
                    If KmsRecorridos(INDICE) > 45 Then
                        E1 = E1 + 1
                    End If
                    Select Case Equipo(INDICE) <> Nothing
                        Case Equipo(INDICE) = "Sky"
                            E2 = E2 + Val(KmsRecorridos(INDICE))
                        Case Equipo(INDICE) = "Movistar"
                            E3 = E3 + Val(KmsRecorridos(INDICE))
                        Case Equipo(INDICE) = "Pro Cycling"
                            E4 = E4 + Val(KmsRecorridos(INDICE))
                        Case Equipo(INDICE) = "Pro Team"
                            E5 = E5 + Val(KmsRecorridos(INDICE))
                    End Select
                    If Equipo(INDICE) = "Sky" Then
                        HoraSky = HoraSky + Val(TotalMinutos(INDICE))
                        E6 = Int(HoraSky / 60)
                        E61 = ((HoraSky / 60) - E6) * 60
                    ElseIf Equipo(INDICE) = "Movistar" Then
                        HoraMovistar = HoraMovistar + Val(TotalMinutos(INDICE))
                        E7 = Int(HoraMovistar / 60)
                        E71 = ((HoraMovistar / 60) - E7) * 60
                    ElseIf Equipo(INDICE) = "Pro Cycling" Then
                        HoraProcycling = HoraProcycling + Val(TotalMinutos(INDICE))
                        E8 = Int(HoraProcycling / 60)
                        E81 = ((HoraProcycling / 60) - E8) * 60
                    ElseIf Equipo(INDICE) = "Pro Team" Then
                        HoraProteam = HoraProteam + Val(TotalMinutos(INDICE))
                        E9 = Int(HoraProteam / 60)
                        E91 = ((HoraProteam / 60) - E9) * 60
                    End If
                Else
                    Exit For
                End If
            Next INDICE

            Form1.TextBox4.Text = Str(E1)
            Form1.TextBox5.Text = Str(E2)
            Form1.TextBox6.Text = Str(E3)
            Form1.TextBox7.Text = Str(E4)
            Form1.TextBox8.Text = Str(E5)
            Form1.TextBox9.Text = Str(Val(E6))
            Form1.TextBox13.Text = Str(Round(Val(E61), 2))
            Form1.TextBox10.Text = Str(Val(E7))
            Form1.TextBox15.Text = Str(Round(Val(E71), 2))
            Form1.TextBox11.Text = Str(Val(E8))
            Form1.TextBox16.Text = Str(Round(Val(E81), 2))
            Form1.TextBox12.Text = Str(Val(E9))
            Form1.TextBox17.Text = Str(Round(Val(E91), 2))

        End Sub

        Public Function VerificarRepetido() As Boolean
            Dim encontrado As Boolean = True
            INDICE = 0
            VerificarRepetido = True

            While (INDICE <= 11) And (encontrado)

                If (NumeroEtapa(INDICE) <> Nothing) Then

                    If (NumeroEtapa(INDICE) = Val(Form1.TextBox14.Text)) Then
                        VerificarRepetido = encontrado = False
                        Return VerificarRepetido
                    Else
                        INDICE = INDICE + 1
                    End If
                Else
                    Exit While
                End If
            End While
            If (encontrado) Then
                Return VerificarRepetido
            End If
        End Function
    End Module

End Module
