Class MainMenu
    Implements IMenu

    Sub Initialize() Implements IMenu.Start
        Dim repeat As Boolean = True
        Do While repeat
            Console.WriteLine("- Who're you gonna call?")
            Console.WriteLine(Chr(9)+"type ...")
            Console.WriteLine("- Are you gonna call?")
            Console.WriteLine(Chr(9)+"type 1 to say yes")
            Console.WriteLine(Chr(9)+"type 2 to say no, and thus to exit")
            Console.WriteLine("- Add a contact?")
            Console.WriteLine(Chr(9)+"type 3")
            Dim value As Integer = Integer.Parse(Console.ReadLine())
            Select Case value
                Case 1
                    Console.WriteLine("Thank you for choosing to call")
                Case 2
                    Console.WriteLine("Goodbye then")
                    repeat = False
                Case 3
                    Console.WriteLine("Adding friend")
                    AddContact()
                Case Else
                    Console.WriteLine("what the who?")
            End Select
        Loop
    End Sub

    Sub AddContact()
        Console.WriteLine("Name: ")
        Dim name As String = Console.ReadLine()
        Console.WriteLine("Number: ")
        Dim number As String = console.ReadLine()
        Dim newFriend As Contact = new Contact(name, Int32.Parse(number))
        Console.WriteLine(String.concat("New Contact/Friend created", Environment.NewLine, newFriend))
    End Sub

End Class