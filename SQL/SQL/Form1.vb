Imports System.Data.SqlClient
Imports System.Data.OleDb



Public Class Form1
    Private WithEvents connSQL As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
    Private WithEvents connOLEDB As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Survey.mdb;Persist Security Info=True")

    Private Sub btnOpenSQL_Click(sender As Object, e As EventArgs) Handles btnOpenSQL.Click
        Try
            connSQL.Open()
        Catch ex As Exception
            MessageBox.Show("Problem connecting to SQL" & ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnOpenOleDB_Click(sender As Object, e As EventArgs) Handles btnOpenOleDB.Click
        Try
            connOLEDB.Open()

        Catch ex As Exception
            MessageBox.Show("Problem Connecting to OleDB" & ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnCloseSQL_Click(sender As Object, e As EventArgs) Handles btnCloseSQL.Click
        connSQL.Close()

    End Sub

    Private Sub btnCloseOLEDB_Click(sender As Object, e As EventArgs) Handles btnCloseOLEDB.Click
        connOLEDB.Close()

    End Sub

    Private Sub connSQL_StateChange(sender As Object, e As StateChangeEventArgs) Handles connSQL.StateChange
        lblSQLConnectionState.Text = e.CurrentState.ToString()
    End Sub

    Private Sub connOLEDB_StateChange(sender As Object, e As StateChangeEventArgs) Handles connOLEDB.StateChange
        lblOLEDBConnectionState.Text = e.CurrentState.ToString()
    End Sub

    Private Sub btnGetSQLInfo_Click(sender As Object, e As EventArgs) Handles btnGetSQLInfo.Click
        MessageBox.Show(connSQL.ServerVersion.ToString & " Server Version")
    End Sub

    Private Sub btnGetOLEDBInfo_Click(sender As Object, e As EventArgs) Handles btnGetOLEDBInfo.Click
        MessageBox.Show(connOLEDB.ServerVersion & " Server Version")
    End Sub
End Class
