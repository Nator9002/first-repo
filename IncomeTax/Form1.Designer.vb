<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        txtAmount = New TextBox()
        bttnCancel = New Button()
        bttnConfirm = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 25)
        Label1.TabIndex = 0
        Label1.Text = "Income Tax Generator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 1
        Label2.Text = "Amount Saved:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(149, 57)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(133, 23)
        txtAmount.TabIndex = 2
        ' 
        ' bttnCancel
        ' 
        bttnCancel.Location = New Point(12, 115)
        bttnCancel.Name = "bttnCancel"
        bttnCancel.Size = New Size(75, 23)
        bttnCancel.TabIndex = 3
        bttnCancel.Text = "Cancel"
        bttnCancel.UseVisualStyleBackColor = True
        ' 
        ' bttnConfirm
        ' 
        bttnConfirm.Location = New Point(207, 115)
        bttnConfirm.Name = "bttnConfirm"
        bttnConfirm.Size = New Size(75, 23)
        bttnConfirm.TabIndex = 4
        bttnConfirm.Text = "Confirm"
        bttnConfirm.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(299, 175)
        Controls.Add(bttnConfirm)
        Controls.Add(bttnCancel)
        Controls.Add(txtAmount)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents bttnCancel As Button
    Friend WithEvents bttnConfirm As Button

End Class
