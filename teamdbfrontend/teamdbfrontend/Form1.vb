Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamDatabaseDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.TeamDatabaseDataSet.Members)
        Me.TeamDatabaseDataSet.Members.Columns("TeamMemberID").AutoIncrementSeed = _
        Me.TeamDatabaseDataSet.Members.Max(Function(Row) Row.TeamMemberID) + 1
        Me.TeamDatabaseDataSet.Members.Columns("TeamMemberID").AutoIncrementStep = 1

    End Sub
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamDatabaseDataSet)

    End Sub


End Class
