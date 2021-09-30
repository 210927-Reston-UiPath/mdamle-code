Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim friend1 As Dragon = new Dragon("ramesh")
        friend1.printName()
        friend1.printFavFoods()
    End Sub
End Module
