Public Class Form1
    Dim mkvmerge As String
    Private Sub BrSong1_Click(sender As Object, e As EventArgs) Handles brSong1.Click
        opSong1.ShowDialog()
    End Sub
    Private Sub BrSong2_Click(sender As Object, e As EventArgs) Handles brSong2.Click
        If song1.Text = "" Then
            MsgBox("请先选择第一首歌", vbInformation, "可爱的提示")
        Else
            opSong2.ShowDialog()
        End If
    End Sub
    Private Sub BrSong3_Click(sender As Object, e As EventArgs) Handles brSong3.Click
        If song2.Text = "" Then
            MsgBox("请先选择第二首歌", vbInformation, "可爱的提示")
        Else
            opSong3.ShowDialog()
        End If
    End Sub
    Private Sub BrSong4_Click(sender As Object, e As EventArgs) Handles brSong4.Click
        If song3.Text = "" Then
            MsgBox("请先选择第三首歌", vbInformation, "可爱的提示")
        Else
            opSong4.ShowDialog()
        End If
    End Sub

    Private Sub OpSong1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opSong1.FileOk
        song1.Text = opSong1.FileName
    End Sub
    Private Sub OpSong2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opSong2.FileOk
        song2.Text = opSong2.FileName
    End Sub
    Private Sub OpSong3_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opSong3.FileOk
        song3.Text = opSong3.FileName
    End Sub
    Private Sub OpSong4_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles opSong4.FileOk
        song4.Text = opSong4.FileName
    End Sub

    Private Sub ClSong1_Click(sender As Object, e As EventArgs) Handles clSong1.Click
        song1.Text = "原版手指操音频.mp3"
    End Sub
    Private Sub ClSong2_Click(sender As Object, e As EventArgs) Handles clSong2.Click
        If song3.Text = "" Then
            song2.Text = ""
        Else
            MsgBox("第三首歌不为空", vbInformation, "可爱的提示")
        End If
    End Sub
    Private Sub ClSong3_Click(sender As Object, e As EventArgs) Handles clSong3.Click
        If song4.Text = "" Then
            song3.Text = ""
        Else
            MsgBox("第四首歌不为空", vbInformation, "可爱的提示")
        End If
    End Sub
    Private Sub ClSong4_Click(sender As Object, e As EventArgs) Handles clSong4.Click
        song4.Text = ""
    End Sub

    Private Sub SfOut_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfOut.FileOk
        savePath.Text = sfOut.FileName
    End Sub
    Private Sub BrSave_Click(sender As Object, e As EventArgs) Handles brSave.Click
        sfOut.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If savePath.Text = "" Then
            MsgBox("请先选择保存位置", vbInformation, "可爱的提示")
        ElseIf song1.Text = "" Then
            REM 都留空了
            MsgBox("请先添加 BGM", vbInformation, "可爱的提示")
        ElseIf song2.Text = "" Then
            REM 只选了一首歌
            Shell（$"{mkvmerge} --ui-language zh_CN --output {savePath.Text} --language 0:chi --track-name 0:室内操 --default-track 0:yes --compression 0:none ( 1.mp4 ) + ( 2.mp4 ) + ( 2.mp4 ) --language 0:chi --track-name 0:音频 --default-track 0:yes --compression 0:none ( ""{song1.Text}"" ) --title 使用十中室内操工厂应用制作的室内操", vbNormalFocus）
        ElseIf song3.Text = "" Then
            REM 只选了两首歌
            Shell（$"{mkvmerge} --ui-language zh_CN --output {savePath.Text} --language 0:chi --track-name 0:室内操 --default-track 0:yes --compression 0:none ( 1.mp4 ) + ( 2.mp4 ) + ( 2.mp4 ) --language 0:chi --track-name 0:音频 --default-track 0:yes --compression 0:none ( ""{song1.Text}"" ) + ( ""{song2.Text}"" ) --title 使用十中室内操工厂应用制作的室内操", vbNormalFocus）
        ElseIf song4.Text = "" Then
            REM 只选了三首歌
            Shell（$"{mkvmerge} --ui-language zh_CN --output {savePath.Text} --language 0:chi --track-name 0:室内操 --default-track 0:yes --compression 0:none ( 1.mp4 ) + ( 2.mp4 ) + ( 2.mp4 ) --language 0:chi --track-name 0:音频 --default-track 0:yes --compression 0:none ( ""{song1.Text}"" ) + ( ""{song2.Text}"" ) + ( ""{song3.Text}"" ) --title 使用十中室内操工厂应用制作的室内操", vbNormalFocus）
        Else
            REM 四首歌都选了
            Shell（$"{mkvmerge} --ui-language zh_CN --output {savePath.Text} --language 0:chi --track-name 0:室内操 --default-track 0:yes --compression 0:none ( 1.mp4 ) + ( 2.mp4 ) + ( 2.mp4 ) --language 0:chi --track-name 0:音频 --default-track 0:yes --compression 0:none ( ""{song1.Text}"" ) + ( ""{song2.Text}"" ) + ( ""{song3.Text}"" ) + ( ""{song4.Text}"" ) --title 使用十中室内操工厂应用制作的室内操", vbNormalFocus）
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.GetEnvironmentVariable("ProgramFiles(x86)") = "" Then
            mkvmerge = "mkvmerge32.exe"
            Me.Text = Me.Text & " (32 位)"
        Else
            mkvmerge = "mkvmerge.exe"
            Me.Text = Me.Text & " (64 位)"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("cmd /c start https://gao4.pw/", vbNormalFocus)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Shell("cmd /c start https://shang.qq.com/wpa/qunwpa?idkey=fe5c87783a19dc6cf4eef5f9bb4a2df3a5fc266d6473e17bf881894c47a6ccdf", vbNormalFocus)
    End Sub
End Class
