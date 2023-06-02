Imports System.IO
Imports Newtonsoft.Json.Linq
Public Class Form1
    'Button_SelectProjectJSON - Click
    Private Sub Button_SelectProjectJSON_Click(sender As Object, e As EventArgs) Handles Button_SelectProjectJSON.Click
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox_ProjectFilePath.Text = OpenFileDialog1.FileName
            ProjectJSON()
        End If
    End Sub
    'Button_Reload - Click
    Private Sub Button_Reload_Click(sender As Object, e As EventArgs) Handles Button_Reload.Click
        If File.Exists(OpenFileDialog1.FileName) Then
            ProjectJSON()
        End If
    End Sub
    'ListBox_UnusedResources - DoubleClick
    Private Sub ListBox_UnusedResources_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_UnusedResources.DoubleClick
        If Not ListBox_UnusedResources.SelectedIndex = -1 Then
            ListBox_UnusedResources.Items.RemoveAt(ListBox_UnusedResources.SelectedIndex)
        End If
    End Sub
    'Button_Close - Click
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        TextBox_ProjectFilePath.Clear()
        ListBox_Resources.Items.Clear()
        ListBox_UnusedResources.Items.Clear()
        Label_Resources.Text = "Resources"
        Label_UnusedResources.Text = "Unused Resources"
    End Sub
    'Button_MoveToRemove - Click
    Private Sub Button_MoveToRemove_Click(sender As Object, e As EventArgs) Handles Button_MoveToRemove.Click
        If ListBox_UnusedResources.Items.Count > 0 Then
            Dim workingDir As String = Path.GetDirectoryName(OpenFileDialog1.FileName)
            If Not Directory.Exists(workingDir & "\!REMOVE") Then
                Directory.CreateDirectory(workingDir & "\!REMOVE")
            End If

            For Each item As String In ListBox_UnusedResources.Items

                If Not Directory.Exists(workingDir & "\!REMOVE\" & Path.GetDirectoryName(item)) Then
                    Directory.CreateDirectory(workingDir & "\!REMOVE\" & Path.GetDirectoryName(item))
                End If

                My.Computer.FileSystem.MoveFile(Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\" & item, workingDir & "\!REMOVE\" & item)
            Next

            If File.Exists(OpenFileDialog1.FileName) Then
                ProjectJSON()
            End If

            MsgBox("Files moved to: " & vbNewLine & workingDir & "\!REMOVE", MsgBoxStyle.Information)
        End If
    End Sub
    'Form1 - DragDrop
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length <> 0 Then
            Try
                OpenFileDialog1.FileName = files(0)
                TextBox_ProjectFilePath.Text = files(0)
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
        ListBox_UnusedResources.Items.Clear()
        Label_Resources.Text = "Resources"
        Label_UnusedResources.Text = "Unused Resources"
        Dim jsonFile As JObject = JObject.Parse(File.ReadAllText(TextBox_ProjectFilePath.Text))
        For Each resource As JObject In jsonFile.Item("resources")("resources")
            ListBox_Resources.BeginUpdate()
            ListBox_Resources.Items.Add(resource.Item("file").ToString.Replace("/", "\")) 'Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\" &
            ListBox_Resources.EndUpdate()
        Next

        Dim fileEntries As New ArrayList
        Dim workingDir As String = Path.GetDirectoryName(TextBox_ProjectFilePath.Text)
        Dim bla As String = "test"
        Dim tempArryList As New ArrayList
        tempArryList.AddRange(Directory.GetFiles(Path.GetDirectoryName(TextBox_ProjectFilePath.Text), "*.*", SearchOption.AllDirectories).Where(Function(p) Not p.StartsWith(workingDir & "\!REMOVE")).ToArray)

        For index As Integer = 0 To tempArryList.Count - 1
            tempArryList.Item(index) = tempArryList.Item(index).ToString.Replace(Path.GetDirectoryName(TextBox_ProjectFilePath.Text) & "\", "")
        Next

        fileEntries.AddRange(tempArryList)
        fileEntries.Remove(Path.GetFileName(TextBox_ProjectFilePath.Text))
        fileEntries.Remove(Path.GetFileName(TextBox_ProjectFilePath.Text) & ".autosave")

        For Each item As String In fileEntries
            If Not ListBox_Resources.Items.Contains(item) Then
                ListBox_UnusedResources.BeginUpdate()
                ListBox_UnusedResources.Items.Add(item)
                ListBox_UnusedResources.EndUpdate()
            End If
        Next
        Label_Resources.Text = "Resources: " & ListBox_Resources.Items.Count
        Label_UnusedResources.Text = "Unused Resources: " & ListBox_UnusedResources.Items.Count
    End Sub
End Class