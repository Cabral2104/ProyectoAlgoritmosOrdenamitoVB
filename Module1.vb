Module Module1

    Sub Main(args As String())
        Do
            ' Obtener datos del usuario
            Console.WriteLine("Ingrese los datos separados por comas:")
            Dim inputLine As String = Console.ReadLine()
            Dim data As Integer() = Array.ConvertAll(Of String, Integer)(inputLine.Split(","c), AddressOf Integer.Parse)

            ' Seleccionar algoritmo
            Console.WriteLine("Seleccione un algoritmo de ordenamiento:")
            Console.WriteLine("1. Shell Sort")
            Console.WriteLine("2. Selection Sort")
            Console.WriteLine("3. Heap Sort")
            Console.WriteLine("4. Quick Sort")
            Console.WriteLine("5. Bubble Sort")
            Console.WriteLine("6. Cocktail Sort")
            Console.WriteLine("7. Insertion Sort")
            Console.WriteLine("8. Bucket Sort")
            Console.WriteLine("9. Counting Sort")
            Console.WriteLine("10. Merge Sort")
            Console.WriteLine("11. Binary Tree Sort")
            Console.WriteLine("12. Radix Sort")
            Console.WriteLine("13. Gnome Sort")
            Console.WriteLine("14. Natural Merge Sort")

            Dim choice As Integer = Integer.Parse(Console.ReadLine())

            ' Crear una instancia del algoritmo seleccionado
            Dim selectedAlgorithm = GetSortingAlgorithm(choice)

            ' Medir el tiempo de ejecución
            Dim stopwatch = System.Diagnostics.Stopwatch.StartNew()

            ' Llamar al método de ordenamiento
            selectedAlgorithm.Sort(data)

            stopwatch.Stop()
            Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms")

            ' Mostrar resultados ordenados
            Console.WriteLine("Datos ordenados:")
            Console.WriteLine(String.Join(", ", data))

            ' Preguntar al usuario si desea repetir con otro algoritmo
            Console.WriteLine("¿Desea probar otro algoritmo? (Sí/No)")
        Loop While Console.ReadLine().Trim().ToUpper() = "SI"
    End Sub

    Function GetSortingAlgorithm(choice As Integer) As Object
        ' Devuelve una instancia del algoritmo de ordenamiento seleccionado
        Select Case choice
            Case 1
                Return New ShellSort()
            Case 2
                Return New SelectionSort()
            Case 3
                Return New HeapSort()
            Case 4
                Return New QuickSort()
            Case 5
                Return New BubbleSort()
            Case 6
                Return New CocktailSort()
            Case 7
                Return New InsertionSort()
            Case 8
                Return New BucketSort()
            Case 9
                Return New CountingSort()
            Case 10
                Return New MergeSort()
            Case 11
                Return New BinaryTreeSort()
            Case 12
                Return New RadixSort()
            Case 13
                Return New GnomeSort()
            Case 14
                Return New NaturalMergeSort()
            Case Else
                Throw New ArgumentException("Opción no válida")
        End Select
    End Function


End Module
