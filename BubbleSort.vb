Public Class BubbleSort
    Public Sub Sort(ByVal arr() As Integer)
        For i As Integer = 0 To arr.Length - 2
            For j As Integer = 0 To arr.Length - i - 2
                ' Comparar elementos adyacentes
                If arr(j) > arr(j + 1) Then
                    ' Intercambiar si el elemento actual es mayor que el siguiente
                    Swap(arr(j), arr(j + 1))
                    DisplayStepByStep(arr)
                End If
            Next j
        Next i

        DisplayStepByStep(arr)
    End Sub

    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Bubble Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
