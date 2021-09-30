Class MainMenu
    Implements IMenu

    Sub Initialize() Implements IMenu.Start
        Dim repeat As Boolean = True
        Do While repeat
            Console.WriteLine("Who're you gonna call?")
            Console.WriteLine(" type ...")
            Console.WriteLine("Are you gonna call?")
            Console.WriteLine(" type 1")
            Console.WriteLine("     type 2 to say no")
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

End Class