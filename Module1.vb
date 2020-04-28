Module Module1

    Sub Main(args As String())
        Dim limite As Integer
        Dim secuencia As String = " |"

        Console.WriteLine("Introduce el límite de la secuencia Fibonacci")
        limite = Console.ReadLine()

        For i As Integer = 1 To limite
            secuencia += Fibonacci(i) + " |"
        Next i

        Console.Write("Secuencia: " + secuencia)
    End Sub

    Private Function Fibonacci(i As Integer) As String
        If (i = 0 Or i = 1) Then
            Return i
        Else
            Return Fibonacci(i - 1) + Fibonacci(i - 2)
        End If
    End Function

End Module
