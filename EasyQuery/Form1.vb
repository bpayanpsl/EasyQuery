Imports System.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Data Source=serveur_silog;Initial Catalog=master;User ID=sa;Password="
    Dim con = New SqlConnection(connectionString)
    Dim database As String
    Dim table As String
    Dim schema As String
    Dim finalQuery As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargeDatabases()
    End Sub

    Private Sub chargeDatabases()
        ComboBoxDatabases.Items.Clear()
        con.open()
        Dim command As New SqlCommand("SELECT name FROM sys.databases order by name", con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                ComboBoxDatabases.Items.Add(reader("name"))
            End While
        End If
        reader.Close()
        con.close()
    End Sub

    Private Sub ComboBoxDatabases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDatabases.SelectedIndexChanged
        database = ComboBoxDatabases.Text
        connectionString = "Data Source=serveur_silog;Initial Catalog=" & database & ";User ID=sa;Password="
        con = New SqlConnection(connectionString)
        chargeTables()
    End Sub

    Private Sub chargeTables()
        ComboBoxTables.Items.Clear()
        con.open()
        Dim command As New SqlCommand("SELECT table_name FROM information_schema.tables ORDER BY table_name", con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                ComboBoxTables.Items.Add(reader("table_name"))
            End While
        End If
        reader.Close()
        con.close()
    End Sub

    Private Sub ComboBoxAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAction.SelectedIndexChanged

    End Sub

    Private Sub chargeChamps()
        CheckedListBoxChamps.Items.Clear()
        CheckedListBoxChamps.Items.Add("*")
        con.open()
        Dim command As New SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" & table & "'", con)
        Dim reader As SqlDataReader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                CheckedListBoxChamps.Items.Add(reader("column_name"))
            End While
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub ComboBoxTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTables.SelectedIndexChanged
        con.open()
        Dim query As String = "SELECT table_schema FROM information_schema.tables where table_name = '" & ComboBoxTables.Text & "'"
        Console.WriteLine(query)
        Dim command As New SqlCommand(query, con)
        Dim reader As SqlDataReader = command.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            table = ComboBoxTables.Text
            schema = reader("table_schema")
        End If
        reader.Close()
        con.close()
        chargeChamps()
    End Sub

    Private Sub CheckedListBoxChamps_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBoxChamps.ItemCheck
        If Not (CheckedListBoxChamps.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked) Then
            finalQuery = ""
            finalQuery = ComboBoxAction.Text & " "
            Dim first As Boolean = True
            For Each item In CheckedListBoxChamps.CheckedItems
                If first Then
                    finalQuery = finalQuery & item.ToString
                    first = False
                Else
                    finalQuery = finalQuery & ", " & item.ToString
                End If
            Next
            If e.NewValue = CheckState.Checked Then
                If Not first Then
                    finalQuery = finalQuery & ", " & CheckedListBoxChamps.Items(e.Index)
                Else
                    finalQuery = finalQuery & CheckedListBoxChamps.Items(e.Index)
                End If
            Else
                finalQuery = Replace(finalQuery, CheckedListBoxChamps.Items(e.Index), "")
            End If
            finalQuery = finalQuery & " FROM " & schema & "." & table
            RichTextBoxVisu.Clear()
            RichTextBoxVisu.Text = finalQuery
        Else
            RichTextBoxVisu.Clear()
            finalQuery = ""
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim sqlCmd As New SqlCommand()
        sqlCmd.Connection = con
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.CommandText = finalQuery
        Dim sqlDataAdap As New SqlDataAdapter(sqlCmd)
        Dim dtRecord As New DataTable()
        sqlDataAdap.Fill(dtRecord)
        DataGridViewResult.DataSource = dtRecord
    End Sub
End Class
