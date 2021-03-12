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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._Baseball__1_DataSet = New LabDatabaseJoiningandDisplaying._Baseball__1_DataSet()
        Me.PlayersTableAdapter = New LabDatabaseJoiningandDisplaying._Baseball__1_DataSetTableAdapters.PlayersTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamsTableAdapter = New LabDatabaseJoiningandDisplaying._Baseball__1_DataSetTableAdapters.TeamsTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Baseball__1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(71, 67)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(209, 303)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(471, 67)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(201, 303)
        Me.ListBox2.TabIndex = 1
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Players"
        Me.BindingSource1.DataSource = Me._Baseball__1_DataSet
        '
        '_Baseball__1_DataSet
        '
        Me._Baseball__1_DataSet.DataSetName = "_Baseball__1_DataSet"
        Me._Baseball__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Teams"
        Me.BindingSource2.DataSource = Me._Baseball__1_DataSet
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Baseball__1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents _Baseball__1_DataSet As _Baseball__1_DataSet
    Friend WithEvents PlayersTableAdapter As _Baseball__1_DataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents TeamsTableAdapter As _Baseball__1_DataSetTableAdapters.TeamsTableAdapter
End Class
