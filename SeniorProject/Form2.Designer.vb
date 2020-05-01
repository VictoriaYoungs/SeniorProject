<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarrierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContainerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContainerStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrivalDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCompletedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TReceivingScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceivingScheduleDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceivingScheduleDataSet = New SeniorProject.ReceivingScheduleDataSet()
        Me.T_ReceivingScheduleTableAdapter = New SeniorProject.ReceivingScheduleDataSetTableAdapters.T_ReceivingScheduleTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New SeniorProject.ReceivingScheduleDataSetTableAdapters.TableAdapterManager()
        Me.HomePage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TReceivingScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivingScheduleDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivingScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.CarrierDataGridViewTextBoxColumn, Me.ContainerDataGridViewTextBoxColumn, Me.ContainerStatusDataGridViewTextBoxColumn, Me.ScheduleDateDataGridViewTextBoxColumn, Me.ArrivalDateDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.DateCompletedDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TReceivingScheduleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 419)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(861, 345)
        Me.DataGridView1.TabIndex = 0
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.Width = 150
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 150
        '
        'CarrierDataGridViewTextBoxColumn
        '
        Me.CarrierDataGridViewTextBoxColumn.DataPropertyName = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.HeaderText = "Carrier"
        Me.CarrierDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CarrierDataGridViewTextBoxColumn.Name = "CarrierDataGridViewTextBoxColumn"
        Me.CarrierDataGridViewTextBoxColumn.Width = 150
        '
        'ContainerDataGridViewTextBoxColumn
        '
        Me.ContainerDataGridViewTextBoxColumn.DataPropertyName = "Container#"
        Me.ContainerDataGridViewTextBoxColumn.HeaderText = "Container#"
        Me.ContainerDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContainerDataGridViewTextBoxColumn.Name = "ContainerDataGridViewTextBoxColumn"
        Me.ContainerDataGridViewTextBoxColumn.Width = 150
        '
        'ContainerStatusDataGridViewTextBoxColumn
        '
        Me.ContainerStatusDataGridViewTextBoxColumn.DataPropertyName = "ContainerStatus"
        Me.ContainerStatusDataGridViewTextBoxColumn.HeaderText = "ContainerStatus"
        Me.ContainerStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContainerStatusDataGridViewTextBoxColumn.Name = "ContainerStatusDataGridViewTextBoxColumn"
        Me.ContainerStatusDataGridViewTextBoxColumn.Width = 150
        '
        'ScheduleDateDataGridViewTextBoxColumn
        '
        Me.ScheduleDateDataGridViewTextBoxColumn.DataPropertyName = "ScheduleDate"
        Me.ScheduleDateDataGridViewTextBoxColumn.HeaderText = "ScheduleDate"
        Me.ScheduleDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ScheduleDateDataGridViewTextBoxColumn.Name = "ScheduleDateDataGridViewTextBoxColumn"
        Me.ScheduleDateDataGridViewTextBoxColumn.Width = 150
        '
        'ArrivalDateDataGridViewTextBoxColumn
        '
        Me.ArrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate"
        Me.ArrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate"
        Me.ArrivalDateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ArrivalDateDataGridViewTextBoxColumn.Name = "ArrivalDateDataGridViewTextBoxColumn"
        Me.ArrivalDateDataGridViewTextBoxColumn.Width = 150
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.Width = 150
        '
        'DateCompletedDataGridViewTextBoxColumn
        '
        Me.DateCompletedDataGridViewTextBoxColumn.DataPropertyName = "DateCompleted"
        Me.DateCompletedDataGridViewTextBoxColumn.HeaderText = "DateCompleted"
        Me.DateCompletedDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateCompletedDataGridViewTextBoxColumn.Name = "DateCompletedDataGridViewTextBoxColumn"
        Me.DateCompletedDataGridViewTextBoxColumn.Width = 150
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.Width = 150
        '
        'TReceivingScheduleBindingSource
        '
        Me.TReceivingScheduleBindingSource.DataMember = "T_ReceivingSchedule"
        Me.TReceivingScheduleBindingSource.DataSource = Me.ReceivingScheduleDataSetBindingSource
        '
        'ReceivingScheduleDataSetBindingSource
        '
        Me.ReceivingScheduleDataSetBindingSource.DataSource = Me.ReceivingScheduleDataSet
        Me.ReceivingScheduleDataSetBindingSource.Position = 0
        '
        'ReceivingScheduleDataSet
        '
        Me.ReceivingScheduleDataSet.DataSetName = "ReceivingScheduleDataSet"
        Me.ReceivingScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_ReceivingScheduleTableAdapter
        '
        Me.T_ReceivingScheduleTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Carrier:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "Carrier", True))
        Me.TextBox1.Location = New System.Drawing.Point(160, 239)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Container #:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "Container#", True))
        Me.TextBox2.Location = New System.Drawing.Point(160, 281)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 26)
        Me.TextBox2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Container Status:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "ContainerStatus", True))
        Me.TextBox3.Location = New System.Drawing.Point(160, 325)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 26)
        Me.TextBox3.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Schedule Date:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "ScheduleDate", True))
        Me.TextBox4.Location = New System.Drawing.Point(439, 154)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 26)
        Me.TextBox4.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Comments:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "Comments", True))
        Me.TextBox5.Location = New System.Drawing.Point(439, 325)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(274, 62)
        Me.TextBox5.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Date Completed:"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "DateCompleted", True))
        Me.TextBox6.Location = New System.Drawing.Point(439, 284)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(138, 26)
        Me.TextBox6.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(306, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Location:"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "Location", True))
        Me.TextBox7.Location = New System.Drawing.Point(439, 242)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(138, 26)
        Me.TextBox7.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Arrival Date:"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "ArrivalDate", True))
        Me.TextBox8.Location = New System.Drawing.Point(439, 199)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(138, 26)
        Me.TextBox8.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(610, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(756, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 35)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(610, 154)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 35)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "New"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(610, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 33)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Previous"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "Department", True))
        Me.TextBox9.Location = New System.Drawing.Point(160, 154)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(138, 26)
        Me.TextBox9.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Department:"
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TReceivingScheduleBindingSource, "Username", True))
        Me.TextBox10.Location = New System.Drawing.Point(160, 196)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(138, 26)
        Me.TextBox10.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Username:"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(756, 211)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 35)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Next"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(756, 154)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 35)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.T_ReceivingScheduleTableAdapter = Me.T_ReceivingScheduleTableAdapter
        Me.TableAdapterManager1.UpdateOrder = SeniorProject.ReceivingScheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HomePage
        '
        Me.HomePage.BackColor = System.Drawing.SystemColors.Desktop
        Me.HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomePage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HomePage.Location = New System.Drawing.Point(45, -2)
        Me.HomePage.Name = "HomePage"
        Me.HomePage.Size = New System.Drawing.Size(854, 129)
        Me.HomePage.TabIndex = 27
        Me.HomePage.Text = "Receiving Schedule"
        Me.HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 129)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(906, 821)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HomePage)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Receiving Schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TReceivingScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivingScheduleDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivingScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReceivingScheduleDataSetBindingSource As BindingSource
    Friend WithEvents ReceivingScheduleDataSet As ReceivingScheduleDataSet
    Friend WithEvents TReceivingScheduleBindingSource As BindingSource
    Friend WithEvents T_ReceivingScheduleTableAdapter As ReceivingScheduleDataSetTableAdapters.T_ReceivingScheduleTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TableAdapterManager1 As ReceivingScheduleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarrierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContainerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContainerStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduleDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrivalDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateCompletedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomePage As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
