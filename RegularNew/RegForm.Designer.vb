<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegForm))
        Me.lblgetmask = New System.Windows.Forms.Label()
        Me.txtgetmask = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnrun = New System.Windows.Forms.Button()
        Me.txtgettext = New System.Windows.Forms.TextBox()
        Me.txtvar = New System.Windows.Forms.TextBox()
        Me.lblvar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtval = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.chkdiagnostic = New System.Windows.Forms.CheckBox()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnfopen = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblsikret = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblgetmask
        '
        Me.lblgetmask.AutoSize = True
        Me.lblgetmask.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblgetmask.Location = New System.Drawing.Point(101, 81)
        Me.lblgetmask.Name = "lblgetmask"
        Me.lblgetmask.Size = New System.Drawing.Size(170, 19)
        Me.lblgetmask.TabIndex = 0
        Me.lblgetmask.Text = "Сгенерована маска: "
        '
        'txtgetmask
        '
        Me.txtgetmask.BackColor = System.Drawing.SystemColors.Control
        Me.txtgetmask.Enabled = False
        Me.txtgetmask.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtgetmask.Location = New System.Drawing.Point(23, 103)
        Me.txtgetmask.Multiline = True
        Me.txtgetmask.Name = "txtgetmask"
        Me.txtgetmask.ReadOnly = True
        Me.txtgetmask.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtgetmask.Size = New System.Drawing.Size(349, 25)
        Me.txtgetmask.TabIndex = 3
        Me.txtgetmask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnclose.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnclose.Location = New System.Drawing.Point(154, 394)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(88, 26)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Закрити"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnrun
        '
        Me.btnrun.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnrun.Location = New System.Drawing.Point(208, 11)
        Me.btnrun.Name = "btnrun"
        Me.btnrun.Size = New System.Drawing.Size(110, 24)
        Me.btnrun.TabIndex = 2
        Me.btnrun.Text = "Згенерувати"
        Me.btnrun.UseVisualStyleBackColor = True
        '
        'txtgettext
        '
        Me.txtgettext.Enabled = False
        Me.txtgettext.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtgettext.Location = New System.Drawing.Point(12, 176)
        Me.txtgettext.Multiline = True
        Me.txtgettext.Name = "txtgettext"
        Me.txtgettext.ReadOnly = True
        Me.txtgettext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtgettext.Size = New System.Drawing.Size(375, 141)
        Me.txtgettext.TabIndex = 4
        '
        'txtvar
        '
        Me.txtvar.Location = New System.Drawing.Point(154, 11)
        Me.txtvar.Name = "txtvar"
        Me.txtvar.Size = New System.Drawing.Size(48, 20)
        Me.txtvar.TabIndex = 1
        '
        'lblvar
        '
        Me.lblvar.AutoSize = True
        Me.lblvar.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblvar.Location = New System.Drawing.Point(75, 9)
        Me.lblvar.Name = "lblvar"
        Me.lblvar.Size = New System.Drawing.Size(73, 19)
        Me.lblvar.TabIndex = 6
        Me.lblvar.Text = "Варіант:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Сгенерований текст:"
        '
        'txtval
        '
        Me.txtval.Location = New System.Drawing.Point(474, 82)
        Me.txtval.Multiline = True
        Me.txtval.Name = "txtval"
        Me.txtval.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtval.Size = New System.Drawing.Size(294, 111)
        Me.txtval.TabIndex = 8
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(526, 264)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(201, 20)
        Me.txt.TabIndex = 10
        '
        'chkdiagnostic
        '
        Me.chkdiagnostic.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkdiagnostic.AutoSize = True
        Me.chkdiagnostic.BackColor = System.Drawing.Color.Red
        Me.chkdiagnostic.Location = New System.Drawing.Point(-1, 426)
        Me.chkdiagnostic.Name = "chkdiagnostic"
        Me.chkdiagnostic.Size = New System.Drawing.Size(6, 6)
        Me.chkdiagnostic.TabIndex = 12
        Me.chkdiagnostic.UseVisualStyleBackColor = False
        '
        'btnhelp
        '
        Me.btnhelp.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnhelp.Location = New System.Drawing.Point(247, 46)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(71, 23)
        Me.btnhelp.TabIndex = 14
        Me.btnhelp.Text = "Довідка"
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(675, 208)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(32, 20)
        Me.txt1.TabIndex = 15
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Підсказка"
        '
        'btnfopen
        '
        Me.btnfopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfopen.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnfopen.Location = New System.Drawing.Point(118, 342)
        Me.btnfopen.Name = "btnfopen"
        Me.btnfopen.Size = New System.Drawing.Size(166, 23)
        Me.btnfopen.TabIndex = 16
        Me.btnfopen.Text = "Файл для перевірки"
        Me.btnfopen.UseVisualStyleBackColor = True
        Me.btnfopen.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblsikret
        '
        Me.lblsikret.AutoSize = True
        Me.lblsikret.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblsikret.Location = New System.Drawing.Point(470, 31)
        Me.lblsikret.Name = "lblsikret"
        Me.lblsikret.Size = New System.Drawing.Size(298, 38)
        Me.lblsikret.TabIndex = 17
        Me.lblsikret.Text = "Слова що задовільняють маску" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(але не в тому порядку що в тексті!!)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(557, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Розбиття маски"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(583, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "К-сть слів"
        '
        'RegForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(849, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblsikret)
        Me.Controls.Add(Me.btnfopen)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.chkdiagnostic)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.txtval)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblvar)
        Me.Controls.Add(Me.txtvar)
        Me.Controls.Add(Me.txtgettext)
        Me.Controls.Add(Me.btnrun)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.txtgetmask)
        Me.Controls.Add(Me.lblgetmask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RegForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Програма для здачі лабораторної"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblgetmask As Label
    Friend WithEvents txtgetmask As TextBox
    Friend WithEvents btnclose As Button
    Friend WithEvents btnrun As Button
    Friend WithEvents txtgettext As TextBox
    Friend WithEvents txtvar As TextBox
    Friend WithEvents lblvar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtval As TextBox
    Friend WithEvents txt As TextBox
    Friend WithEvents chkdiagnostic As CheckBox
    Friend WithEvents btnhelp As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnfopen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblsikret As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
