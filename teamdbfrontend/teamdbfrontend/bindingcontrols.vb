﻿Public Class Frm_BindingControls

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamDatabaseDataSet)

    End Sub

    Private Sub Frm_BindingControls_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamDatabaseDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.TeamDatabaseDataSet.Members)

    End Sub


End Class