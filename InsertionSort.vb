Public Class InsertionSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length

        For i As Integer = 1 To n - 1
            Dim key As Integer = arr(i)
            Dim j As Integer = i - 1

            ' Mover los elementos del array que son mayores que key
            ' a una posición adelante de su posición actual
            While j >= 0 AndAlso arr(j) > key
                arr(j + 1) = arr(j)
                j = j - 1
            End While

            arr(j + 1) = key
            DisplayStepByStep(arr)
        Next i

        DisplayStepByStep(arr)
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Insertion Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
