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
        Dim repeat As Boolean = True
        Do While repeat
            Console.WriteLine("Who're you gonna call?")
            Console.WriteLine("Are you gonna call?")
            Dim value As Integer = Integer.Parse(Console.ReadLine)
            Select Case value
                Case 1
                    Console.WriteLine("Thank you for choosing to call")
                Case 2
                    Console.WriteLine("Goodbye then")
                    repeat = False 
                Case Else
                    Console.WriteLine("what the who?")
            End Select
        Loop

    End Sub
End Module
