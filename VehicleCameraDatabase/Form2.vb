Imports System.Text.RegularExpressions

Public Class frmAddRecords

    Private Sub RecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        RecordsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CameraDatabaseDataSet.Records' table. You can move, or remove it, as needed.
        RecordsTableAdapter.Fill(Me.CameraDatabaseDataSet.Records)
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
        RecordsBindingSource.EndEdit()
        RecordsTableAdapter.Update(Me.CameraDatabaseDataSet.Records)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CameraDatabaseDataSet.Records.AddRecordsRow(Nothing, Nothing, Nothing, Nothing, Nothing)
        RecordsBindingSource.MoveLast()
        Position()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CameraDatabaseDataSet.Records.FindById(RecordsBindingSource.Position + 1).Delete()
        Position()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        CameraDatabaseDataSet.RejectChanges()
        RecordsBindingSource.ResetBindings(False)
        Position()
    End Sub

    Private Sub RecordsBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles RecordsBindingSource.CurrentChanged
        Dim current As String

        current = RecordsBindingSource.Current("CameraCode")
        If current = 123 Then
            RadioButton1.Checked = True
        Else
            RadioButton1.Checked = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CarDistrictTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CarDistrictTextBox.Validating
        'If Not Regex.IsMatch(CarDistrictTextBox.Text, "^[a-zA-Z]+\s*$") Then
        '    MessageBox.Show("Please enter letters only")
        'End If
        Dim bool As Boolean
        bool = True
        For i = 0 To CarDistrictTextBox.Text.Length - 1
            If Not Char.IsLetter(CarDistrictTextBox.Text.Chars(i)) Then
                bool = False
            End If
        Next

        If bool Then

        Else
            MessageBox.Show("Please enter letters only")
        End If

    End Sub
End Class