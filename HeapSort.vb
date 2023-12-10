Public Class HeapSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length

        ' Construir un heap máximo
        For i As Integer = n \ 2 - 1 To 0 Step -1
            Heapify(arr, n, i)
        Next i

        ' Extraer elementos del heap uno por uno
        For i As Integer = n - 1 To 1 Step -1
            ' Mover la raíz actual al final
            Swap(arr(0), arr(i))

            ' Llamar a Heapify en el heap reducido
            Heapify(arr, i, 0)

            DisplayStepByStep(arr)
        Next i
    End Sub

    Private Sub Heapify(ByVal arr() As Integer, ByVal n As Integer, ByVal i As Integer)
        Dim largest As Integer = i ' Inicializar el nodo más grande como la raíz
        Dim left As Integer = 2 * i + 1 ' Índice del hijo izquierdo
        Dim right As Integer = 2 * i + 2 ' Índice del hijo derecho

        ' Si el hijo izquierdo es más grande que la raíz
        If left < n AndAlso arr(left) > arr(largest) Then
            largest = left
        End If

        ' Si el hijo derecho es más grande que el nodo más grande hasta ahora
        If right < n AndAlso arr(right) > arr(largest) Then
            largest = right
        End If

        ' Si el nodo más grande no es la raíz
        If largest <> i Then
            Swap(arr(i), arr(largest))

            ' Recursivamente Heapify el subárbol afectado
            Heapify(arr, n, largest)
        End If
    End Sub

    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer = a
        a = b
        b = temp
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Heap Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
