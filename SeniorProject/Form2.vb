Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet2.T_ReceivingSchedule' table. You can move, or remove it, as needed.
        Me.T_ReceivingScheduleTableAdapter2.Fill(Me.ReceivingScheduleDataSet2.T_ReceivingSchedule)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BindingSource2.AddNew()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        BindingSource2.RemoveCurrent()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BindingSource2.MoveNext()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        BindingSource2.MovePrevious()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BindingSource2.EndEdit()
        T_ReceivingScheduleTableAdapter2.Update(ReceivingScheduleDataSet2.T_ReceivingSchedule)
    End Sub
End Class