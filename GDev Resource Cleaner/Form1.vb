Imports System.IO
Imports Newtonsoft.Json.Linq
Public Class Form1
    'Button_SelectProjectJSON - Click
    Private Sub Button_SelectProjectJSON_Click(sender As Object, e As EventArgs) Handles Button_SelectProjectJSON.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ProjectJSON()
        End If
    End Sub
    'Button_Reload - Click
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        If File.Exists(OpenFileDialog1.FileName) Then
            ProjectJSON()
        End If
    End Sub
    'ListBox_UnesedResources - DoubleClick
    Private Sub ListBox_UnesedResources_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_UnesedResources.DoubleClick
        If Not ListBox_UnesedResources.SelectedIndex = -1 Then
            ListBox_UnesedResources.Items.RemoveAt(ListBox_UnesedResources.SelectedIndex)
        End If
    End Sub
    'Button_MoveToRemove - Click
    Private Sub Button_MoveToRemove_Click(sender As Object, e As EventArgs) Handles Button_MoveToRemove.Click
        If ListBox_UnesedResources.Items.Count > 0 Then
            Dim workingDir As String = Path.GetDirectoryName(OpenFileDialog1.FileName)
            If Not Directory.Exists(workingDir & "\!REMOVE") Then
                Directory.CreateDirectory(workingDir & "\!REMOVE")
            End If
            For Each item As String In ListBox_UnesedResources.Items
                My.Computer.FileSystem.MoveFile(item, workingDir & "\!REMOVE\" & Path.GetFileName(item))
            Next
            ListBox_Resources.Items.Clear()
            ListBox_UnesedResources.Items.Clear()
            Label_Resources.Text = "Resources"
            Label_UnesedResources.Text = "Unesed Resources"
            MsgBox("Files moved to: " & vbNewLine & workingDir & "\!REMOVE", MsgBoxStyle.Information)
        End If
    End Sub
    'Form1 - DragDrop
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                OpenFileDialog1.FileName = files(0)
                ProjectJSON()
            Catch ex As Exception
                MsgBox("Problem opening file.", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
    'Form1 - DragEnter
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If e.Data.GetDataPresent(DataFormats.FileDrop) And Path.GetExtension(files(0)) = ".json" Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    'ProjectJSON
    Private Sub ProjectJSON()
        ListBox_Resources.Items.Clear()
        ListBox_UnesedResources.Items.Clear()
        Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(OpenFileDialog1.FileName))
        For Each resource As JObject In jsonFile.Item("resources")("resources")
            ListBox_Resources.BeginUpdate()
            ListBox_Resources.Items.Add(Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & resource.Item("file").ToString.Replace("/", "\"))
            ListBox_Resources.EndUpdate()
        Next

        Dim fileEntries As New ArrayList
        Dim workingDir As String = Path.GetDirectoryName(OpenFileDialog1.FileName)
        fileEntries.AddRange(Directory.GetFiles(Path.GetDirectoryName(OpenFileDialog1.FileName), "*.*", SearchOption.AllDirectories).Where(Function(p) Not p.StartsWith(workingDir & "\!REMOVE")).ToArray)
        fileEntries.Remove(OpenFileDialog1.FileName)
        fileEntries.Remove(OpenFileDialog1.FileName & ".autosave")

        For Each item As String In fileEntries
            If Not ListBox_Resources.Items.Contains(item) Then
                ListBox_UnesedResources.BeginUpdate()
                ListBox_UnesedResources.Items.Add(item)
                ListBox_UnesedResources.EndUpdate()
            End If
        Next
        Label_Resources.Text = "Resources: " & ListBox_Resources.Items.Count
        Label_UnesedResources.Text = "Unesed Resources: " & ListBox_UnesedResources.Items.Count
    End Sub
End Class