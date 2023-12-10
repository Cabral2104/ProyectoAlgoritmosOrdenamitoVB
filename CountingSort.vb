Public Class CountingSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length

        ' Encontrar el valor máximo en el array
        Dim maxVal As Integer = arr(0)
        For i As Integer = 1 To n - 1
            If arr(i) > maxVal Then
                maxVal = arr(i)
            End If
        Next i

        ' Crear el array de conteo
        Dim count(maxVal) As Integer

        ' Contar la frecuencia de cada elemento
        For i As Integer = 0 To n - 1
            count(arr(i)) += 1
            DisplayStepByStepCount(count)
        Next i

        ' Reconstruir el array ordenado
        Dim index As Integer = 0
        For i As Integer = 0 To maxVal
            While count(i) > 0
                arr(index) = i
                index += 1
                count(i) -= 1
                DisplayStepByStepArray(arr)
            End While
        Next i

        DisplayStepByStepArray(arr)
    End Sub

    Private Sub DisplayStepByStepArray(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Counting Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub

    Private Sub DisplayStepByStepCount(ByVal count() As Integer)
        Console.WriteLine("Proceso del Counting Sort:")
        Console.WriteLine(String.Join(", ", count))
    End Sub
End Class
