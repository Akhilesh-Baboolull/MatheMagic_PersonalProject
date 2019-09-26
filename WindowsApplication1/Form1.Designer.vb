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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pb1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pb2 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.count = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(-3, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(556, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "There's a hidden button somewhere to activate the program...."
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(36, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 43)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Find The"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(154, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 43)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "BUTTON"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(275, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 42)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To Start the Fun!!"
        Me.Label5.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(66, 392)
        Me.pb1.Maximum = 5
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(270, 18)
        Me.pb1.TabIndex = 6
        Me.pb1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(66, 416)
        Me.pb2.Maximum = 15
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(270, 18)
        Me.pb2.TabIndex = 7
        Me.pb2.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Limelight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(492, 416)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 36)
        Me.Label6.TabIndex = 8
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Button1.Location = New System.Drawing.Point(168, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Let's Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'count
        '
        Me.count.BackColor = System.Drawing.Color.Transparent
        Me.count.Font = New System.Drawing.Font("Limelight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count.Location = New System.Drawing.Point(473, 400)
        Me.count.Name = "count"
        Me.count.Size = New System.Drawing.Size(69, 41)
        Me.count.TabIndex = 11
        Me.count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(551, 451)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.Visible = False
        Me.LineShape2.X1 = 256
        Me.LineShape2.X2 = 350
        Me.LineShape2.Y1 = 286
        Me.LineShape2.Y2 = 328
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.Visible = False
        Me.LineShape1.X1 = 273
        Me.LineShape1.X2 = 162
        Me.LineShape1.Y1 = 283
        Me.LineShape1.Y2 = 284
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(277, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 66)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "It was here all the time!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "How Did you miss it??"
        Me.Label7.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(32, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 65)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome to MatheMagic"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(551, 451)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.count)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MatheMagic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents pb2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents count As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
