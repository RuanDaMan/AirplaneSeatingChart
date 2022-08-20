Public Class SeatAssignForm
    Public callerForm As AirplaneSeatingChartForm
    Private Loaded As Boolean = False

    Private Sub AssignSeat(sender As Object, e As EventArgs) Handles Unoccupied.Click, Regular.Click, Vegetarian.Click, LowCalorie.Click
        If Loaded Then
            With DirectCast(sender, RadioButton)
                Dim data As String = CStr(.Tag)
                If data Is "." Or data Is "R" Or data Is "L" Or data Is "V" Then
                    callerForm.UpdateSelectedSeat(CStr(.Tag))
                    Me.Close()
                End If

            End With
            Else
            Loaded = True

        End If

    End Sub
End Class