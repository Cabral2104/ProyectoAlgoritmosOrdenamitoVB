Public Class SelectionSort
    Public Sub Sort(ByVal arr() As Integer)
        DisplayStepByStep(arr)
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Selection Sort:")

        For i As Integer = 0 To arr.Length - 2
            Dim minIndex As Integer = i
            For j As Integer = i + 1 To arr.Length - 1
                If arr(j) < arr(minIndex) Then
                    minIndex = j
                End If
            Next j

            ' Intercambiar el elemento mínimo con el primero no ordenado
            Dim temp As Integer = arr(minIndex)
            arr(minIndex) = arr(i)
            arr(i) = temp

            Console.WriteLine(String.Join(", ", arr))
        Next i
    End Sub
End Class
