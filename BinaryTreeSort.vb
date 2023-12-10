Public Class BinaryTreeSort
    Private root As Node

    Public Sub Sort(ByVal arr() As Integer)
        Dim n As Integer = arr.Length

        ' Construir el árbol binario
        For i As Integer = 0 To n - 1
            root = Insert(root, arr(i))
            DisplayStepByStep(arr(i))
        Next i

        ' Recorrer el árbol in-order y almacenar los valores en una lista
        Dim sortedList As New List(Of Integer)()
        InOrderTraversal(root, sortedList)

        ' Copiar la lista ordenada de vuelta al array
        For i As Integer = 0 To n - 1
            If i < sortedList.Count Then
                arr(i) = sortedList(i)
                DisplayStepByStep(arr)
            Else
                ' Manejar el caso en el que el índice está fuera del rango de sortedList
                ' Puedes imprimir un mensaje, lanzar una excepción o realizar alguna otra acción según tus necesidades
                Console.WriteLine("Índice fuera del rango en el bucle de copia.")
                ' También puedes decidir salir del bucle en este punto si es apropiado
                Exit For
            End If
        Next i
    End Sub

    Private Function Insert(ByVal root As Node, ByVal key As Integer) As Node
        If root Is Nothing Then
            Return New Node(key)
        End If

        If key < root.Key Then
            root.Left = Insert(root.Left, key)
        ElseIf key > root.Key Then
            root.Right = Insert(root.Right, key)
        End If

        Return root
    End Function

    Private Sub InOrderTraversal(ByVal root As Node, ByVal sortedList As List(Of Integer))
        If root IsNot Nothing Then
            InOrderTraversal(root.Left, sortedList)
            sortedList.Add(root.Key)
            InOrderTraversal(root.Right, sortedList)
        End If
    End Sub

    Private Sub DisplayStepByStep(ByVal value As Integer)
        Console.WriteLine($"Insertar {value} en el árbol binario:")
        DisplayTree(root, "")
    End Sub

    Private Sub DisplayStepByStep(ByVal arr() As Integer)
        Console.WriteLine("Proceso del Binary Tree Sort:")
        Console.WriteLine(String.Join(", ", arr))
    End Sub

    Private Sub DisplayTree(ByVal root As Node, ByVal prefix As String)
        If root IsNot Nothing Then
            Console.WriteLine($"{prefix}└── {root.Key}")
            DisplayTree(root.Left, $"{prefix}    ")
            DisplayTree(root.Right, $"{prefix}    ")
        End If
    End Sub
End Class
