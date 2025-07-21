Imports MySql.Data.MySqlClient
Public Class My_DB
    ReadOnly Property getConnection() As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=evrpc_db;Convert Zero Datetime=True")


    Sub openConnection()
        If getConnection.State = ConnectionState.Closed Then
            getConnection.Open()
        End If
    End Sub

    Sub closeConnection()
        If getConnection.State = ConnectionState.Open Then
            getConnection.Close()
        End If
    End Sub

End Class
