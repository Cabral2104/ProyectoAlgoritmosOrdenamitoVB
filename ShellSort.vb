Public Class ShellSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length
        Dim gap As Integer = n \ 2
        Dim temp As Integer
        Dim j As Integer

        DisplayStepByStep(arr)

        While gap > 0
            For i As Integer = gap To n - 1
                temp = arr(i)
                j = i

                While j >= gap AndAlso arr(j - gap) > temp
                    arr(j) = arr(j - gap)
                    j -= gap
                End While

                arr(j) = temp
            Next i

            gap \= 2
            DisplayStepByStep(arr)
        End While
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Shell Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
