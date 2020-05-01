Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet21.T_YardStatus' table. You can move, or remove it, as needed.
        Me.T_YardStatusTableAdapter.Fill(Me.ReceivingScheduleDataSet21.T_YardStatus)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TYardStatusBindingSource1.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TYardStatusBindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TYardStatusBindingSource1.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TYardStatusBindingSource1.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TYardStatusBindingSource1.EndEdit()
        T_YardStatusTableAdapter.Update(ReceivingScheduleDataSet21.T_YardStatus)
    End Sub


End Class