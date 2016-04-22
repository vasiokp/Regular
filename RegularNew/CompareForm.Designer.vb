<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompareForm
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
        Me.datacompare = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.myword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equals1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yourword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datacompare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datacompare
        '
        Me.datacompare.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.datacompare.ColumnHeadersHeight = 25
        Me.datacompare.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.myword, Me.equals1, Me.yourword})
        Me.datacompare.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.datacompare.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.datacompare.Location = New System.Drawing.Point(12, 12)
        Me.datacompare.Name = "datacompare"
        Me.datacompare.ReadOnly = True
        Me.datacompare.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.datacompare.RowHeadersVisible = False
        Me.datacompare.RowTemplate.ReadOnly = True
        Me.datacompare.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datacompare.Size = New System.Drawing.Size(600, 350)
        Me.datacompare.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "№"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id.Width = 30
        '
        'myword
        '
        Me.myword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.myword.HeaderText = "Слова які відповідають масці із програми"
        Me.myword.Name = "myword"
        Me.myword.ReadOnly = True
        Me.myword.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.myword.Width = 242
        '
        'equals1
        '
        Me.equals1.HeaderText = "Рівність"
        Me.equals1.Name = "equals1"
        Me.equals1.ReadOnly = True
        Me.equals1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.equals1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.equals1.Width = 50
        '
        'yourword
        '
        Me.yourword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.yourword.HeaderText = "Ваші слова"
        Me.yourword.Name = "yourword"
        Me.yourword.ReadOnly = True
        Me.yourword.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.yourword.Width = 88
        '
        'CompareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 377)
        Me.Controls.Add(Me.datacompare)
        Me.Name = "CompareForm"
        Me.Text = "Форма порівняння "
        CType(Me.datacompare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datacompare As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents myword As DataGridViewTextBoxColumn
    Friend WithEvents equals1 As DataGridViewTextBoxColumn
    Friend WithEvents yourword As DataGridViewTextBoxColumn
End Class
