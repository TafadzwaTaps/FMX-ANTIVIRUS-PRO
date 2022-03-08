Imports System.Security
Imports System.IO
Imports System.Text

Public Class Form1
    Dim SS As String = ""
    Dim CC As Integer = 0
    Dim VIRUSHARSHES As String = ""

    Private Sub GET_VIRUSHARSHES()

        Dim SSS As New StreamWriter(Application.StartupPath & "\HASH.TXT")
        SSS.WriteLine("54KK3K4O33P20435K58VG23")
        SSS.Close()

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\HASH.TXT") = True Then
            Dim S As New StreamReader(Application.StartupPath & "\HASH.TXT")
            VIRUSHARSHES = S.ReadToEnd
            S.Close()

        End If
    End Sub

    Private Sub SCAN(ByVal PATH As String)
        Dim L As New List(Of FileInfo)
        Label1.Text = "STATUS: ANALYSING"
        L.AddRange(GETFILES(PATH))
        Label1.Text = "STATUS: ABOUT TO START"
        For Each F As FileInfo In L
            If BackgroundWorker1.CancellationPending = True Then
                Exit Sub
            Else
                If VIRUSHARSHES.Contains(GETMDS(F.FullName)) = True Then
                    'DETECTED VIRUS
                    'WHAT WILL HAPPEN TO THE VIRUS DETECTED
                    ListView1.Items.Add(F.Name)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(F.FullName)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(F.Extension)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(F.Length)
               
                    Exit Sub
                End If
                CC += 1
                Label1.Text = CC & "; " & Environment.NewLine & F.FullName.ToString

            End If
        Next
    End Sub

    Private Function GETFILES(ByVal PATH As String) As List(Of FileInfo)
        Dim L As New List(Of FileInfo)
        Dim D As New DirectoryInfo(PATH)
        Dim FX As FileInfo
        For Each DD As DirectoryInfo In D.GetDirectories("*.*", SearchOption.AllDirectories)
            For Each FF As FileInfo In DD.GetFiles
                FX = New FileInfo(FF.FullName)
                L.Add(FX)

            Next
            L.AddRange(GETFILES(DD.FullName))

        Next
        Return L
    End Function


    Private Function GETMDS(ByVal PATH As String) As String
        Dim MD5 As New Cryptography.MD5CryptoServiceProvider
        Dim F As New FileStream(PATH, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        MD5.ComputeHash(F)
        F.Close()
        Dim hash As Byte() = MD5.Hash
        Dim buff As New StringBuilder
        Dim hashbyte As Byte
        For Each hashbyte In hash
            buff.Append(String.Format("{0:x2})", hashbyte))
        Next
        Return buff.ToString
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If BackgroundWorker1.IsBusy = True Then
            If MsgBox("DO YOU WANT TO CANCEL SCANNING", MsgBoxStyle.YesNo, "SIMPLE ANTIVIRUS") = MsgBoxResult.Yes Then
                BackgroundWorker1.CancelAsync()
            End If
        Else
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                CC = 0
                TextBox1.Text = FolderBrowserDialog1.SelectedPath
                BackgroundWorker1.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        SCAN(FolderBrowserDialog1.SelectedPath)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        GET_VIRUSHARSHES()
    End Sub
End Class
