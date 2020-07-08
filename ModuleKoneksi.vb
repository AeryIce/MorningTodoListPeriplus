Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet
	Public Cmd As SqlCommand


	Sub KoneksiInvUser()
		Try
			Conn = New SqlConnection("Data source=NUNU-PC\SQLEXPRESS; Initial Catalog=INV; Integrated Security = True")
			Conn.Open()
			FormLogin.LabelStatus.Text = "Connected"
		Catch ex As Exception
			FormLogin.LabelStatus.Text = "Not Connected"

		End Try

	End Sub

End Module
