Public Class frmAddRecords

    Private Sub RecordsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)

    End Sub


    Private Sub RecordsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)

    End Sub


    Private Sub RecordsBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)

    End Sub


    Private Sub RecordsBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)

    End Sub


    Private Sub RecordsBindingNavigatorSaveItem_Click_4(sender As Object, e As EventArgs) Handles RecordsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RecordsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CameraDatabaseDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CameraDatabaseDataSet.Records' table. You can move, or remove it, as needed.
        Me.RecordsTableAdapter.Fill(Me.CameraDatabaseDataSet.Records)

    End Sub
End Class