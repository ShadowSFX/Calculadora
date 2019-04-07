Public Class Procesador
    Public ValorTotal As Double = 0

    Public Sub ProcesarOperacion(operacion As String, valor As Double)
        Select Case operacion
            Case "+"
                Sumar(valor)
            Case "-"
                Restar(valor)
            Case "*"
                Multiplicar(valor)
            Case "/"
                Dividir(valor)
            Case Else
                Sumar(valor)
        End Select
    End Sub

    Public Sub Restar(valor As Double)
        ValorTotal -= valor
    End Sub

    Public Sub Sumar(valor As Double)
        ValorTotal += valor
    End Sub

    Public Sub Multiplicar(valor As Double)
        ValorTotal = ValorTotal * valor
    End Sub

    Public Sub Dividir(valor As Double)
        ValorTotal = ValorTotal / valor
    End Sub

End Class
