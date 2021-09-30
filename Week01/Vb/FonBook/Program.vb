Imports System

Module Program
    Sub Main(args As String())
        '-----------------------------------------------------------------------------------------
        Console.WriteLine("Hello World!")
        Console.WriteLine("BirdS!")
        Dim num As String = "HI"
        Dim i As Integer = 0
        Do While i < 5
            Console.WriteLine(num)
            i = i + 1
        Loop

        '-----------------------------------------------------------------------------------------
        Dim menu As IMenu = new MainMenu()
        menu.Start()


    End Sub
End Module
