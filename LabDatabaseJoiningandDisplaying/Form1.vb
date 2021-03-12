Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Baseball__1_DataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me._Baseball__1_DataSet.Teams)
        'TODO: This line of code loads data into the '_Baseball__1_DataSet.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter.Fill(Me._Baseball__1_DataSet.Players)


        'create a query to fill the teams listbox
        Dim query = From club In _Baseball__1_DataSet.Teams
                    Order By club.team
                    Select club.team

        ListBox1.DataSource = query.ToList
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'create a query
        Dim query1 = From person In _Baseball__1_DataSet.Players
                     Join club In _Baseball__1_DataSet.Teams
                         On person.team Equals club.team
                     Let playerBattingAvg = person.hits / person.atBats
                     Let teamBattingAvg = club.hits / club.atBats
                     Where club.team = ListBox1.Text And playerBattingAvg > teamBattingAvg
                     Order By playerBattingAvg Descending
                     Select person.player

        'output the results
        ListBox2.DataSource = query1.ToList
        ListBox2.SelectedItem = Nothing
    End Sub
End Class
