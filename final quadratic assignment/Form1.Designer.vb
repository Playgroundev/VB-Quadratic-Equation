<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.btncompute = New System.Windows.Forms.Button()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Label()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter A:"
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(73, 109)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(75, 23)
        Me.btncompute.TabIndex = 16
        Me.btncompute.Text = "Compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(73, 138)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(282, 20)
        Me.txtresult.TabIndex = 15
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(27, 145)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(40, 13)
        Me.Result.TabIndex = 14
        Me.Result.Text = "Result:"
        '
        'TxtC
        '
        Me.TxtC.Location = New System.Drawing.Point(73, 82)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(100, 20)
        Me.TxtC.TabIndex = 13
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(73, 54)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(100, 20)
        Me.TxtB.TabIndex = 12
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(73, 21)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(100, 20)
        Me.TxtA.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Enter C:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter B:"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 261)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents txtresult As System.Windows.Forms.TextBox
    Friend WithEvents Result As System.Windows.Forms.Label
    Friend WithEvents TxtC As System.Windows.Forms.TextBox
    Friend WithEvents TxtB As System.Windows.Forms.TextBox
    Friend WithEvents TxtA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
