<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HomePage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.YardLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContainerStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEntered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYardStatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceivingScheduleDataSet21 = New SeniorProject.ReceivingScheduleDataSet2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TYardStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_YardStatusTableAdapter = New SeniorProject.ReceivingScheduleDataSet2TableAdapters.T_YardStatusTableAdapter()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYardStatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivingScheduleDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYardStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Yard Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HomePage
        '
        Me.HomePage.BackColor = System.Drawing.SystemColors.Desktop
        Me.HomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomePage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomePage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HomePage.Location = New System.Drawing.Point(-8, -1)
        Me.HomePage.Name = "HomePage"
        Me.HomePage.Size = New System.Drawing.Size(955, 129)
        Me.HomePage.TabIndex = 29
        Me.HomePage.Text = "Yard Management System"
        Me.HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 129)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 38)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 434)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YardLocationDataGridViewTextBoxColumn, Me.ContainerStatusDataGridViewTextBoxColumn, Me.Username, Me.DateEntered})
        Me.DataGridView1.DataSource = Me.TYardStatusBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(763, 395)
        Me.DataGridView1.TabIndex = 0
        '
        'YardLocationDataGridViewTextBoxColumn
        '
        Me.YardLocationDataGridViewTextBoxColumn.DataPropertyName = "YardLocation"
        Me.YardLocationDataGridViewTextBoxColumn.HeaderText = "YardLocation"
        Me.YardLocationDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.YardLocationDataGridViewTextBoxColumn.Name = "YardLocationDataGridViewTextBoxColumn"
        Me.YardLocationDataGridViewTextBoxColumn.Width = 150
        '
        'ContainerStatusDataGridViewTextBoxColumn
        '
        Me.ContainerStatusDataGridViewTextBoxColumn.DataPropertyName = "ContainerStatus"
        Me.ContainerStatusDataGridViewTextBoxColumn.HeaderText = "ContainerStatus"
        Me.ContainerStatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ContainerStatusDataGridViewTextBoxColumn.Name = "ContainerStatusDataGridViewTextBoxColumn"
        Me.ContainerStatusDataGridViewTextBoxColumn.Width = 150
        '
        'Username
        '
        Me.Username.DataPropertyName = "Username"
        Me.Username.HeaderText = "Username"
        Me.Username.MinimumWidth = 8
        Me.Username.Name = "Username"
        Me.Username.Width = 150
        '
        'DateEntered
        '
        Me.DateEntered.DataPropertyName = "DateEntered"
        Me.DateEntered.HeaderText = "DateEntered"
        Me.DateEntered.MinimumWidth = 8
        Me.DateEntered.Name = "DateEntered"
        Me.DateEntered.Width = 150
        '
        'TYardStatusBindingSource1
        '
        Me.TYardStatusBindingSource1.DataMember = "T_YardStatus"
        Me.TYardStatusBindingSource1.DataSource = Me.ReceivingScheduleDataSet21
        '
        'ReceivingScheduleDataSet21
        '
        Me.ReceivingScheduleDataSet21.DataSetName = "ReceivingScheduleDataSet2"
        Me.ReceivingScheduleDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TYardStatusBindingSource1, "ContainerStatus", True))
        Me.TextBox1.Location = New System.Drawing.Point(189, 275)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 26)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TYardStatusBindingSource1, "Username", True))
        Me.TextBox2.Location = New System.Drawing.Point(189, 307)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 26)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TYardStatusBindingSource1, "DateEntered", True))
        Me.TextBox3.Location = New System.Drawing.Point(189, 339)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(115, 26)
        Me.TextBox3.TabIndex = 35
        '
        'TYardStatusBindingSource
        '
        Me.TYardStatusBindingSource.DataMember = "T_YardStatus"
        Me.TYardStatusBindingSource.DataSource = Me.ReceivingScheduleDataSet21
        '
        'T_YardStatusTableAdapter
        '
        Me.T_YardStatusTableAdapter.ClearBeforeFill = True
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TYardStatusBindingSource1, "YardLocation", True))
        Me.TextBox4.Location = New System.Drawing.Point(189, 241)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(115, 26)
        Me.TextBox4.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "View or Edit the Yard Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Yard Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Username:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Container Status:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 25)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Date Entered:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(341, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 38)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(477, 240)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 38)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(477, 301)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 38)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "Previous"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(615, 241)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 38)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(615, 301)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 38)
        Me.Button7.TabIndex = 47
        Me.Button7.Text = "Close"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 813)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HomePage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Form4"
        Me.Text = "Yard Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYardStatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivingScheduleDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYardStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents HomePage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReceivingScheduleDataSet21 As ReceivingScheduleDataSet2
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TYardStatusBindingSource As BindingSource
    Friend WithEvents T_YardStatusTableAdapter As ReceivingScheduleDataSet2TableAdapters.T_YardStatusTableAdapter
    Friend WithEvents YardLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContainerStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents DateEntered As DataGridViewTextBoxColumn
    Friend WithEvents TYardStatusBindingSource1 As BindingSource
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
