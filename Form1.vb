Imports System.IO
Imports YouTube_Ripper.MP3ID3v1

Public Class Form1

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonMP3_Click(sender As Object, e As EventArgs) Handles ButtonMP3.Click
        Dim varPrefix As String = "C:\converter\bin\ffmpeg\bin\ffmpeg.exe"
        Dim errLines As String = ""
        Dim inputVideo As String = ".\Video\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp4"
        Dim outputAudio As String = ".\Audio\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp3"
        Dim errDetect As Boolean = False
        TextBoxMP3.Text = "stipping audio..."
        Try
            Dim myprocess As New Process
            Dim outLines As String = ""
            With myprocess
                .StartInfo.FileName = varPrefix
                .StartInfo.Arguments = " -i " & ControlChars.Quote & inputVideo & ControlChars.Quote & " -codec:a libmp3lame " & ControlChars.Quote & outputAudio & ControlChars.Quote
                .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.RedirectStandardError = True
                .StartInfo.WorkingDirectory = "c:\converter"
                .StartInfo.UseShellExecute = False
                .Start()
            End With
            outLines = myprocess.StandardOutput.ReadToEnd
            TextBoxMP4.Text = outLines
            errLines = myprocess.StandardError.ReadToEnd
            ' if errlines contains 404 bad URL
            If errLines.Contains("404") Then
                errDetect = True
                TextBoxMP4.Text = "Bad or invalid Address"
                logit("Bad URL")
            End If
			logit(My.Computer.Clock.LocalTime + ": C:\converter\bin\ffmpeg\bin\ffmpeg.exe .\Video\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp4 .\Audio\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp3")
        Catch
            TextBoxMP4.Text = errLines
        Finally
            Try
                Dim myprocess As New Process
                Dim outLines As String = ""
                TextBoxMP3.Text = "C:\converter\bin\id3.exe" & " -t " & ControlChars.Quote & TextBoxName.Text & ControlChars.Quote & " -a " & ControlChars.Quote & TextBoxArtist.Text & ControlChars.Quote & " " & ControlChars.Quote & "C:\Converter\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp3" & ControlChars.Quote
                With myprocess
                    .StartInfo.FileName = "C:\converter\bin\id3.exe"
                    .StartInfo.Arguments = " -t " & ControlChars.Quote & TextBoxName.Text & ControlChars.Quote & " -a " & ControlChars.Quote & TextBoxArtist.Text & ControlChars.Quote & " " & ControlChars.Quote & "C:\Converter\Audio\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp3" & ControlChars.Quote
                    .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    .StartInfo.RedirectStandardOutput = True
                    .StartInfo.RedirectStandardError = True
                    .StartInfo.WorkingDirectory = "c:\converter\Audio"
                    .StartInfo.UseShellExecute = False
                    .Start()
                End With
                outLines = myprocess.StandardOutput.ReadToEnd
                TextBoxMP4.Text = outLines
                errLines = myprocess.StandardError.ReadToEnd
                If errLines.Contains("404") Then
                    errDetect = True
                    TextBoxMP4.Text = "Bad or invalid Address"
                End If
            Catch ex As Exception
                TextBoxMP3.Text = ex.Message.ToString
            End Try
            If CheckBox1.Checked Then
                My.Computer.FileSystem.DeleteFile("C:\converter\Video\" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp4")
            End If
        End Try
    End Sub

    Private Sub ButtonH264_Click(sender As Object, e As EventArgs) Handles ButtonH264.Click
        Dim varPrefix As String = "c:\converter\bin\YouTube-Dl.exe"
        Dim errLines As String = ""
        Dim outputVideo = "" & TextBoxArtist.Text & " - " & TextBoxName.Text & ".mp4"
        Dim errDetect As Boolean = False
        TextBoxMP3.Text = outputVideo
        CheckBox1.Enabled = True
        Try
            Dim myprocess As New Process
            Dim outLines As String = ""
            With myprocess
                .StartInfo.FileName = "c:\converter\bin\youtube-dl.exe"
                .StartInfo.Arguments = " --no-call-home " & TextBoxURL.Text & " -f mp4 --audio-format aac -o " & ControlChars.Quote & outputVideo & ControlChars.Quote
                .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.RedirectStandardError = True
                .StartInfo.WorkingDirectory = "c:\converter\Video"
                .StartInfo.UseShellExecute = False
                .Start()
            End With
            outLines = myprocess.StandardOutput.ReadToEnd
            TextBoxMP4.Text = outLines
            errLines = myprocess.StandardError.ReadToEnd
            If errLines.Contains("404") Then
                errDetect = True
                TextBoxMP4.Text = "Bad or invalid Address"
            End If
			logit(My.Computer.Clock.LocalTime + ": c:\converter\bin\youtube-dl.exe  --no-call-home " & TextBoxURL.Text & " -f mp4 --audio-format aac -o " & ControlChars.Quote & outputVideo & ControlChars.Quote )
        Catch
            TextBoxMP4.Text = errLines
        End Try
        If Not errDetect Then
            TextBoxMP4.Text = "c:\converter\Video\" + outputVideo
        End If
        ButtonMP3.Enabled = True
        TextBoxMP3.Text = "If you want audio only"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    	Dim outputVideo As String = ""
		logit(My.Computer.Clock.LocalTime + ": Startup")
		updateYoutubeDL()
    End Sub
    
    Sub BtnUpdateClick(sender As Object, e As EventArgs)
		updateYoutubeDL()
    End Sub
    
    Sub logit (ByVal sArg As String)
    		txtStatus.AppendText(vbCrLf + sArg)
    		IO.File.AppendAllText("Log.txt", String.Format("{0}{1}", Environment.NewLine, sArg ))
    End Sub
    	
	Sub updateYoutubeDL()
    	logit(My.Computer.Clock.LocalTime + ": Updating youtube-dl from https://yt-dl.org/downloads/latest/youtube-dl.exe" )
    	Try
    		My.Computer.FileSystem.DeleteFile("youtube-dl.exe")
    	Catch ex As Exception
    	End Try
    	Try	
    		My.Computer.Network.DownloadFile("https://yt-dl.org/downloads/latest/youtube-dl.exe", "youtube-dl.exe", "anonymous", "")
    	Catch ex As Exception
    	End Try		
    End Sub

End Class
