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
        Me.ListBox_UnusedResources = New System.Windows.Forms.ListBox()
        Me.Label_Resources = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_Reload = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label_UnusedResources = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ProjectFilePath = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.ToolTip1.SetToolTip(Me.ListBox_Resources, "You can drag & drop a project json file here.")
        '
        'Button_MoveToRemove
        '
        Me.Button_MoveToRemove.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button_MoveToRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_MoveToRemove.FlatAppearance.BorderSize = 0
        Me.Button_MoveToRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_MoveToRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MoveToRemove.Location = New System.Drawing.Point(400, 536)
        Me.Button_MoveToRemove.Name = "Button_MoveToRemove"
        Me.Button_MoveToRemove.Size = New System.Drawing.Size(200, 32)
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
        Me.Button_SelectProjectJSON.Location = New System.Drawing.Point(432, 24)
        Me.Button_SelectProjectJSON.Name = "Button_SelectProjectJSON"
        Me.Button_SelectProjectJSON.Size = New System.Drawing.Size(64, 24)
        Me.Button_SelectProjectJSON.TabIndex = 2
        Me.Button_SelectProjectJSON.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button_SelectProjectJSON, "You can drag & drop a project json file here.")
        Me.Button_SelectProjectJSON.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Json files (*.json)|*.json"
        '
        'ListBox_UnusedResources
        '
        Me.ListBox_UnusedResources.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ListBox_UnusedResources.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox_UnusedResources.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox_UnusedResources.FormattingEnabled = True
        Me.ListBox_UnusedResources.HorizontalScrollbar = True
        Me.ListBox_UnusedResources.Location = New System.Drawing.Point(16, 32)
        Me.ListBox_UnusedResources.Name = "ListBox_UnusedResources"
        Me.ListBox_UnusedResources.Size = New System.Drawing.Size(576, 182)
        Me.ListBox_UnusedResources.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ListBox_UnusedResources, "Double click item to remove it from list.")
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
        Me.Button_Reload.Location = New System.Drawing.Point(8, 536)
        Me.Button_Reload.Name = "Button_Reload"
        Me.Button_Reload.Size = New System.Drawing.Size(112, 32)
        Me.Button_Reload.TabIndex = 9
        Me.Button_Reload.Text = "Scan Files"
        Me.ToolTip1.SetToolTip(Me.Button_Reload, "You can drag drop a project json file here.")
        Me.Button_Reload.UseVisualStyleBackColor = False
        '
        'Button_Close
        '
        Me.Button_Close.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button_Close.FlatAppearance.BorderSize = 0
        Me.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Close.Location = New System.Drawing.Point(520, 24)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(80, 24)
        Me.Button_Close.TabIndex = 11
        Me.Button_Close.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.Button_Close, "You can drag drop a project json file here.")
        Me.Button_Close.UseVisualStyleBackColor = False
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
        Me.Panel1.Location = New System.Drawing.Point(0, 64)
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
        Me.Panel2.Controls.Add(Me.Label_UnusedResources)
        Me.Panel2.Controls.Add(Me.ListBox_UnusedResources)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 232)
        Me.Panel2.TabIndex = 8
        '
        'Label_UnusedResources
        '
        Me.Label_UnusedResources.AutoSize = True
        Me.Label_UnusedResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_UnusedResources.Location = New System.Drawing.Point(8, 8)
        Me.Label_UnusedResources.Name = "Label_UnusedResources"
        Me.Label_UnusedResources.Size = New System.Drawing.Size(114, 13)
        Me.Label_UnusedResources.TabIndex = 9
        Me.Label_UnusedResources.Text = "Unused Resources"
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button_Close)
        Me.Panel3.Controls.Add(Me.Button_SelectProjectJSON)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TextBox_ProjectFilePath)
        Me.Panel3.Controls.Add(Me.ShapeContainer1)
        Me.Panel3.Location = New System.Drawing.Point(0, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(608, 56)
        Me.Panel3.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Project File Path"
        '
        'TextBox_ProjectFilePath
        '
        Me.TextBox_ProjectFilePath.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TextBox_ProjectFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ProjectFilePath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox_ProjectFilePath.Location = New System.Drawing.Point(16, 32)
        Me.TextBox_ProjectFilePath.Name = "TextBox_ProjectFilePath"
        Me.TextBox_ProjectFilePath.ReadOnly = True
        Me.TextBox_ProjectFilePath.Size = New System.Drawing.Size(392, 13)
        Me.TextBox_ProjectFilePath.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(608, 56)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RectangleShape3.CornerRadius = 3
        Me.RectangleShape3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 24)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.Size = New System.Drawing.Size(408, 24)
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 577)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button_Reload)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox_Resources As ListBox
    Friend WithEvents Button_MoveToRemove As Button
    Friend WithEvents Button_SelectProjectJSON As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBox_UnusedResources As ListBox
    Friend WithEvents Label_Resources As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RectangleShape1 As RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer3 As ShapeContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label_UnusedResources As Label
    Friend WithEvents ShapeContainer2 As ShapeContainer
    Friend WithEvents RectangleShape2 As RectangleShape
    Friend WithEvents Button_Reload As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ProjectFilePath As TextBox
    Friend WithEvents ShapeContainer1 As ShapeContainer
    Friend WithEvents RectangleShape3 As RectangleShape
    Friend WithEvents Button_Close As Button
End Class
