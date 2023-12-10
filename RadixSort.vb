Public Class RadixSort
    Public Sub Sort(ByRef arr() As Integer)
        Dim maxVal As Integer = FindMaxValue(arr)

        ' Realizar el sort para cada posición decimal
        For exp As Integer = 1 To maxVal
            CountingSort(arr, exp)
            DisplayStepByStep(arr)
        Next exp

        DisplayStepByStep(arr)
    End Sub

    Private Sub CountingSort(ByRef arr() As Integer, ByVal exp As Integer)
        Dim n As Integer = arr.Length
        Dim output(n - 1) As Integer
        Dim count(10) As Integer

        For i As Integer = 0 To n - 1
            count((arr(i) / exp) Mod 10) += 1
        Next i

        For i As Integer = 1 To 9
            count(i) += count(i - 1)
        Next i

        For i As Integer = n - 1 To 0 Step -1
            output(count((arr(i) / exp) Mod 10) - 1) = arr(i)
            count((arr(i) / exp) Mod 10) -= 1
        Next i

        For i As Integer = 0 To n - 1
            arr(i) = output(i)
        Next i
    End Sub

    Private Function FindMaxValue(ByRef arr() As Integer) As Integer
        Dim max As Integer = arr(0)
        For Each item In arr
            If item > max Then
                max = item
            End If
        Next
        Return max
    End Function

    Private Sub DisplayStepByStep(ByRef arr() As Integer)
        Console.WriteLine("Proceso del Radix Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
