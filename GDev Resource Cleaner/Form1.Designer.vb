<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox_Resources = New System.Windows.Forms.ListBox()
        Me.Button_MoveToRemove = New System.Windows.Forms.Button()
        Me.Button_SelectProjectJSON = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox_UnesedResources = New System.Windows.Forms.ListBox()
        Me.Label_Resources = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_UnesedResources = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox_Resources
        '
        Me.ListBox_Resources.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_Resources.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_Resources.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_Resources.FormattingEnabled = True
        Me.ListBox_Resources.HorizontalScrollbar = True
        Me.ListBox_Resources.Location = New System.Drawing.Point(16, 32)
        Me.ListBox_Resources.Name = "ListBox_Resources"
        Me.ListBox_Resources.Size = New System.Drawing.Size(576, 182)
        Me.ListBox_Resources.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ListBox_Resources, "You can drag drop a project json file here.")
        '
        'Button_MoveToRemove
        '
        Me.Button_MoveToRemove.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_MoveToRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_MoveToRemove.FlatAppearance.BorderSize = 0
        Me.Button_MoveToRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MoveToRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MoveToRemove.Location = New System.Drawing.Point(408, 472)
        Me.Button_MoveToRemove.Name = "Button_MoveToRemove"
        Me.Button_MoveToRemove.Size = New System.Drawing.Size(192, 31)
        Me.Button_MoveToRemove.TabIndex = 1
        Me.Button_MoveToRemove.Text = "Move To Remove Folder"
        Me.Button_MoveToRemove.UseVisualStyleBackColor = False
        '
        'Button_SelectProjectJSON
        '
        Me.Button_SelectProjectJSON.AutoSize = True
        Me.Button_SelectProjectJSON.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_SelectProjectJSON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_SelectProjectJSON.FlatAppearance.BorderSize = 0
        Me.Button_SelectProjectJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_SelectProjectJSON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectProjectJSON.Location = New System.Drawing.Point(8, 472)
        Me.Button_SelectProjectJSON.Name = "Button_SelectProjectJSON"
        Me.Button_SelectProjectJSON.Size = New System.Drawing.Size(168, 32)
        Me.Button_SelectProjectJSON.TabIndex = 2
        Me.Button_SelectProjectJSON.Text = "Select Project JSON"
        Me.ToolTip1.SetToolTip(Me.Button_SelectProjectJSON, "You can drag drop a project json file here.")
        Me.Button_SelectProjectJSON.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Json files (*.json)|*.json"
        '
        'ListBox_UnesedResources
        '
        Me.ListBox_UnesedResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_UnesedResources.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_UnesedResources.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_UnesedResources.FormattingEnabled = True
        Me.ListBox_UnesedResources.HorizontalScrollbar = True
        Me.ListBox_UnesedResources.Location = New System.Drawing.Point(16, 32)
        Me.ListBox_UnesedResources.Name = "ListBox_UnesedResources"
        Me.ListBox_UnesedResources.Size = New System.Drawing.Size(576, 182)
        Me.ListBox_UnesedResources.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ListBox_UnesedResources, "Double click item to remove it from list.")
        '
        'Label_Resources
        '
        Me.Label_Resources.AutoSize = True
        Me.Label_Resources.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resources.Location = New System.Drawing.Point(8, 8)
        Me.Label_Resources.Name = "Label_Resources"
        Me.Label_Resources.Size = New System.Drawing.Size(67, 13)
        Me.Label_Resources.TabIndex = 5
        Me.Label_Resources.Text = "Resources"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Hint"
        '
        'Button_Reload
        '
        Me.Button_Reload.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Reload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Reload.FlatAppearance.BorderSize = 0
        Me.Button_Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reload.Location = New System.Drawing.Point(184, 472)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Size = New System.Drawing.Size(96, 32)
        Me.Button_Reload.TabIndex = 9
        Me.Button_Reload.Text = "Reload"
        Me.ToolTip1.SetToolTip(Me.Button_Reload, "You can drag drop a project json file here.")
        Me.Button_Reload.UseVisualStyleBackColor = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape1.CornerRadius = 3
        Me.RectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.Size = New System.Drawing.Size(592, 200)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Resources)
        Me.Panel1.Controls.Add(Me.ListBox_Resources)
        Me.Panel1.Controls.Add(Me.ShapeContainer3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 232)
        Me.Panel1.TabIndex = 7
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(608, 232)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label_UnesedResources)
        Me.Panel2.Controls.Add(Me.ListBox_UnesedResources)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Location = New System.Drawing.Point(0, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 232)
        Me.Panel2.TabIndex = 8
        '
        'Label_UnesedResources
        '
        Me.Label_UnesedResources.AutoSize = True
        Me.Label_UnesedResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_UnesedResources.Location = New System.Drawing.Point(8, 8)
        Me.Label_UnesedResources.Name = "Label_UnesedResources"
        Me.Label_UnesedResources.Size = New System.Drawing.Size(114, 13)
        Me.Label_UnesedResources.TabIndex = 9
        Me.Label_UnesedResources.Text = "Unesed Resources"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(608, 232)
        Me.ShapeContainer2.TabIndex = 5
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape2.CornerRadius = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Size = New System.Drawing.Size(592, 200)
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 512)
        Me.Controls.Add(Me.Button_Reload)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_SelectProjectJSON)
        Me.Controls.Add(Me.Button_MoveToRemove)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDev Resource Cleaner"
        Me.ToolTip1.SetToolTip(Me, "You can drag drop a project json file here.")
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Resources As ListBox
    Friend WithEvents Button_MoveToRemove As Button
    Friend WithEvents Button_SelectProjectJSON As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBox_UnesedResources As ListBox
    Friend WithEvents Label_Resources As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_UnesedResources As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents Button_Reload As Button
End Class
