Imports System.Data.SqlClient

Public Class frmSearch
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combCar.SelectedIndex = 0
        combCamera.SelectedIndex = 0
        dgvResults.AllowUserToAddRows = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Using con As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\CameraDatabase.mdf;Integrated Security=True")

            Try
                con.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Dim query As String

            If txtCarInput.Text <> "" And txtCameraInput.Text <> "" Then
                query = String.Format("SELECT * FROM Records WHERE {0} = '{1}' AND {2} LIKE '{3}%'",
                                    combCar.Text, txtCarInput.Text, combCamera.Text, txtCameraInput.Text)
            ElseIf txtCarInput.Text <> "" Then
                query = String.Format("SELECT * FROM Records WHERE {0} = '{1}'", combCar.Text, txtCarInput.Text)
            ElseIf txtCameraInput.Text <> "" Then
                query = String.Format("SELECT * FROM Records WHERE {0} LIKE '{1}%'", combCamera.Text, txtCameraInput.Text)
            Else
                query = "SELECT * FROM Records"
            End If

            Try
                Using da As New SqlDataAdapter(query, con)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    dgvResults.DataSource = dt
                    txtNoRecords.Text = dt.Rows.Count.ToString
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Using

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frm As New frmAddRecords
        frm.Show()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim Form3 As New Form3
        Form3.Show()
    End Sub
End Class
