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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    	Me.ButtonMP3 = New System.Windows.Forms.Button()
    	Me.ButtonH264 = New System.Windows.Forms.Button()
    	Me.ButtonExit = New System.Windows.Forms.Button()
    	Me.TextBoxURL = New System.Windows.Forms.TextBox()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.TextBoxName = New System.Windows.Forms.TextBox()
    	Me.TextBoxMP4 = New System.Windows.Forms.TextBox()
    	Me.TextBoxArtist = New System.Windows.Forms.TextBox()
    	Me.Label3 = New System.Windows.Forms.Label()
    	Me.TextBoxMP3 = New System.Windows.Forms.TextBox()
    	Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    	Me.btnUpdate = New System.Windows.Forms.Button()
    	Me.txtStatus = New System.Windows.Forms.TextBox()
    	Me.SuspendLayout
    	'
    	'ButtonMP3
    	'
    	Me.ButtonMP3.Enabled = false
    	Me.ButtonMP3.Location = New System.Drawing.Point(24, 205)
    	Me.ButtonMP3.Name = "ButtonMP3"
    	Me.ButtonMP3.Size = New System.Drawing.Size(142, 21)
    	Me.ButtonMP3.TabIndex = 4
    	Me.ButtonMP3.Text = "Rip-MP3"
    	Me.ButtonMP3.UseVisualStyleBackColor = true
    	'
    	'ButtonH264
    	'
    	Me.ButtonH264.Location = New System.Drawing.Point(24, 129)
    	Me.ButtonH264.Name = "ButtonH264"
    	Me.ButtonH264.Size = New System.Drawing.Size(142, 23)
    	Me.ButtonH264.TabIndex = 3
    	Me.ButtonH264.Text = "Download H.264 -Video"
    	Me.ButtonH264.UseVisualStyleBackColor = true
    	'
    	'ButtonExit
    	'
    	Me.ButtonExit.Location = New System.Drawing.Point(488, 280)
    	Me.ButtonExit.Name = "ButtonExit"
    	Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
    	Me.ButtonExit.TabIndex = 5
    	Me.ButtonExit.Text = "Exit"
    	Me.ButtonExit.UseVisualStyleBackColor = true
    	'
    	'TextBoxURL
    	'
    	Me.TextBoxURL.Location = New System.Drawing.Point(90, 30)
    	Me.TextBoxURL.Name = "TextBoxURL"
    	Me.TextBoxURL.Size = New System.Drawing.Size(473, 20)
    	Me.TextBoxURL.TabIndex = 0
    	Me.TextBoxURL.Text = "http://youtube.com/URL"
    	'
    	'Label1
    	'
    	Me.Label1.AutoSize = true
    	Me.Label1.Location = New System.Drawing.Point(24, 33)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(63, 13)
    	Me.Label1.TabIndex = 99
    	Me.Label1.Text = "URL to Rip:"
    	'
    	'Label2
    	'
    	Me.Label2.AutoSize = true
    	Me.Label2.Location = New System.Drawing.Point(24, 60)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(30, 13)
    	Me.Label2.TabIndex = 99
    	Me.Label2.Text = "Title:"
    	'
    	'TextBoxName
    	'
    	Me.TextBoxName.Location = New System.Drawing.Point(90, 60)
    	Me.TextBoxName.Name = "TextBoxName"
    	Me.TextBoxName.Size = New System.Drawing.Size(473, 20)
    	Me.TextBoxName.TabIndex = 1
    	Me.TextBoxName.Text = "Song Title"
    	'
    	'TextBoxMP4
    	'
    	Me.TextBoxMP4.Location = New System.Drawing.Point(24, 168)
    	Me.TextBoxMP4.Name = "TextBoxMP4"
    	Me.TextBoxMP4.ReadOnly = true
    	Me.TextBoxMP4.Size = New System.Drawing.Size(539, 20)
    	Me.TextBoxMP4.TabIndex = 100
    	'
    	'TextBoxArtist
    	'
    	Me.TextBoxArtist.Location = New System.Drawing.Point(90, 90)
    	Me.TextBoxArtist.Name = "TextBoxArtist"
    	Me.TextBoxArtist.Size = New System.Drawing.Size(473, 20)
    	Me.TextBoxArtist.TabIndex = 2
    	Me.TextBoxArtist.Text = "Artist"
    	'
    	'Label3
    	'
    	Me.Label3.AutoSize = true
    	Me.Label3.Location = New System.Drawing.Point(24, 90)
    	Me.Label3.Name = "Label3"
    	Me.Label3.Size = New System.Drawing.Size(33, 13)
    	Me.Label3.TabIndex = 102
    	Me.Label3.Text = "Artist:"
    	'
    	'TextBoxMP3
    	'
    	Me.TextBoxMP3.Location = New System.Drawing.Point(24, 241)
    	Me.TextBoxMP3.Name = "TextBoxMP3"
    	Me.TextBoxMP3.ReadOnly = true
    	Me.TextBoxMP3.Size = New System.Drawing.Size(539, 20)
    	Me.TextBoxMP3.TabIndex = 103
    	'
    	'CheckBox1
    	'
    	Me.CheckBox1.AutoSize = true
    	Me.CheckBox1.Enabled = false
    	Me.CheckBox1.Location = New System.Drawing.Point(289, 209)
    	Me.CheckBox1.Name = "CheckBox1"
    	Me.CheckBox1.Size = New System.Drawing.Size(172, 17)
    	Me.CheckBox1.TabIndex = 104
    	Me.CheckBox1.Text = "Delete Video after conversion?"
    	Me.CheckBox1.UseVisualStyleBackColor = true
    	'
    	'btnUpdate
    	'
    	Me.btnUpdate.Location = New System.Drawing.Point(24, 280)
    	Me.btnUpdate.Name = "btnUpdate"
    	Me.btnUpdate.Size = New System.Drawing.Size(119, 23)
    	Me.btnUpdate.TabIndex = 105
    	Me.btnUpdate.Text = "Update DL manually"
    	Me.btnUpdate.UseVisualStyleBackColor = true
    	AddHandler Me.btnUpdate.Click, AddressOf Me.BtnUpdateClick
    	'
    	'txtStatus
    	'
    	Me.txtStatus.Location = New System.Drawing.Point(24, 309)
    	Me.txtStatus.Multiline = true
    	Me.txtStatus.Name = "txtStatus"
    	Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    	Me.txtStatus.Size = New System.Drawing.Size(539, 68)
    	Me.txtStatus.TabIndex = 106
    	'
    	'Form1
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(572, 389)
    	Me.Controls.Add(Me.txtStatus)
    	Me.Controls.Add(Me.btnUpdate)
    	Me.Controls.Add(Me.CheckBox1)
    	Me.Controls.Add(Me.TextBoxMP3)
    	Me.Controls.Add(Me.TextBoxArtist)
    	Me.Controls.Add(Me.Label3)
    	Me.Controls.Add(Me.TextBoxMP4)
    	Me.Controls.Add(Me.TextBoxName)
    	Me.Controls.Add(Me.Label2)
    	Me.Controls.Add(Me.Label1)
    	Me.Controls.Add(Me.TextBoxURL)
    	Me.Controls.Add(Me.ButtonExit)
    	Me.Controls.Add(Me.ButtonH264)
    	Me.Controls.Add(Me.ButtonMP3)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.Name = "Form1"
    	Me.Text = "YouTube Ripper"
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Private txtStatus As System.Windows.Forms.TextBox
    Private btnUpdate As System.Windows.Forms.Button

    Friend WithEvents ButtonMP3 As Button
    Friend WithEvents ButtonH264 As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents TextBoxURL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxMP4 As TextBox
    Friend WithEvents TextBoxArtist As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxMP3 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
