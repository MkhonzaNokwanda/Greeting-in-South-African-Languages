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
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.lblHomeLanguage = New System.Windows.Forms.Label()
        Me.txtMotherTongue = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(224, 142)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(254, 84)
        Me.btnGreet.TabIndex = 0
        Me.btnGreet.Text = "Your Tribe Greeting"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'lblHomeLanguage
        '
        Me.lblHomeLanguage.AutoSize = True
        Me.lblHomeLanguage.Location = New System.Drawing.Point(220, 93)
        Me.lblHomeLanguage.Name = "lblHomeLanguage"
        Me.lblHomeLanguage.Size = New System.Drawing.Size(128, 20)
        Me.lblHomeLanguage.TabIndex = 1
        Me.lblHomeLanguage.Text = "Home Language"
        '
        'txtMotherTongue
        '
        Me.txtMotherTongue.Location = New System.Drawing.Point(378, 87)
        Me.txtMotherTongue.Name = "txtMotherTongue"
        Me.txtMotherTongue.Size = New System.Drawing.Size(100, 26)
        Me.txtMotherTongue.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(378, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 26)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(255, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtMotherTongue)
        Me.Controls.Add(Me.lblHomeLanguage)
        Me.Controls.Add(Me.btnGreet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGreet As Button
    Friend WithEvents lblHomeLanguage As Label
    Friend WithEvents txtMotherTongue As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
End Class
