Public Class frmAddRecords

    Private Sub RecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CameraDatabaseDataSet.Records' table. You can move, or remove it, as needed.
        Me.RecordsTableAdapter.Fill(Me.CameraDatabaseDataSet.Records)
        Position()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        RecordsBindingSource.MoveFirst()
        Position()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        RecordsBindingSource.MoveLast()
        Position()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        RecordsBindingSource.MovePrevious()
        Position()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        RecordsBindingSource.MoveNext()
        Position()
    End Sub

    Private Sub Position()
        txtCount.Text = ((RecordsBindingSource.Position + 1) & " of " & RecordsBindingSource.Count)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.RecordsTableAdapter.Update(Me.CameraDatabaseDataSet.Records)
    End Sub
End Class