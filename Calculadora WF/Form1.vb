Public Class FrmCalc

    Private bFinDeOperacion As Boolean = False
    Private bPrimeraPresion As Boolean = True
    Private sPenultimoOperador As String = ""
    Private sFiltro As String = "abcdefghijklmnopqrstuvwxyz<>,:;'[]{}|~!@#$%^&*()?¡²³¤€¼½¾‘’¥×`'QWERTYUIOPASDFGHJKLZXCVBNM"
    Private cProcesador As Procesador = New Procesador()

    Private Sub FrmCalc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If sFiltro.Contains(e.KeyChar) Then
            Return
        End If

        Procesar(e)
    End Sub

    Private Sub Procesar(e As KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 8 Then 'backspace
                If lblNumeros.Text <> "" Then
                    lblNumeros.Text = lblNumeros.Text.Substring(0, lblNumeros.Text.Length - 1)
                End If

            ElseIf Asc(e.KeyChar) = 45 Then
                If AgregarOperador(" - ") Then
                    MandarOperacion(sPenultimoOperador)
                    sPenultimoOperador = "-"
                End If

            ElseIf Asc(e.KeyChar) = 43 Then
                If AgregarOperador(" + ") Then
                    MandarOperacion(sPenultimoOperador)
                    sPenultimoOperador = "+"
                End If

            ElseIf Asc(e.KeyChar) = 42 Then
                If AgregarOperador(" * ") Then
                    MandarOperacion(sPenultimoOperador)
                    sPenultimoOperador = "*"
                End If

            ElseIf Asc(e.KeyChar) = 47 Then
                If AgregarOperador(" / ") Then
                    MandarOperacion(sPenultimoOperador)
                    sPenultimoOperador = "/"
                End If

            ElseIf Asc(e.KeyChar) = 13 Then 'enter
                If sPenultimoOperador = "" Then
                    Return
                End If
                bFinDeOperacion = True
                Dim eTemp As KeyPressEventArgs = New KeyPressEventArgs(ObtenerUltimoOperador())
                Procesar(eTemp)
                cProcesador.ValorTotal = 0
                sPenultimoOperador = ""
                lblOperacion.Text = ""
                bPrimeraPresion = True
            Else
                Select Case e.KeyChar
                    Case Convert.ToChar(Keys.Escape)
                        lblOperacion.Text = ""
                        lblNumeros.Text = ""
                        cProcesador.ValorTotal = 0
                        sPenultimoOperador = ""
                        bPrimeraPresion = True
                    Case Else
                        If lblNumeros.Text <> "" Then
                            If Convert.ToDouble(lblNumeros.Text) = cProcesador.ValorTotal Or bPrimeraPresion Then
                                bPrimeraPresion = False
                                lblNumeros.Text = e.KeyChar
                            Else
                                If lblNumeros.Text.Contains(e.KeyChar) And e.KeyChar = "." Then
                                    Return
                                End If
                                lblNumeros.Text += e.KeyChar
                            End If
                        Else
                            lblNumeros.Text += e.KeyChar
                        End If
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ObtenerUltimoOperador()
        Select Case lblOperacion.Text.Substring(lblOperacion.Text.Length - 2, 1)
            Case "+"
                Return Convert.ToChar(43)
            Case "-"
                Return Convert.ToChar(45)
            Case "*"
                Return Convert.ToChar(42)
            Case "/"
                Return Convert.ToChar(47)
            Case Else
                Debug.WriteLine("No está mandando lo que tiene que mandar")
                Return 13
        End Select
    End Function

    Private Function AgregarOperador(operador As String)

        If Not bFinDeOperacion Then
            Dim TempCad As String = ""
            If lblOperacion.Text <> "" Then
                TempCad = lblOperacion.Text.Substring(lblOperacion.Text.Length - 2, 1)

                If "+-*/".Contains(TempCad) And cProcesador.ValorTotal = Convert.ToDouble(lblNumeros.Text) Then
                    lblOperacion.Text = lblOperacion.Text.Substring(0, lblOperacion.Text.Length - 3) + operador
                    Return False
                Else
                    lblOperacion.Text += lblNumeros.Text + operador
                    Return True
                End If
            Else
                lblOperacion.Text += lblNumeros.Text + operador
                Return True
            End If
        Else
            lblOperacion.Text = ""
            bFinDeOperacion = False
            Return True
        End If

    End Function

    Private Sub MandarOperacion(operacion As String)
        cProcesador.ProcesarOperacion(sPenultimoOperador, Convert.ToDouble(lblNumeros.Text))
        lblNumeros.Text = cProcesador.ValorTotal
    End Sub

End Class