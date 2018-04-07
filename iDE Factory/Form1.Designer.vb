<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.brSong1 = New System.Windows.Forms.Button()
        Me.brSong2 = New System.Windows.Forms.Button()
        Me.brSong3 = New System.Windows.Forms.Button()
        Me.brSong4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.brSave = New System.Windows.Forms.Button()
        Me.clSong1 = New System.Windows.Forms.Button()
        Me.clSong2 = New System.Windows.Forms.Button()
        Me.clSong3 = New System.Windows.Forms.Button()
        Me.clSong4 = New System.Windows.Forms.Button()
        Me.song1 = New System.Windows.Forms.Label()
        Me.song2 = New System.Windows.Forms.Label()
        Me.song3 = New System.Windows.Forms.Label()
        Me.song4 = New System.Windows.Forms.Label()
        Me.savePath = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.opSong1 = New System.Windows.Forms.OpenFileDialog()
        Me.opSong2 = New System.Windows.Forms.OpenFileDialog()
        Me.opSong3 = New System.Windows.Forms.OpenFileDialog()
        Me.opSong4 = New System.Windows.Forms.OpenFileDialog()
        Me.sfOut = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.brSong1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.brSong2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.brSong3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.brSong4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.brSave, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.clSong1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clSong2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clSong3, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.clSong4, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.song1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.song2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.song3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.song4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.savePath, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel1, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LinkLabel2, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(552, 189)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "第一首歌"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "第二首歌"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "第三首歌"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "第四首歌"
        '
        'brSong1
        '
        Me.brSong1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brSong1.Location = New System.Drawing.Point(433, 3)
        Me.brSong1.Name = "brSong1"
        Me.brSong1.Size = New System.Drawing.Size(54, 24)
        Me.brSong1.TabIndex = 4
        Me.brSong1.Text = "选择"
        Me.brSong1.UseVisualStyleBackColor = True
        '
        'brSong2
        '
        Me.brSong2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brSong2.Location = New System.Drawing.Point(433, 33)
        Me.brSong2.Name = "brSong2"
        Me.brSong2.Size = New System.Drawing.Size(54, 24)
        Me.brSong2.TabIndex = 5
        Me.brSong2.Text = "选择"
        Me.brSong2.UseVisualStyleBackColor = True
        '
        'brSong3
        '
        Me.brSong3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brSong3.Location = New System.Drawing.Point(433, 63)
        Me.brSong3.Name = "brSong3"
        Me.brSong3.Size = New System.Drawing.Size(54, 24)
        Me.brSong3.TabIndex = 6
        Me.brSong3.Text = "选择"
        Me.brSong3.UseVisualStyleBackColor = True
        '
        'brSong4
        '
        Me.brSong4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brSong4.Location = New System.Drawing.Point(433, 93)
        Me.brSong4.Name = "brSong4"
        Me.brSong4.Size = New System.Drawing.Size(54, 24)
        Me.brSong4.TabIndex = 7
        Me.brSong4.Text = "选择"
        Me.brSong4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 30)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "选择保存位置"
        '
        'brSave
        '
        Me.brSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.brSave.Location = New System.Drawing.Point(433, 123)
        Me.brSave.Name = "brSave"
        Me.brSave.Size = New System.Drawing.Size(54, 24)
        Me.brSave.TabIndex = 13
        Me.brSave.Text = "浏览"
        Me.brSave.UseVisualStyleBackColor = True
        '
        'clSong1
        '
        Me.clSong1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clSong1.Location = New System.Drawing.Point(493, 3)
        Me.clSong1.Name = "clSong1"
        Me.clSong1.Size = New System.Drawing.Size(56, 24)
        Me.clSong1.TabIndex = 14
        Me.clSong1.Text = "重置"
        Me.clSong1.UseVisualStyleBackColor = True
        '
        'clSong2
        '
        Me.clSong2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clSong2.Location = New System.Drawing.Point(493, 33)
        Me.clSong2.Name = "clSong2"
        Me.clSong2.Size = New System.Drawing.Size(56, 24)
        Me.clSong2.TabIndex = 15
        Me.clSong2.Text = "清除"
        Me.clSong2.UseVisualStyleBackColor = True
        '
        'clSong3
        '
        Me.clSong3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clSong3.Location = New System.Drawing.Point(493, 63)
        Me.clSong3.Name = "clSong3"
        Me.clSong3.Size = New System.Drawing.Size(56, 24)
        Me.clSong3.TabIndex = 16
        Me.clSong3.Text = "清除"
        Me.clSong3.UseVisualStyleBackColor = True
        '
        'clSong4
        '
        Me.clSong4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clSong4.Location = New System.Drawing.Point(493, 93)
        Me.clSong4.Name = "clSong4"
        Me.clSong4.Size = New System.Drawing.Size(56, 24)
        Me.clSong4.TabIndex = 17
        Me.clSong4.Text = "清除"
        Me.clSong4.UseVisualStyleBackColor = True
        '
        'song1
        '
        Me.song1.AutoSize = True
        Me.song1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.song1.Location = New System.Drawing.Point(93, 0)
        Me.song1.Name = "song1"
        Me.song1.Size = New System.Drawing.Size(334, 30)
        Me.song1.TabIndex = 18
        Me.song1.Text = "原版手指操音频.mp3"
        '
        'song2
        '
        Me.song2.AutoSize = True
        Me.song2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.song2.Location = New System.Drawing.Point(93, 30)
        Me.song2.Name = "song2"
        Me.song2.Size = New System.Drawing.Size(334, 30)
        Me.song2.TabIndex = 19
        '
        'song3
        '
        Me.song3.AutoSize = True
        Me.song3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.song3.Location = New System.Drawing.Point(93, 60)
        Me.song3.Name = "song3"
        Me.song3.Size = New System.Drawing.Size(334, 30)
        Me.song3.TabIndex = 20
        '
        'song4
        '
        Me.song4.AutoSize = True
        Me.song4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.song4.Location = New System.Drawing.Point(93, 90)
        Me.song4.Name = "song4"
        Me.song4.Size = New System.Drawing.Size(334, 30)
        Me.song4.TabIndex = 21
        '
        'savePath
        '
        Me.savePath.AutoSize = True
        Me.savePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.savePath.Location = New System.Drawing.Point(93, 120)
        Me.savePath.Name = "savePath"
        Me.savePath.Size = New System.Drawing.Size(334, 30)
        Me.savePath.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(493, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "制作"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel1.Location = New System.Drawing.Point(433, 150)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(54, 39)
        Me.LinkLabel1.TabIndex = 24
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "作者博客"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabel2.Location = New System.Drawing.Point(93, 150)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(334, 39)
        Me.LinkLabel2.TabIndex = 25
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "室内操交流群"
        '
        'opSong1
        '
        Me.opSong1.FileName = "OpenFileDialog1"
        Me.opSong1.Filter = "MP3 音频|*.mp3"
        Me.opSong1.Title = "选择第一首歌"
        '
        'opSong2
        '
        Me.opSong2.FileName = "OpenFileDialog1"
        Me.opSong2.Filter = "MP3 音频|*.mp3"
        '
        'opSong3
        '
        Me.opSong3.FileName = "OpenFileDialog2"
        Me.opSong3.Filter = "MP3 音频|*.mp3"
        '
        'opSong4
        '
        Me.opSong4.FileName = "OpenFileDialog3"
        Me.opSong4.Filter = "MP3 音频|*.mp3"
        '
        'sfOut
        '
        Me.sfOut.DefaultExt = "mkv"
        Me.sfOut.FileName = "室内操"
        Me.sfOut.Filter = "室内操|*.mkv"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 189)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "室内操工厂 1.1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents brSong1 As Button
    Friend WithEvents brSong2 As Button
    Friend WithEvents brSong3 As Button
    Friend WithEvents brSong4 As Button
    Friend WithEvents opSong1 As OpenFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents brSave As Button
    Friend WithEvents clSong1 As Button
    Friend WithEvents clSong2 As Button
    Friend WithEvents clSong3 As Button
    Friend WithEvents clSong4 As Button
    Friend WithEvents song1 As Label
    Friend WithEvents song2 As Label
    Friend WithEvents song3 As Label
    Friend WithEvents song4 As Label
    Friend WithEvents savePath As Label
    Friend WithEvents opSong2 As OpenFileDialog
    Friend WithEvents opSong3 As OpenFileDialog
    Friend WithEvents opSong4 As OpenFileDialog
    Friend WithEvents sfOut As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
