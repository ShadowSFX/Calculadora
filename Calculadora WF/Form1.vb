Public Class FrmCalc

    Private bFinDeOperacion As Boolean = False
    Public cProcesador As Procesador = New Procesador()

    Private Sub FrmCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
    End Sub

    Private Sub FrmCalc_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub FrmCalc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine(e.KeyChar)
        Procesar(e)
    End Sub

    Private Sub Procesar(e As KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 8 Then
                lblNumeros.Text = lblNumeros.Text.Substring(0, lblNumeros.Text.Length - 1)
            ElseIf Asc(e.KeyChar) = 45 Then
                If AgregarOperador(" - ") Then
                    cProcesador.Restar(Convert.ToDouble(lblNumeros.Text))
                    lblNumeros.Text = cProcesador.ValorTotal
                End If

            ElseIf Asc(e.KeyChar) = 43 Then
                If AgregarOperador(" + ") Then
                    cProcesador.Sumar(Convert.ToDouble(lblNumeros.Text))
                    lblNumeros.Text = cProcesador.ValorTotal
                End If


            ElseIf Asc(e.KeyChar) = 42 Then
                If AgregarOperador(" * ") Then
                    cProcesador.Multiplicar(Convert.ToDouble(lblNumeros.Text))
                    lblNumeros.Text = cProcesador.ValorTotal
                End If


            ElseIf Asc(e.KeyChar) = 47 Then
                If AgregarOperador(" / ") Then
                    cProcesador.Dividir(Convert.ToDouble(lblNumeros.Text))
                    lblNumeros.Text = cProcesador.ValorTotal
                End If

            ElseIf Asc(e.KeyChar) = 13 Then
                bFinDeOperacion = True
                Dim eTemp As KeyPressEventArgs = New KeyPressEventArgs(ObtenerUltimoOperador())
                Procesar(eTemp)
            Else
                Select Case e.KeyChar
                    Case Convert.ToChar(Keys.Escape)
                        lblOperacion.Text = ""
                        lblNumeros.Text = ""
                        cProcesador.ValorTotal = 0
                    Case Else
                        If lblNumeros.Text <> "" Then
                            If Convert.ToDouble(lblNumeros.Text) = cProcesador.ValorTotal Then
                                lblNumeros.Text = e.KeyChar
                            Else
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
            Dim bOperar As Boolean = False
            Dim TempCad As String = ""
            If lblOperacion.Text <> "" Then
                TempCad = lblOperacion.Text.Substring(lblOperacion.Text.Length - 2, 1)
            End If

            If "+-*/".Contains(TempCad) And cProcesador.ValorTotal = Convert.ToDouble(lblNumeros.Text) Then
                lblOperacion.Text = lblOperacion.Text.Substring(0, lblOperacion.Text.Length - 3) + operador
            Else
                bOperar = True
                lblOperacion.Text += lblNumeros.Text + operador
            End If

            Return bOperar
        Else
            lblOperacion.Text = ""

            Return True
        End If

    End Function

End Class