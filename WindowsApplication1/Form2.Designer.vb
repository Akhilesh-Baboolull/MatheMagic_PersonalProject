<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.selected = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pb2 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbh = New System.Windows.Forms.ProgressBar()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hi, Welcome to my Magical World..."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Did you know you are really Special!"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(13, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Let me Show you...."
        Me.Label3.Visible = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(1, 165)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(556, 12)
        Me.pb1.TabIndex = 3
        Me.pb1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'selected
        '
        Me.selected.BackColor = System.Drawing.Color.Transparent
        Me.selected.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selected.ForeColor = System.Drawing.Color.Red
        Me.selected.Location = New System.Drawing.Point(251, 350)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(154, 36)
        Me.selected.TabIndex = 5
        Me.selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.selected.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(13, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Enter Your Date Of Birth :"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(13, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Your Selected Date Is :"
        Me.Label5.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button1.Location = New System.Drawing.Point(183, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Submit Date Of Birth"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(1, 262)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(556, 22)
        Me.pb2.TabIndex = 9
        Me.pb2.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(-4, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(558, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Let's Take Some Of Your Precious Moments To Load And Process..."
        Me.Label6.Visible = False
        '
        'pbh
        '
        Me.pbh.Location = New System.Drawing.Point(334, 453)
        Me.pbh.Maximum = 4
        Me.pbh.Name = "pbh"
        Me.pbh.Size = New System.Drawing.Size(211, 11)
        Me.pbh.TabIndex = 11
        Me.pbh.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(299, 218)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 24)
        Me.DateTimePicker1.TabIndex = 12
        Me.DateTimePicker1.Value = New Date(2018, 1, 18, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(556, 480)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.pbh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MatheMagic"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents selected As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pb2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pbh As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
