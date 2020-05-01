Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet4.T_ContainerStatusTypes' table. You can move, or remove it, as needed.
        Me.T_ContainerStatusTypesTableAdapter.Fill(Me.ReceivingScheduleDataSet4.T_ContainerStatusTypes)
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet3.T_YardStatusByLocation' table. You can move, or remove it, as needed.
        Me.T_YardStatusByLocationTableAdapter.Fill(Me.ReceivingScheduleDataSet3.T_YardStatusByLocation)
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet2.T_YardStatus' table. You can move, or remove it, as needed.
        Me.T_YardStatusTableAdapter.Fill(Me.ReceivingScheduleDataSet2.T_YardStatus)

    End Sub

    Private Sub Label110_Click(sender As Object, e As EventArgs) Handles Label110.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TYardStatusByLocationBindingSource.EndEdit()
        T_YardStatusByLocationTableAdapter.Update(ReceivingScheduleDataSet3.T_YardStatusByLocation)
    End Sub
End Class