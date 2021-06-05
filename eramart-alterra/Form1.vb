Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Collections.Specialized
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paramBody As New Dictionary(Of String, String)
        paramBody.Add("customer_number", "01428800700")
        paramBody.Add("product_id", "25")
        Dim params As String = String.Join("&", paramBody.Select(Function(pair) String.Format("{0}={1}", pair.Key, pair.Value)).ToArray())
        Dim data = Encoding.UTF8.GetBytes(params)
        Dim uri As Uri = New Uri(Module1.apiUri & "/inquireElectricity")
        Dim result_post As String
        Try
            result_post = SendRequest(uri, data, "application/x-www-form-urlencoded", "POST")
            Dim json As JObject = JObject.Parse(result_post)
            MsgBox(json.GetValue("pln_refno"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'connect db

        'Dim cmd As SqlCommand = New SqlCommand("select top 10 * from DIV", con)
        'Dim sda As New SqlDataAdapter(cmd)
        'Dim dt As New DataTable
        'sda.Fill(dt)
        'DataGridView1.DataSource = dt
        Module1.con.Open()
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO SN(BARA) VALUES (@BARA)", Module1.con)
        cmd.Parameters.AddWithValue("@BARA", "HENLO")
        cmd.ExecuteNonQuery()
        Module1.con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As SqlCommand = New SqlCommand("select top 10 * from DIV", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
