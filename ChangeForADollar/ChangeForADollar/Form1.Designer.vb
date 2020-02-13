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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl25c = New System.Windows.Forms.Label()
        Me.lbl10c = New System.Windows.Forms.Label()
        Me.lbl5c = New System.Windows.Forms.Label()
        Me.lbl1c = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txt25c = New System.Windows.Forms.TextBox()
        Me.txt10c = New System.Windows.Forms.TextBox()
        Me.txt5c = New System.Windows.Forms.TextBox()
        Me.txt1c = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Amount (cents)"
        '
        'lbl25c
        '
        Me.lbl25c.AutoSize = True
        Me.lbl25c.Location = New System.Drawing.Point(118, 88)
        Me.lbl25c.Name = "lbl25c"
        Me.lbl25c.Size = New System.Drawing.Size(25, 13)
        Me.lbl25c.TabIndex = 1
        Me.lbl25c.Text = "25c"
        '
        'lbl10c
        '
        Me.lbl10c.AutoSize = True
        Me.lbl10c.Location = New System.Drawing.Point(118, 120)
        Me.lbl10c.Name = "lbl10c"
        Me.lbl10c.Size = New System.Drawing.Size(25, 13)
        Me.lbl10c.TabIndex = 2
        Me.lbl10c.Text = "10c"
        '
        'lbl5c
        '
        Me.lbl5c.AutoSize = True
        Me.lbl5c.Location = New System.Drawing.Point(124, 152)
        Me.lbl5c.Name = "lbl5c"
        Me.lbl5c.Size = New System.Drawing.Size(19, 13)
        Me.lbl5c.TabIndex = 3
        Me.lbl5c.Text = "5c"
        '
        'lbl1c
        '
        Me.lbl1c.AutoSize = True
        Me.lbl1c.Location = New System.Drawing.Point(124, 184)
        Me.lbl1c.Name = "lbl1c"
        Me.lbl1c.Size = New System.Drawing.Size(19, 13)
        Me.lbl1c.TabIndex = 4
        Me.lbl1c.Text = "1c"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(149, 36)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 5
        '
        'txt25c
        '
        Me.txt25c.Location = New System.Drawing.Point(149, 85)
        Me.txt25c.Name = "txt25c"
        Me.txt25c.ReadOnly = True
        Me.txt25c.Size = New System.Drawing.Size(100, 20)
        Me.txt25c.TabIndex = 6
        '
        'txt10c
        '
        Me.txt10c.Location = New System.Drawing.Point(149, 117)
        Me.txt10c.Name = "txt10c"
        Me.txt10c.ReadOnly = True
        Me.txt10c.Size = New System.Drawing.Size(100, 20)
        Me.txt10c.TabIndex = 7
        '
        'txt5c
        '
        Me.txt5c.Location = New System.Drawing.Point(149, 149)
        Me.txt5c.Name = "txt5c"
        Me.txt5c.ReadOnly = True
        Me.txt5c.Size = New System.Drawing.Size(100, 20)
        Me.txt5c.TabIndex = 8
        '
        'txt1c
        '
        Me.txt1c.Location = New System.Drawing.Point(149, 181)
        Me.txt1c.Name = "txt1c"
        Me.txt1c.ReadOnly = True
        Me.txt1c.Size = New System.Drawing.Size(100, 20)
        Me.txt1c.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(162, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 40)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Change"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 305)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txt1c)
        Me.Controls.Add(Me.txt5c)
        Me.Controls.Add(Me.txt10c)
        Me.Controls.Add(Me.txt25c)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lbl1c)
        Me.Controls.Add(Me.lbl5c)
        Me.Controls.Add(Me.lbl10c)
        Me.Controls.Add(Me.lbl25c)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Change For A Dollar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl25c As Label
    Friend WithEvents lbl10c As Label
    Friend WithEvents lbl5c As Label
    Friend WithEvents lbl1c As Label
    Private WithEvents txtAmount As TextBox
    Private WithEvents txt25c As TextBox
    Private WithEvents txt10c As TextBox
    Private WithEvents txt5c As TextBox
    Private WithEvents txt1c As TextBox
    Friend WithEvents btnCalculate As Button
End Class
