Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public Class AirplaneSeatingChartForm

    Dim Seats As New List(Of FlightRow)
    Dim RowCount As Integer = 15
    Dim currSeat As Integer = 1
    Dim SelectedRow As New FlightRow(-1)
    Dim SelectedSeat As String


    Public Sub New()

        InitializeComponent()
        FlightSeatsListView.FullRowSelect = True
        FlightSeatsListView.MultiSelect = False

        FlightSeatsListView.Columns.Add("A", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("B", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("C", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("D", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("E", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("F", 50).TextAlign = HorizontalAlignment.Center

        For I = 1 To RowCount
            Seats.Add(New FlightRow(I))

        Next

        For Each seat As FlightRow In Seats
            Dim arr As String() = New String(7) {}

            arr(0) = "."
            arr(1) = "."
            arr(2) = "."
            arr(3) = " "
            arr(4) = "."
            arr(5) = "."
            arr(6) = "."
            Dim item As New ListViewItem(arr)


            FlightSeatsListView.Items.Add(item)
        Next



    End Sub

    Private Sub FlightSeatsListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FlightSeatsListView.SelectedIndexChanged
        If FlightSeatsListView.SelectedItems.Count > 0 Then
            Dim selectedItem = FlightSeatsListView.Items(FlightSeatsListView.SelectedItems(0).Index).SubItems
            CurrSeatA.Text = selectedItem(0).Text
            CurrSeatB.Text = selectedItem(1).Text
            CurrSeatC.Text = selectedItem(2).Text
            CurrSeatD.Text = selectedItem(4).Text
            CurrSeatE.Text = selectedItem(5).Text
            CurrSeatF.Text = selectedItem(6).Text
        End If
    End Sub

    Private Sub CurrSeat_Click(sender As Object, e As EventArgs) Handles CurrSeatA.Click, CurrSeatB.Click, CurrSeatC.Click, CurrSeatD.Click, CurrSeatE.Click, CurrSeatF.Click
        With DirectCast(sender, TextBox)
            SelectedSeat = CStr(.Tag)
        End With

        Dim frm As New SeatAssignForm
        frm.callerForm = Me
        frm.ShowDialog()
    End Sub

    Public Sub UpdateSelectedSeat(seatType As String)
        If FlightSeatsListView.SelectedItems.Count > 0 Then
            Dim selectedItem = FlightSeatsListView.Items(FlightSeatsListView.SelectedItems(0).Index).SubItems
            Select Case SelectedSeat
                Case "A"
                    CurrSeatA.Text = seatType
                    selectedItem(0).Text = CurrSeatA.Text
                Case "B"
                    CurrSeatB.Text = seatType
                    selectedItem(1).Text = CurrSeatB.Text
                Case "C"
                    CurrSeatC.Text = seatType
                    selectedItem(2).Text = CurrSeatC.Text
                Case "D"
                    CurrSeatD.Text = seatType
                    selectedItem(4).Text = CurrSeatD.Text
                Case "E"
                    CurrSeatE.Text = seatType
                    selectedItem(5).Text = CurrSeatE.Text
                Case "F"
                    CurrSeatF.Text = seatType
                    selectedItem(6).Text = CurrSeatF.Text
                Case Else
                    Debug.WriteLine("No Selected Seat")
            End Select
        End If

    End Sub

    Private Sub RefreshStats_Click(sender As Object, e As EventArgs) Handles RefreshStats.Click
        Dim seatsFilled = 0
        Dim windowsAvailable = 0
        Dim RegMeals = 0
        Dim LowCalMeals = 0
        Dim VeggieMeals = 0

        For Each row As ListViewItem In FlightSeatsListView.Items
            Dim currIndex As Integer = 0
            For Each item As ListViewItem.ListViewSubItem In row.SubItems
                If currIndex = 0 Or currIndex = 6 And item.Text Is "."
                    windowsAvailable += 1                    
                End If

                Select Case item.Text
                    Case "R"
                        seatsFilled += 1
                        RegMeals += 1
                    Case "V"
                        seatsFilled += 1
                        VeggieMeals += 1
                    Case "L"
                        seatsFilled += 1
                        LowCalMeals += 1
                End Select
                currIndex += 1

            Next
        Next
        SeatsFilledLbl.Text = seatsFilled
        WindowsAvalLbl.Text = windowsAvailable
        RegMealLbl.Text = RegMeals
        LowCalMealLbl.Text = LowCalMeals
        VegMealLbl.Text = VeggieMeals

    End Sub
End Class

Public Class FlightRow

    Public A As String = "."
    Public B As String = "."
    Public C As String = "."
    Public D As String = "."
    Public E As String = "."
    Public F As String = "."
    Public RowNum As Integer

    Public Sub New(rowNum As Integer)
        rowNum = rowNum

    End Sub



End Class


