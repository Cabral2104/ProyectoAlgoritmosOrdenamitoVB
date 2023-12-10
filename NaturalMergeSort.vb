Public Class NaturalMergeSort
    Private arreglo() As Integer

    Public Sub Sort(ByVal arr() As Integer)
        arreglo = arr
        MezclaNatural()
    End Sub

    Private Sub MezclaNatural()
        Dim longitud As Integer = arreglo.Length
        Dim izquierda As Integer = 0
        Dim derecha As Integer = 0
        Dim mitad As Integer = 0

        While True
            Dim cambio As Boolean = False
            izquierda = 0

            While izquierda < longitud
                mitad = izquierda + 1

                While mitad < longitud AndAlso arreglo(mitad - 1) <= arreglo(mitad)
                    mitad += 1
                End While

                If mitad = longitud Then
                    Exit While
                End If

                derecha = mitad + 1

                While derecha < longitud AndAlso arreglo(derecha - 1) <= arreglo(derecha)
                    derecha += 1
                End While

                Merge(izquierda, mitad, derecha)
                cambio = True

                izquierda = derecha
            End While

            If Not cambio Then
                Exit While
            End If
        End While
    End Sub

    Private Sub Merge(ByVal izquierda As Integer, ByVal mitad As Integer, ByVal derecha As Integer)
        Console.WriteLine($"Mezclando desde {izquierda} hasta {derecha - 1}")

        Dim temp(derecha - izquierda - 1) As Integer
        Dim i As Integer = izquierda
        Dim j As Integer = mitad
        Dim k As Integer = 0

        While i < mitad AndAlso j < derecha
            If arreglo(i) <= arreglo(j) Then
                temp(k) = arreglo(i)
                k += 1
                i += 1
            Else
                temp(k) = arreglo(j)
                k += 1
                j += 1
            End If
        End While

        While i < mitad
            temp(k) = arreglo(i)
            k += 1
            i += 1
        End While

        While j < derecha
            temp(k) = arreglo(j)
            k += 1
            j += 1
        End While

        For m As Integer = 0 To temp.Length - 1
            arreglo(izquierda + m) = temp(m)
        Next m

        MostrarArreglo()
    End Sub

    Public Sub MostrarArreglo()
        Console.WriteLine(String.Join(", ", arreglo))
    End Sub
End Class
