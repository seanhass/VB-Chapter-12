Public Class frm_Main

    Private Sub btn_DataView_Click(sender As System.Object, e As System.EventArgs) Handles btn_DataView.Click
        frm_DataGridView.ShowDialog()
    End Sub

    
    Private Sub btn_BindingControls_Click(sender As System.Object, e As System.EventArgs) Handles btn_BindingControls.Click
        Frm_BindingControls.ShowDialog()
    End Sub
End Class