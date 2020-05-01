Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceivingScheduleDataSet11.T_ShippingSchedule' table. You can move, or remove it, as needed.
        Me.T_ShippingScheduleTableAdapter3.Fill(Me.ReceivingScheduleDataSet11.T_ShippingSchedule)



    End Sub

    Private Sub HomePage_Click(sender As Object, e As EventArgs) Handles HomePage.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TShippingScheduleBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TShippingScheduleBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TShippingScheduleBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TShippingScheduleBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TShippingScheduleBindingSource.EndEdit()
        T_ShippingScheduleTableAdapter3.Update(ReceivingScheduleDataSet11.T_ShippingSchedule)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub


End Class