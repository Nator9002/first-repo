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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblResult = New Label()
        bttnResult = New Button()
        bttnExit = New Button()
        bttnClear = New Button()
        txtName = New TextBox()
        txtWeight = New TextBox()
        lblName = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblPrice = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 25)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to Eat-A-Lot Resturant"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(45, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 21)
        Label2.TabIndex = 2
        Label2.Text = "Order name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(45, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 21)
        Label3.TabIndex = 3
        Label3.Text = "Plate weight:"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 12F)
        lblResult.Location = New Point(188, 326)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(40, 21)
        lblResult.TabIndex = 6
        lblResult.Text = "0 kg"
        lblResult.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' bttnResult
        ' 
        bttnResult.Location = New Point(227, 257)
        bttnResult.Name = "bttnResult"
        bttnResult.Size = New Size(75, 23)
        bttnResult.TabIndex = 7
        bttnResult.Text = "Confirm"
        bttnResult.UseVisualStyleBackColor = True
        ' 
        ' bttnExit
        ' 
        bttnExit.BackgroundImage = CType(resources.GetObject("bttnExit.BackgroundImage"), Image)
        bttnExit.BackgroundImageLayout = ImageLayout.Zoom
        bttnExit.Location = New Point(322, 3)
        bttnExit.Name = "bttnExit"
        bttnExit.Size = New Size(39, 45)
        bttnExit.TabIndex = 8
        bttnExit.UseVisualStyleBackColor = True
        ' 
        ' bttnClear
        ' 
        bttnClear.Location = New Point(45, 257)
        bttnClear.Name = "bttnClear"
        bttnClear.Size = New Size(75, 23)
        bttnClear.TabIndex = 9
        bttnClear.Text = "Clear"
        bttnClear.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(163, 168)
        txtName.Name = "txtName"
        txtName.Size = New Size(139, 23)
        txtName.TabIndex = 10
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(163, 213)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(139, 23)
        txtWeight.TabIndex = 11
        ' 
        ' lblName
        ' 
        lblName.Font = New Font("Segoe UI", 12F)
        lblName.Location = New Point(45, 294)
        lblName.Name = "lblName"
        lblName.Size = New Size(257, 21)
        lblName.TabIndex = 12
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(81, 326)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 21)
        Label4.TabIndex = 13
        Label4.Text = "Weight:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(81, 356)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 21)
        Label5.TabIndex = 14
        Label5.Text = "Price:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 12F)
        lblPrice.Location = New Point(188, 356)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 21)
        lblPrice.TabIndex = 15
        lblPrice.Text = "R 0"
        lblPrice.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(361, 450)
        Controls.Add(lblPrice)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lblName)
        Controls.Add(txtWeight)
        Controls.Add(txtName)
        Controls.Add(bttnClear)
        Controls.Add(bttnExit)
        Controls.Add(bttnResult)
        Controls.Add(lblResult)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents bttnResult As Button
    Friend WithEvents bttnExit As Button
    Friend WithEvents bttnClear As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrice As Label

End Class
