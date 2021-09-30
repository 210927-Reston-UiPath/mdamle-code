Class Dragon
    '-----------------------------------------------------------
    ' Properties
    Public name As String
    Private weight As Double
    Private species As String
    Public Dim favFoods() As String

    '-----------------------------------------------------------
    ' Consyructors
    Public Sub New(newName As String)
        name = newName
        favFoods = {"dog", "coconut"}
    End Sub

    '-----------------------------------------------------------
    ' Behaviors / Methods / Functions & Subs
    Sub printName()
        Console.WriteLine(name)
    End Sub

    Sub printFavFoods()
        Console.WriteLine(favFoods)
        Console.WriteLine("printing em individually")
        For Each value As String In favFoods
            Console.WriteLine(value)
        Next
    End Sub
    
End Class
