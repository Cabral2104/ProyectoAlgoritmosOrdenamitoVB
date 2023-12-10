Public Class Node
    Public Key As Integer
    Public Left, Right As Node

    Public Sub New(ByVal item As Integer)
        Key = item
        Left = Nothing
        Right = Nothing
    End Sub
End Class
