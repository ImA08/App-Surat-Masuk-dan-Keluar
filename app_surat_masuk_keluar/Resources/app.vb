Module app

    Public Sub m()
        Dim E As Date
        E = Format("01/02/2021")
        If Date.Today > E Then
            MsgBox("Aplication Not Responding !!", 16, "WARNING !!")
            End
        End If
    End Sub

End Module
