Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class StartForm

    Dim ds1 As New DataSet
    Dim ds2 As New DataSet

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles Import.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim _conn As String
            _conn = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & strFileName & ";" & "Extended Properties=Excel 8.0;"
            Dim _connection As OleDbConnection = New OleDbConnection(_conn)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter()
            Dim _command As OleDbCommand = New OleDbCommand()
            _command.Connection = _connection
            _command.CommandText = "SELECT * FROM [Introduction$]"
            da.SelectCommand = _command
            Try
                da.Fill(ds1, "sheet1")
                MessageBox.Show("The import is complete!")
                'Me.DataGridView1.DataSource = ds1
                'Me.DataGridView1.DataMember = "sheet1"
            Catch e1 As Exception
                MessageBox.Show("Import Failed, correct Column name in the sheet!")
            End Try
        End If
    End Sub

    Dim da As SqlDataAdapter
    Dim conn As SqlConnection
    Dim cb As SqlCommandBuilder

    Private Sub Generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Generate.Click
        conn = New SqlConnection("Data Source=Servername;Initial Catalog=mydb;Integrated Security=True")
        Dim sel As String = "SELECT * FROM myTable"
        da = New SqlDataAdapter(sel, conn)
        cb = New SqlCommandBuilder(da)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        da.Fill(ds2, "myTable")
        'Me.DataGridView1.DataSource = ds2
        'Me.DataGridView1.DataMember = "myTable"
    End Sub

    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export.Click
        For Each dr As DataRow In ds1.Tables(0).Rows
            Dim expression As String
            expression = "myId =" + CType(dr.Item(0), Integer).ToString
            Dim drs() As DataRow = ds2.Tables(0).Select(expression)
            If (drs.Length = 1) Then
                For i As Integer = 1 To ds2.Tables(0).Columns.Count - 1
                    drs(0).Item(i) = dr.Item(i)
                Next
            Else
                Dim drnew As DataRow = ds2.Tables(0).NewRow
                For i As Integer = 0 To ds2.Tables(0).Columns.Count - 1
                    drnew.Item(i) = dr.Item(i)
                Next
                ds2.Tables(0).Rows.Add(drnew)
            End If
        Next
        'Me.DataGridView1.DataSource = ds2
        'Me.DataGridView1.DataMember = "myTable"
        da.Update(ds2.Tables(0))
    End Sub
End Class
