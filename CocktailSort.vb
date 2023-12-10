Public Class CocktailSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim swapped As Boolean
        Do
            swapped = False

            ' Mover el elemento más grande al final
            For i As Integer = 0 To arr.Length - 2
                If arr(i) > arr(i + 1) Then
                    Swap(arr(i), arr(i + 1))
                    DisplayStepByStep(arr)
                    swapped = True
                End If
            Next i

            ' Si no hubo intercambios, el array ya está ordenado
            If Not swapped Then
                Exit Do
            End If

            swapped = False

            ' Mover el elemento más pequeño al inicio
            For i As Integer = arr.Length - 2 To 0 Step -1
                If arr(i) > arr(i + 1) Then
                    Swap(arr(i), arr(i + 1))
                    DisplayStepByStep(arr)
                    swapped = True
                End If
            Next i

        Loop While swapped

        DisplayStepByStep(arr)
    End Sub

    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Cocktail Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
