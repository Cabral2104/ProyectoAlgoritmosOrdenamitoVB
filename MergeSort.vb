Public Class MergeSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length
        Dim temp(n - 1) As Integer
        MergeSortRecursive(arr, temp, 0, n - 1)
    End Sub

    Private Sub MergeSortRecursive(ByVal arr() As Integer, ByVal temp() As Integer, ByVal left As Integer, ByVal right As Integer)
        If left < right Then
            Dim mid As Integer = (left + right) \ 2

            ' Ordenar recursivamente las dos mitades
            MergeSortRecursive(arr, temp, left, mid)
            MergeSortRecursive(arr, temp, mid + 1, right)

            ' Combinar las dos mitades ordenadas
            Merge(arr, temp, left, mid, right)
            DisplayStepByStep(arr)
        End If
    End Sub

    Private Sub Merge(ByVal arr() As Integer, ByVal temp() As Integer, ByVal left As Integer, ByVal mid As Integer, ByVal right As Integer)
        Dim i As Integer = left
        Dim j As Integer = mid + 1
        Dim k As Integer = left

        While i <= mid AndAlso j <= right
            If arr(i) <= arr(j) Then
                temp(k) = arr(i)
                i += 1
            Else
                temp(k) = arr(j)
                j += 1
            End If
            k += 1
        End While

        While i <= mid
            temp(k) = arr(i)
            i += 1
            k += 1
        End While

        While j <= right
            temp(k) = arr(j)
            j += 1
            k += 1
        End While

        For index As Integer = left To right
            arr(index) = temp(index)
        Next index
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Merge Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
