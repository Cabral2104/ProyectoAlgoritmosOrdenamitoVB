Public Class BucketSort
    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length

        ' Encontrar el máximo y mínimo en el array
        Dim maxVal As Integer = arr.Max()
        Dim minVal As Integer = arr.Min()

        ' Crear los cubos
        Dim buckets(maxVal - minVal) As List(Of Integer)
        For i As Integer = 0 To buckets.Length - 1
            buckets(i) = New List(Of Integer)()
        Next i

        ' Colocar elementos en los cubos
        For i As Integer = 0 To n - 1
            buckets(arr(i) - minVal).Add(arr(i))
            DisplayStepByStep(buckets)
        Next i

        ' Ordenar cada cubo e insertar de nuevo en el array principal
        Dim index As Integer = 0
        For Each bucket As List(Of Integer) In buckets
            bucket.Sort()
            For Each item As Integer In bucket
                arr(index) = item
                index += 1
                DisplayStepByStep(arr)
            Next item
        Next bucket

        DisplayStepByStep(arr)
    End Sub

    Private Sub DisplayStepByStep(ByVal buckets() As List(Of Integer))
        Console.WriteLine("Proceso del Bucket Sort:")
        For Each bucket As List(Of Integer) In buckets
            Console.Write("[")
            Console.Write(String.Join(", ", bucket))
            Console.Write("] ")
        Next bucket
        Console.WriteLine()
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Bucket Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub
End Class
