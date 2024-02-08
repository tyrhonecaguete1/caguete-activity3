<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        firstnum = New TextBox()
        firstnumber = New Label()
        secondnumber = New Label()
        secondnum = New TextBox()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' firstnum
        ' 
        firstnum.Location = New Point(204, 61)
        firstnum.Name = "firstnum"
        firstnum.Size = New Size(100, 23)
        firstnum.TabIndex = 0
        ' 
        ' firstnumber
        ' 
        firstnumber.AutoSize = True
        firstnumber.Location = New Point(129, 69)
        firstnumber.Name = "firstnumber"
        firstnumber.Size = New Size(69, 15)
        firstnumber.TabIndex = 1
        firstnumber.Text = "firstnumber"
        ' 
        ' secondnumber
        ' 
        secondnumber.AutoSize = True
        secondnumber.Location = New Point(111, 119)
        secondnumber.Name = "secondnumber"
        secondnumber.Size = New Size(87, 15)
        secondnumber.TabIndex = 2
        secondnumber.Text = "secondnumber"
        ' 
        ' secondnum
        ' 
        secondnum.Location = New Point(204, 116)
        secondnum.Name = "secondnum"
        secondnum.Size = New Size(100, 23)
        secondnum.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(229, 169)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 23)
        Button1.TabIndex = 4
        Button1.Text = "multiplication"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(129, 226)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(36, 15)
        lblResult.TabIndex = 5
        lblResult.Text = "result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(secondnum)
        Controls.Add(secondnumber)
        Controls.Add(firstnumber)
        Controls.Add(firstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstnum As TextBox
    Friend WithEvents firstnumber As Label
    Friend WithEvents secondnumber As Label
    Friend WithEvents secondnum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
