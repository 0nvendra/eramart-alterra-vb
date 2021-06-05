Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Data.SqlClient

Module Module1
    Public baseUri = "https://alterra.eramart.co.id"
    Public apiUri = baseUri & "/api"
    Public con As SqlConnection = New SqlConnection("Data Source=192.168.3.224;Initial Catalog=POS;User ID=sa;Password=ErA0123456789")
    Public Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim response As String
        Dim request As WebRequest
        'Console.WriteLine(jsonDataBytes)

        request = WebRequest.Create(uri)
        request.ContentLength = jsonDataBytes.Length
        request.ContentType = contentType
        request.Method = method

        Using requestStream = request.GetRequestStream
            requestStream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
            requestStream.Close()
            Using responseStream = request.GetResponse.GetResponseStream
                Using reader As New StreamReader(responseStream)
                    response = reader.ReadToEnd()
                End Using
            End Using
        End Using

        Return response
    End Function
End Module
