<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.YardLocationToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.YardLocationToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.YardLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContainerStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEnteredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TYardStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceivingScheduleDataSet5 = New SeniorProject.ReceivingScheduleDataSet5()
        Me.T_YardStatusTableAdapter = New SeniorProject.ReceivingScheduleDataSet5TableAdapters.T_YardStatusTableAdapter()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.TYardStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivingScheduleDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.AutoGenerateColumns = False
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YardLocationDataGridViewTextBoxColumn, Me.ContainerStatusDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.DateEnteredDataGridViewTextBoxColumn})
        Me.dgvData.DataSource = Me.TYardStatusBindingSource
        Me.dgvData.Location = New System.Drawing.Point(22, 68)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 62
        Me.dgvData.RowTemplate.Height = 28
        Me.dgvData.Size = New System.Drawing.Size(871, 512)
        Me.dgvData.TabIndex = 0
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YardLocationToolStripLabel, Me.YardLocationToolStripTextBox, Me.FillByToolStripButton, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(923, 37)
        Me.FillByToolStrip.TabIndex = 4
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'YardLocationToolStripLabel
        '
        Me.YardLocationToolStripLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YardLocationToolStripLabel.Name = "YardLocationToolStripLabel"
        Me.YardLocationToolStripLabel.Size = New System.Drawing.Size(162, 32)
        Me.YardLocationToolStripLabel.Text = "Yard Location:"
        '
        'YardLocationToolStripTextBox
        '
        Me.YardLocationToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.YardLocationToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.YardLocationToolStripTextBox.Name = "YardLocationToolStripTextBox"
        Me.YardLocationToolStripTextBox.Size = New System.Drawing.Size(100, 37)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(74, 32)
        Me.FillByToolStripButton.Text = "Search"
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
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 150
        '
        'DateEnteredDataGridViewTextBoxColumn
        '
        Me.DateEnteredDataGridViewTextBoxColumn.DataPropertyName = "DateEntered"
        Me.DateEnteredDataGridViewTextBoxColumn.HeaderText = "DateEntered"
        Me.DateEnteredDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DateEnteredDataGridViewTextBoxColumn.Name = "DateEnteredDataGridViewTextBoxColumn"
        Me.DateEnteredDataGridViewTextBoxColumn.Width = 150
        '
        'TYardStatusBindingSource
        '
        Me.TYardStatusBindingSource.DataMember = "T_YardStatus"
        Me.TYardStatusBindingSource.DataSource = Me.ReceivingScheduleDataSet5
        '
        'ReceivingScheduleDataSet5
        '
        Me.ReceivingScheduleDataSet5.DataSetName = "ReceivingScheduleDataSet5"
        Me.ReceivingScheduleDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_YardStatusTableAdapter
        '
        Me.T_YardStatusTableAdapter.ClearBeforeFill = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 32)
        Me.ToolStripButton1.Text = "Close"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(85, 32)
        Me.ToolStripButton2.Text = "Show All"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 604)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "Form6"
        Me.Text = "Yard Status"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.TYardStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivingScheduleDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents ReceivingScheduleDataSet5 As ReceivingScheduleDataSet5
    Friend WithEvents TYardStatusBindingSource As BindingSource
    Friend WithEvents T_YardStatusTableAdapter As ReceivingScheduleDataSet5TableAdapters.T_YardStatusTableAdapter
    Friend WithEvents YardLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContainerStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateEnteredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents YardLocationToolStripLabel As ToolStripLabel
    Friend WithEvents YardLocationToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
