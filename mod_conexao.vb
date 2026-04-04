Imports ADODB

Module mod_conexao
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Sub Conectar_Banco()
        Try
            db.Open("Provider=SQLOLEDB;Data Source=PCZIN\SQLEXPRESS01;Initial Catalog=db_manutencao;Integrated Security=SSPI;")
            MsgBox("Banco de Manutenção Conectado com Sucesso!", MsgBoxStyle.Information, "Status")
        Catch ex As Exception
            MsgBox("Erro ao conectar ao SQL Server: " & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
End Module