Imports System

Module Program
    Sub Main(args As String())
        '-----------------------------------------------------------
        ' Instantiating a Dragon named "Ramesh", and calling their behaviors
        Dim friend1 As Dragon = new Dragon("Ramesh")
        friend1.printName()
        friend1.printFavFoods()
    End Sub
End Module
