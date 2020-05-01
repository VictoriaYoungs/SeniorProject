Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet5.T_YardStatus' table. You can move, or remove it, as needed.
        Me.T_YardStatusTableAdapter.Fill(Me.ReceivingScheduleDataSet5.T_YardStatus)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.T_YardStatusTableAdapter.FillBy(Me.ReceivingScheduleDataSet5.T_YardStatus, YardLocationToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowAllToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.T_YardStatusTableAdapter.ShowAll(Me.ReceivingScheduleDataSet5.T_YardStatus)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Me.T_YardStatusTableAdapter.ShowAll(Me.ReceivingScheduleDataSet5.T_YardStatus)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class