<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
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
        Me.datahelp = New System.Windows.Forms.DataGridView()
        Me.var = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symbols = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datahelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datahelp
        '
        Me.datahelp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datahelp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.var, Me.symbols})
        Me.datahelp.Location = New System.Drawing.Point(12, 12)
        Me.datahelp.Name = "datahelp"
        Me.datahelp.RowHeadersWidth = 10
        Me.datahelp.RowTemplate.ReadOnly = True
        Me.datahelp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datahelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datahelp.Size = New System.Drawing.Size(310, 454)
        Me.datahelp.TabIndex = 0
        '
        'var
        '
        Me.var.HeaderText = "Варіант"
        Me.var.Name = "var"
        Me.var.ReadOnly = True
        Me.var.Width = 50
        '
        'symbols
        '
        Me.symbols.HeaderText = "Допустимі символи"
        Me.symbols.Name = "symbols"
        Me.symbols.ReadOnly = True
        Me.symbols.Width = 250
        '
        'HelpForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(335, 478)
        Me.Controls.Add(Me.datahelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "HelpForm"
        Me.Text = "Довідка"
        CType(Me.datahelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datahelp As DataGridView
    Friend WithEvents var As DataGridViewTextBoxColumn
    Friend WithEvents symbols As DataGridViewTextBoxColumn
End Class
