Class Contact
    Property name As String
    Property phoneNumber As Integer

    'parameterless constructor
    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String, ByVal number As Integer)
        Me.name = name
        Me.phoneNumber = number
    End Sub

    Overrides Function toString() As String 
        return $"Name: {Me.name} Number: {Me.phoneNumber}"
    End Function
End Class

    'external libraries dealing with your objects, will look for a parameterless constructor
