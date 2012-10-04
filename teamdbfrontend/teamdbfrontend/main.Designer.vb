<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.btn_DataView = New System.Windows.Forms.Button()
        Me.btn_BindingControls = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_DataView
        '
        Me.btn_DataView.Location = New System.Drawing.Point(33, 23)
        Me.btn_DataView.Name = "btn_DataView"
        Me.btn_DataView.Size = New System.Drawing.Size(75, 23)
        Me.btn_DataView.TabIndex = 0
        Me.btn_DataView.Text = "Data View"
        Me.btn_DataView.UseVisualStyleBackColor = True
        '
        'btn_BindingControls
        '
        Me.btn_BindingControls.Location = New System.Drawing.Point(33, 61)
        Me.btn_BindingControls.Name = "btn_BindingControls"
        Me.btn_BindingControls.Size = New System.Drawing.Size(105, 23)
        Me.btn_BindingControls.TabIndex = 1
        Me.btn_BindingControls.Text = "Binding Controls"
        Me.btn_BindingControls.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btn_BindingControls)
        Me.Controls.Add(Me.btn_DataView)
        Me.Name = "frm_Main"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_DataView As System.Windows.Forms.Button
    Friend WithEvents btn_BindingControls As System.Windows.Forms.Button
End Class
