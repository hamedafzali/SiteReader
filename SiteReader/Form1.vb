Imports System.Data.OleDb

Public Class Form1
    Public sm As String
    Dim ConnString As String = _
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SiteReader\SiteRaderDB.accdb"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHorizon.Text = "horizon.elcampus.ch"

        txtTag.Text = "div"
        txtTagType.Text = "classname"
        txtTagTypeValue.Text = "content"
        FillGrid()

    End Sub

    Private Sub txtShow_Click(sender As Object, e As EventArgs) Handles txtShow.Click
        WebBrowser1.Navigate(txtHorizon.Text)
    End Sub

    Private Sub txtShowContent_Click(sender As Object, e As EventArgs) Handles txtShowContent.Click
        Try
            Dim name As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName(txtTag.Text)
            For Each elem As HtmlElement In name
                If elem.GetAttribute(txtTagType.Text).Contains(txtTagTypeValue.Text) Then
                    txtContent.Text = txtContent.Text + vbCrLf + elem.InnerText
                End If
            Next
        Catch ex As Exception
            MsgBox("No Content")
        End Try

    End Sub

    Private Sub txtSave_Click(sender As Object, e As EventArgs) Handles txtSave.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            sqlconn.ConnectionString = ConnString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO tblContent(ContentValue)VALUES(@ContentValue)"
            sqlquery.Parameters.AddWithValue("@ContentValue", txtContent.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            FillGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtKeyword_TextChanged(sender As Object, e As EventArgs) Handles txtKeyword.TextChanged
        FillGrid()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'MsgBox(DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        'My.Resources.Content = DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
        sm = DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
        Dim a As New ShowContent
        a.ShowDialog()
    End Sub
    Function FillGrid()

        Dim MyConn As OleDbConnection
        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource
        MyConn = New OleDbConnection
        MyConn.ConnectionString = ConnString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [tblContent] where ContentValue like'%" + txtKeyword.Text + "%'", MyConn) 'Change items to your database name
        da.Fill(ds, "tblContent") 'Change items to your database name
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Function
End Class
