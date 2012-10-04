<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BindingControls
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim TeamGoalLabel As System.Windows.Forms.Label
        Dim MISInterestLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BindingControls))
        Dim BackgroundLabel As System.Windows.Forms.Label
        Dim HobbiesLabel As System.Windows.Forms.Label
        Dim WorkHistoryLabel As System.Windows.Forms.Label
        Me.TeamDatabaseDataSet = New teamdbfrontend.TeamDatabaseDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New teamdbfrontend.TeamDatabaseDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New teamdbfrontend.TeamDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.MembersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MembersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.TeamGoalTextBox = New System.Windows.Forms.TextBox()
        Me.MISInterestCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackgroundTextBox = New System.Windows.Forms.TextBox()
        Me.HobbiesTextBox = New System.Windows.Forms.TextBox()
        Me.WorkHistoryTextBox = New System.Windows.Forms.TextBox()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        TeamGoalLabel = New System.Windows.Forms.Label()
        MISInterestLabel = New System.Windows.Forms.Label()
        BackgroundLabel = New System.Windows.Forms.Label()
        HobbiesLabel = New System.Windows.Forms.Label()
        WorkHistoryLabel = New System.Windows.Forms.Label()
        CType(Me.TeamDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MembersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 34)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 1
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(11, 60)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 87)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(11, 112)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 7
        PhoneLabel.Text = "Phone:"
        '
        'TeamGoalLabel
        '
        TeamGoalLabel.AutoSize = True
        TeamGoalLabel.Location = New System.Drawing.Point(10, 139)
        TeamGoalLabel.Name = "TeamGoalLabel"
        TeamGoalLabel.Size = New System.Drawing.Size(62, 13)
        TeamGoalLabel.TabIndex = 15
        TeamGoalLabel.Text = "Team Goal:"
        '
        'MISInterestLabel
        '
        MISInterestLabel.AutoSize = True
        MISInterestLabel.Location = New System.Drawing.Point(204, 31)
        MISInterestLabel.Name = "MISInterestLabel"
        MISInterestLabel.Size = New System.Drawing.Size(64, 13)
        MISInterestLabel.TabIndex = 17
        MISInterestLabel.Text = "MISInterest:"
        '
        'TeamDatabaseDataSet
        '
        Me.TeamDatabaseDataSet.DataSetName = "TeamDatabaseDataSet"
        Me.TeamDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.TeamDatabaseDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.Switchboard_ItemsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = teamdbfrontend.TeamDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MembersBindingNavigator
        '
        Me.MembersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MembersBindingNavigator.BindingSource = Me.MembersBindingSource
        Me.MembersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MembersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MembersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MembersBindingNavigatorSaveItem})
        Me.MembersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MembersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MembersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MembersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MembersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MembersBindingNavigator.Name = "MembersBindingNavigator"
        Me.MembersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MembersBindingNavigator.Size = New System.Drawing.Size(451, 25)
        Me.MembersBindingNavigator.TabIndex = 0
        Me.MembersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MembersBindingNavigatorSaveItem
        '
        Me.MembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MembersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MembersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MembersBindingNavigatorSaveItem.Name = "MembersBindingNavigatorSaveItem"
        Me.MembersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MembersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(78, 31)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(78, 57)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(78, 83)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(78, 109)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 8
        '
        'TeamGoalTextBox
        '
        Me.TeamGoalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "TeamGoal", True))
        Me.TeamGoalTextBox.Location = New System.Drawing.Point(78, 136)
        Me.TeamGoalTextBox.Name = "TeamGoalTextBox"
        Me.TeamGoalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TeamGoalTextBox.TabIndex = 16
        '
        'MISInterestCheckBox
        '
        Me.MISInterestCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "MISInterest", True))
        Me.MISInterestCheckBox.Location = New System.Drawing.Point(278, 26)
        Me.MISInterestCheckBox.Name = "MISInterestCheckBox"
        Me.MISInterestCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.MISInterestCheckBox.TabIndex = 18
        Me.MISInterestCheckBox.UseVisualStyleBackColor = True
        '
        'BackgroundLabel
        '
        BackgroundLabel.AutoSize = True
        BackgroundLabel.Location = New System.Drawing.Point(204, 59)
        BackgroundLabel.Name = "BackgroundLabel"
        BackgroundLabel.Size = New System.Drawing.Size(68, 13)
        BackgroundLabel.TabIndex = 22
        BackgroundLabel.Text = "Background:"
        '
        'BackgroundTextBox
        '
        Me.BackgroundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Background", True))
        Me.BackgroundTextBox.Location = New System.Drawing.Point(278, 56)
        Me.BackgroundTextBox.Name = "BackgroundTextBox"
        Me.BackgroundTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackgroundTextBox.TabIndex = 23
        '
        'HobbiesLabel
        '
        HobbiesLabel.AutoSize = True
        HobbiesLabel.Location = New System.Drawing.Point(204, 85)
        HobbiesLabel.Name = "HobbiesLabel"
        HobbiesLabel.Size = New System.Drawing.Size(49, 13)
        HobbiesLabel.TabIndex = 23
        HobbiesLabel.Text = "Hobbies:"
        '
        'HobbiesTextBox
        '
        Me.HobbiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Hobbies", True))
        Me.HobbiesTextBox.Location = New System.Drawing.Point(278, 82)
        Me.HobbiesTextBox.Name = "HobbiesTextBox"
        Me.HobbiesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HobbiesTextBox.TabIndex = 24
        '
        'WorkHistoryLabel
        '
        WorkHistoryLabel.AutoSize = True
        WorkHistoryLabel.Location = New System.Drawing.Point(201, 112)
        WorkHistoryLabel.Name = "WorkHistoryLabel"
        WorkHistoryLabel.Size = New System.Drawing.Size(71, 13)
        WorkHistoryLabel.TabIndex = 24
        WorkHistoryLabel.Text = "Work History:"
        '
        'WorkHistoryTextBox
        '
        Me.WorkHistoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "WorkHistory", True))
        Me.WorkHistoryTextBox.Location = New System.Drawing.Point(278, 109)
        Me.WorkHistoryTextBox.Name = "WorkHistoryTextBox"
        Me.WorkHistoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WorkHistoryTextBox.TabIndex = 25
        '
        'Frm_BindingControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 173)
        Me.Controls.Add(WorkHistoryLabel)
        Me.Controls.Add(Me.WorkHistoryTextBox)
        Me.Controls.Add(HobbiesLabel)
        Me.Controls.Add(Me.HobbiesTextBox)
        Me.Controls.Add(BackgroundLabel)
        Me.Controls.Add(Me.BackgroundTextBox)
        Me.Controls.Add(MISInterestLabel)
        Me.Controls.Add(Me.MISInterestCheckBox)
        Me.Controls.Add(TeamGoalLabel)
        Me.Controls.Add(Me.TeamGoalTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.MembersBindingNavigator)
        Me.Name = "Frm_BindingControls"
        Me.Text = "Binding Controls"
        CType(Me.TeamDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MembersBindingNavigator.ResumeLayout(False)
        Me.MembersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TeamDatabaseDataSet As teamdbfrontend.TeamDatabaseDataSet
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As teamdbfrontend.TeamDatabaseDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As teamdbfrontend.TeamDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MembersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MembersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeamGoalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MISInterestCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HobbiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WorkHistoryTextBox As System.Windows.Forms.TextBox
End Class
