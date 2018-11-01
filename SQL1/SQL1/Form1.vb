Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration

Public Class Form1
    Private WithEvents ConnSQL As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True")
    Private WithEvents ConnOLEDB As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Survey.mdb;Persist Security Info=True")

    Private Sub btnOpenSQL_Click(sender As Object, e As EventArgs) Handles btnOpenSQL.Click
        Try
            ConnSQL.Open()

        Catch ex As Exception
            MessageBox.Show("Problem Connecting to SQL " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnCloseSQL_Click(sender As Object, e As EventArgs) Handles btnCloseSQL.Click
        ConnSQL.Close()

    End Sub

    Private Sub btnOpenOLEDB_Click(sender As Object, e As EventArgs) Handles btnOpenOLEDB.Click
        Try
            ConnOLEDB.Open()
        Catch ex As Exception
            MessageBox.Show("Problem Connecting to OLEDB " & ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnCloseOLEDB_Click(sender As Object, e As EventArgs) Handles btnCloseOLEDB.Click
        ConnOLEDB.Close()

    End Sub

    Private Sub btnGetSQlInfo_Click(sender As Object, e As EventArgs) Handles btnGetSQlInfo.Click
        MessageBox.Show(ConnSQL.ServerVersion.ToString & " Server Version")
    End Sub

    Private Sub btnGetOLEDBInfo_Click(sender As Object, e As EventArgs) Handles btnGetOLEDBInfo.Click
        MessageBox.Show(ConnOLEDB.ServerVersion & " Server Version")
    End Sub

    Private Sub ConnSQL_StateChange(sender As Object, e As StateChangeEventArgs) Handles ConnSQL.StateChange
        lblSQLConnectionSatte.Text = e.CurrentState.ToString()
    End Sub

    Private Sub ConnOLEDB_StateChange(sender As Object, e As StateChangeEventArgs) Handles ConnOLEDB.StateChange
        lblOLEDBConnectionState.Text = e.CurrentState.ToString()
    End Sub
    Private Sub ConnectToDatabase(ByVal connectionstring As String)
        Dim conn As New SqlClient.SqlConnection(connectionstring)
        Try
            conn.Open()

        Catch ex As sqlException
            Dim errMessage As String = ""
            For Each connError As SqlError In ex.Errors
                errMessage += connError.Message & connError.Number.ToString & Environment.NewLine
                If connError.Number = 18452 Then
                    MessageBox.Show("Invalid Login Detected, Please provide valid credentials")
                Else
                    MessageBox.Show("Problem Connection " & errMessage)
                End If
            Next
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub BtnConnToInvalidDatabase_Click(sender As Object, e As EventArgs) Handles BtnConnToInvalidDatabase.Click
        Dim invalidConnString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        ConnectToDatabase(invalidConnString)
    End Sub
    Private Sub EncryptConnectionString()
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim provider As String = "DataProtectionConfigurationProvider"
        Dim connString As ConfigurationSection = config.ConnectionStrings
        connString.SectionInformation.ProtectSection(provider)
        connString.SectionInformation.ForceSave = True
        config.Save(ConfigurationSaveMode.Full)

    End Sub
    Private Sub DecryptConnectionString()
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        Dim connString As ConfigurationSection = config.ConnectionStrings
        connString.SectionInformation.UnprotectSection()
        connString.SectionInformation.ForceSave = True
        config.Save(ConfigurationSaveMode.Full)

    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        EncryptConnectionString()

    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        DecryptConnectionString()
    End Sub
End Class
