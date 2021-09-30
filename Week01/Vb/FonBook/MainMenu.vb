Imports System.IO
Imports System.Text.Json

Class MainMenu
    Implements IMenu

    Dim friends As List(of Contact) = new List(of Contact)
    Dim filename As String = "friends.json"
    Dim jsonstring As String = ""
    

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
            Console.WriteLine("- See contact list?")
            Console.WriteLine(Chr(9)+"type 4")
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
                Case 4
                    Console.WriteLine("Contact List:")
                    ShowContacts()
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
        'friends.Add(newFriend)
        AddContactsToFile(newFriend)
        Console.WriteLine(String.concat("New Contact/Friend created", Environment.NewLine, newFriend))
    End Sub

    Sub ShowContacts()
        Console.WriteLine("Contact list + contact info:")
        For Each person As Contact In GetContactsFromFile()
            Console.WriteLine(person)
        Next
    End Sub
    
    Sub AddContactsToFile(ByVal person As Contact)
        Dim existingContacts As List(of Contact) = GetContactsFromFile()
        existingContacts.Add(person)
        jsonstring = JsonSerializer.Serialize(existingContacts)
        File.WriteAllText(filename, jsonstring)
    End Sub

    Function GetContactsFromFile() As List(of Contact)
        Try
            jsonstring = File.ReadAllText(filename)
            Console.WriteLine("JSON file found")
            return JsonSerializer.Deserialize(of List(of Contact)) (jsonstring)
        Catch ex As Exception
            Console.WriteLine("JSON file NOT found")
            return new List(of Contact)
        End Try
    End Function

End Class