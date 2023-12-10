Public Class QuickSort
    Public Sub Sort(ByVal arr() As Integer)
        Sort(arr, 0, arr.Length - 1)
        DisplayStepByStep(arr)
    End Sub

    Private Sub Sort(ByVal arr() As Integer, ByVal low As Integer, ByVal high As Integer)
        If low < high Then
            ' Obtener el índice del pivote después de la partición
            Dim pi As Integer = Partition(arr, low, high)

            ' Ordenar los elementos antes y después del pivote
            Sort(arr, low, pi - 1)
            Sort(arr, pi + 1, high)
        End If
    End Sub

    Private Function Partition(ByVal arr() As Integer, ByVal low As Integer, ByVal high As Integer) As Integer
        Dim pivot As Integer = arr(high)
        Dim i As Integer = low - 1 ' Índice del menor elemento

        For j As Integer = low To high - 1
            ' Si el elemento actual es menor o igual al pivote
            If arr(j) <= pivot Then
                i += 1

                ' Intercambiar arr(i) y arr(j)
                Swap(arr(i), arr(j))

                DisplayStepByStep(arr)
            End If
        Next j

        ' Intercambiar arr(i + 1) y arr[high] (pivote)
        Swap(arr(i + 1), arr(high))

        DisplayStepByStep(arr)

        Return i + 1
    End Function

    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Quick Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
