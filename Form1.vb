Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Public Class Form1

    Dim Seats As New List(Of FlightRow)
    Dim RowCount As Integer = 15
    Dim currSeat As Integer = 1
    Dim SelectedRow As New FlightRow(-1)


    Public Sub New()

        InitializeComponent()
        FlightSeatsListView.FullRowSelect = True
        FlightSeatsListView.MultiSelect = False

        FlightSeatsListView.Columns.Add("A", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("B", 50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("C",50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("",50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("D",50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("E",50).TextAlign = HorizontalAlignment.Center
        FlightSeatsListView.Columns.Add("F",50).TextAlign = HorizontalAlignment.Center

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
        If FlightSeatsListView.SelectedItems.Count > 0
            Dim selectedItem = FlightSeatsListView.Items(FlightSeatsListView.SelectedItems(0).Index).SubItems
            CurrSeatA.Text = selectedItem(0).Text
            CurrSeatB.Text = selectedItem(1).Text
            CurrSeatC.Text = selectedItem(2).Text
            CurrSeatD.Text = selectedItem(4).Text
            CurrSeatE.Text = selectedItem(5).Text
            CurrSeatF.Text = selectedItem(6).Text
        End If
    End Sub

    Private Sub UpdateRowBtn_Click(sender As Object, e As EventArgs) Handles UpdateRowBtn.Click
        If FlightSeatsListView.SelectedItems.Count > 0
            Dim selectedItem = FlightSeatsListView.Items(FlightSeatsListView.SelectedItems(0).Index).SubItems
           selectedItem(0).Text = CurrSeatA.Text
           selectedItem(1).Text = CurrSeatB.Text
           selectedItem(2).Text = CurrSeatC.Text
           selectedItem(4).Text = CurrSeatD.Text
           selectedItem(5).Text = CurrSeatE.Text
           selectedItem(6).Text = CurrSeatF.Text
        End If
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


