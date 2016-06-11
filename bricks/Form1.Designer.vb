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
        Me.minge = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bara = New System.Windows.Forms.Button()
        Me.scr = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IesireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'minge
        '
        Me.minge.BackColor = System.Drawing.Color.Lime
        Me.minge.Enabled = False
        Me.minge.Location = New System.Drawing.Point(324, 331)
        Me.minge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.minge.Name = "minge"
        Me.minge.Size = New System.Drawing.Size(32, 30)
        Me.minge.TabIndex = 0
        Me.minge.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'bara
        '
        Me.bara.Location = New System.Drawing.Point(237, 566)
        Me.bara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bara.Name = "bara"
        Me.bara.Size = New System.Drawing.Size(175, 28)
        Me.bara.TabIndex = 1
        Me.bara.UseVisualStyleBackColor = True
        '
        'scr
        '
        Me.scr.AutoSize = True
        Me.scr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scr.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.scr.Location = New System.Drawing.Point(299, 30)
        Me.scr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.scr.Name = "scr"
        Me.scr.Size = New System.Drawing.Size(81, 32)
        Me.scr.TabIndex = 2
        Me.scr.Text = "Scor:"
        Me.scr.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.InfoToolStripMenuItem1, Me.AutorToolStripMenuItem, Me.IesireToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(691, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem1, Me.RestartToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StartToolStripMenuItem1
        '
        Me.StartToolStripMenuItem1.Name = "StartToolStripMenuItem1"
        Me.StartToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.StartToolStripMenuItem1.Text = "Start"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Enabled = False
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'InfoToolStripMenuItem1
        '
        Me.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1"
        Me.InfoToolStripMenuItem1.Size = New System.Drawing.Size(47, 24)
        Me.InfoToolStripMenuItem1.Text = "Info"
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.AutorToolStripMenuItem.Text = "Autor"
        '
        'IesireToolStripMenuItem
        '
        Me.IesireToolStripMenuItem.Name = "IesireToolStripMenuItem"
        Me.IesireToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.IesireToolStripMenuItem.Text = "Iesire"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = Global.bricks.My.Resources.Resources.brick
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 516)
        Me.Controls.Add(Me.scr)
        Me.Controls.Add(Me.bara)
        Me.Controls.Add(Me.minge)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bricks"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents minge As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bara As System.Windows.Forms.Button
    Friend WithEvents scr As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IesireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
