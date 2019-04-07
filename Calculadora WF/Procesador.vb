Public Class Procesador
    Public ValorTotal As Double = 0

    Public Sub Restar(valor As Double)
        ValorTotal -= valor
    End Sub

    Public Sub Sumar(valor As Double)
        ValorTotal += valor
    End Sub

    Public Sub Multiplicar(valor As Double)
        ValorTotal *= valor
    End Sub

    Public Sub Dividir(valor As Double)
        ValorTotal /= valor
    End Sub

End Class
