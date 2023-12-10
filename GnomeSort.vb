Public Class GnomeSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length
        Dim index As Integer = 0

        While index < n
            If index = 0 Then
                index += 1
            End If

            If arr(index) >= arr(index - 1) Then
                index += 1
            Else
                ' Intercambiar elementos y retroceder
                Dim temp As Integer = arr(index)
                arr(index) = arr(index - 1)
                arr(index - 1) = temp

                index -= 1
            End If

            DisplayStepByStep(arr)
        End While

        DisplayStepByStep(arr)
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Gnome Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
