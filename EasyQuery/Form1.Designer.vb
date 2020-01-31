<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxDatabases = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTables = New System.Windows.Forms.ComboBox()
        Me.ComboBoxAction = New System.Windows.Forms.ComboBox()
        Me.CheckedListBoxChamps = New System.Windows.Forms.CheckedListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RichTextBoxVisu = New System.Windows.Forms.RichTextBox()
        Me.DataGridViewResult = New System.Windows.Forms.DataGridView()
        Me.ButtonOK = New System.Windows.Forms.Button()
        CType(Me.DataGridViewResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxDatabases
        '
        Me.ComboBoxDatabases.FormattingEnabled = True
        Me.ComboBoxDatabases.Location = New System.Drawing.Point(22, 58)
        Me.ComboBoxDatabases.Name = "ComboBoxDatabases"
        Me.ComboBoxDatabases.Size = New System.Drawing.Size(251, 21)
        Me.ComboBoxDatabases.TabIndex = 0
        '
        'ComboBoxTables
        '
        Me.ComboBoxTables.FormattingEnabled = True
        Me.ComboBoxTables.Location = New System.Drawing.Point(22, 86)
        Me.ComboBoxTables.Name = "ComboBoxTables"
        Me.ComboBoxTables.Size = New System.Drawing.Size(251, 21)
        Me.ComboBoxTables.TabIndex = 1
        '
        'ComboBoxAction
        '
        Me.ComboBoxAction.FormattingEnabled = True
        Me.ComboBoxAction.Items.AddRange(New Object() {"SELECT", "INSERT INTO", "UPDATE", "DELETE"})
        Me.ComboBoxAction.Location = New System.Drawing.Point(22, 114)
        Me.ComboBoxAction.Name = "ComboBoxAction"
        Me.ComboBoxAction.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxAction.TabIndex = 2
        '
        'CheckedListBoxChamps
        '
        Me.CheckedListBoxChamps.CheckOnClick = True
        Me.CheckedListBoxChamps.FormattingEnabled = True
        Me.CheckedListBoxChamps.Location = New System.Drawing.Point(22, 141)
        Me.CheckedListBoxChamps.Name = "CheckedListBoxChamps"
        Me.CheckedListBoxChamps.Size = New System.Drawing.Size(250, 169)
        Me.CheckedListBoxChamps.TabIndex = 3
        '
        'RichTextBoxVisu
        '
        Me.RichTextBoxVisu.Location = New System.Drawing.Point(301, 58)
        Me.RichTextBoxVisu.Name = "RichTextBoxVisu"
        Me.RichTextBoxVisu.Size = New System.Drawing.Size(348, 96)
        Me.RichTextBoxVisu.TabIndex = 4
        Me.RichTextBoxVisu.Text = ""
        '
        'DataGridViewResult
        '
        Me.DataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResult.Location = New System.Drawing.Point(301, 160)
        Me.DataGridViewResult.Name = "DataGridViewResult"
        Me.DataGridViewResult.Size = New System.Drawing.Size(753, 264)
        Me.DataGridViewResult.TabIndex = 5
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(107, 316)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 6
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 454)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.DataGridViewResult)
        Me.Controls.Add(Me.RichTextBoxVisu)
        Me.Controls.Add(Me.CheckedListBoxChamps)
        Me.Controls.Add(Me.ComboBoxAction)
        Me.Controls.Add(Me.ComboBoxTables)
        Me.Controls.Add(Me.ComboBoxDatabases)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxTables As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxAction As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListBoxChamps As System.Windows.Forms.CheckedListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents RichTextBoxVisu As System.Windows.Forms.RichTextBox
    Friend WithEvents DataGridViewResult As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonOK As System.Windows.Forms.Button

End Class
