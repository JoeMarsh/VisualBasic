Imports System.Data.SqlClient

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\CameraDatabase.mdf;Integrated Security=True")
            Try
                con.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim query As String

            query = "SELECT * FROM Records"
            Try
                Using da As New SqlDataAdapter(query, con)
                    Dim dsd As New CameraDatabaseDataSet
                    'Dim ds As New DataSet
                    Dim dt As DataTable = New DataTable
                    da.MissingSchemaAction = MissingSchemaAction.AddWithKey
                    da.Fill(dsd, "Records")
                    'dt = dsd.Records
                    'dsd.Records.AddRecordsRow(Nothing, Nothing, Nothing, Nothing, Nothing)
                    DataGridView1.DataSource = dsd.Records

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub
End Class