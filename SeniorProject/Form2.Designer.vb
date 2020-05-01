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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceivingScheduleDataSet2 = New SeniorProject.ReceivingScheduleDataSet()
        Me.T_ReceivingScheduleTableAdapter2 = New SeniorProject.ReceivingScheduleDataSetTableAdapters.T_ReceivingScheduleTableAdapter()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivingScheduleDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DataGridView2.DataSource = Me.BindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(8, 14)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(757, 308)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Department"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Department"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Carrier"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Carrier"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Container#"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Container#"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ContainerStatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ContainerStatus"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ScheduleDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ScheduleDate"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ArrivalDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ArrivalDate"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DateCompleted"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DateCompleted"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "T_ReceivingSchedule"
        Me.BindingSource1.DataSource = Me.ReceivingScheduleDataSet2
        '
        'ReceivingScheduleDataSet2
        '
        Me.ReceivingScheduleDataSet2.DataSetName = "ReceivingScheduleDataSet"
        Me.ReceivingScheduleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_ReceivingScheduleTableAdapter2
        '
        Me.T_ReceivingScheduleTableAdapter2.ClearBeforeFill = True
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "Department", True))
        Me.TextBox11.Location = New System.Drawing.Point(144, 16)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(126, 26)
        Me.TextBox11.TabIndex = 1
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "T_ReceivingSchedule"
        Me.BindingSource2.DataSource = Me.ReceivingScheduleDataSet2
        '
        'TextBox12
        '
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "Username", True))
        Me.TextBox12.Location = New System.Drawing.Point(144, 61)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(126, 26)
        Me.TextBox12.TabIndex = 2
        '
        'TextBox13
        '
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "Carrier", True))
        Me.TextBox13.Location = New System.Drawing.Point(144, 106)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(126, 26)
        Me.TextBox13.TabIndex = 3
        '
        'TextBox14
        '
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "Container#", True))
        Me.TextBox14.Location = New System.Drawing.Point(144, 153)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(126, 26)
        Me.TextBox14.TabIndex = 4
        '
        'TextBox15
        '
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "ContainerStatus", True))
        Me.TextBox15.Location = New System.Drawing.Point(144, 198)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(126, 26)
        Me.TextBox15.TabIndex = 5
        '
        'TextBox16
        '
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "ScheduleDate", True))
        Me.TextBox16.Location = New System.Drawing.Point(392, 19)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(126, 26)
        Me.TextBox16.TabIndex = 6
        '
        'TextBox17
        '
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "ArrivalDate", True))
        Me.TextBox17.Location = New System.Drawing.Point(392, 61)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(126, 26)
        Me.TextBox17.TabIndex = 7
        '
        'TextBox18
        '
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "Location", True))
        Me.TextBox18.Location = New System.Drawing.Point(392, 103)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(126, 26)
        Me.TextBox18.TabIndex = 8
        '
        'TextBox19
        '
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "DateCompleted", True))
        Me.TextBox19.Location = New System.Drawing.Point(392, 150)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(126, 26)
        Me.TextBox19.TabIndex = 9
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "Comments", True))
        Me.TextBox20.Location = New System.Drawing.Point(392, 198)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(249, 68)
        Me.TextBox20.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(1, -1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(789, 129)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Receiving Schedule"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Desktop
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(177, 117)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Department:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Username:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 20)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Carrier:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Container #:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 20)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Container Status:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(276, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 20)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Schedule Date:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 20)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Arrival Date:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(276, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 20)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Location:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(276, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Date Complete: "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(276, 195)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 20)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Comments:"
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(534, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 41)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "New"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(534, 71)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 40)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Next"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(534, 126)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(107, 35)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Save"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(649, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(109, 41)
        Me.Button10.TabIndex = 26
        Me.Button10.Text = "Delete"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(649, 71)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(110, 39)
        Me.Button11.TabIndex = 27
        Me.Button11.Text = "Previous"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(647, 126)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(112, 36)
        Me.Button12.TabIndex = 28
        Me.Button12.Text = "Close"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBox20)
        Me.GroupBox2.Controls.Add(Me.TextBox19)
        Me.GroupBox2.Controls.Add(Me.TextBox18)
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 280)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(276, 150)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(124, 20)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "Date Complete: "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(276, 103)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 20)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Location:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(276, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 20)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Arrival Date:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(276, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(119, 20)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Schedule Date:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(276, 195)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 20)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Comments:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 334)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(788, 822)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Receiving Schedule"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivingScheduleDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ReceivingScheduleDataSet1 As ReceivingScheduleDataSet
    Friend WithEvents T_ReceivingScheduleTableAdapter1 As ReceivingScheduleDataSetTableAdapters.T_ReceivingScheduleTableAdapter
    Friend WithEvents ReceivingScheduleDataSet2 As ReceivingScheduleDataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents T_ReceivingScheduleTableAdapter2 As ReceivingScheduleDataSetTableAdapters.T_ReceivingScheduleTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BindingSource2 As BindingSource
End Class
