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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtInput1 = New TextBox()
        txtInput2 = New TextBox()
        btnAdd = New Button()
        lblSum = New Label()
        lblAnswer = New Label()
        lstBox1 = New ListBox()
        txtFirst = New TextBox()
        txtCommon = New TextBox()
        txtNoOfTerms = New TextBox()
        lblFirstTerm = New Label()
        lblCommonRatio = New Label()
        lblNoOfTerms = New Label()
        lstGenNumbers = New ListBox()
        btnComputr = New Button()
        btnClear = New Button()
        btnRemove = New Button()
        btnDelete = New Button()
        btnDelSelectedItem = New Button()
        btnClearAll = New Button()
        btnClList = New Button()
        ComboBox1 = New ComboBox()
        btnAddCombo = New Button()
        btnRemoveCombo = New Button()
        btnClearCombo = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        OFGSelectImage = New OpenFileDialog()
        btnClick = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtInput1
        ' 
        txtInput1.Location = New Point(12, 6)
        txtInput1.Name = "txtInput1"
        txtInput1.Size = New Size(88, 23)
        txtInput1.TabIndex = 0
        ' 
        ' txtInput2
        ' 
        txtInput2.Location = New Point(12, 54)
        txtInput2.Name = "txtInput2"
        txtInput2.Size = New Size(88, 23)
        txtInput2.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 144)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(115, 31)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lblSum
        ' 
        lblSum.AutoSize = True
        lblSum.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSum.Location = New Point(13, 101)
        lblSum.Name = "lblSum"
        lblSum.Size = New Size(44, 17)
        lblSum.TabIndex = 3
        lblSum.Text = "Sum="
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.BackColor = SystemColors.ButtonHighlight
        lblAnswer.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAnswer.ForeColor = SystemColors.ControlText
        lblAnswer.Location = New Point(63, 107)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(0, 17)
        lblAnswer.TabIndex = 4
        ' 
        ' lstBox1
        ' 
        lstBox1.FormattingEnabled = True
        lstBox1.ItemHeight = 15
        lstBox1.Items.AddRange(New Object() {"Iphone", "Ipad", "Samsung Galaxy", "HTC"})
        lstBox1.Location = New Point(136, 6)
        lstBox1.Name = "lstBox1"
        lstBox1.Size = New Size(78, 169)
        lstBox1.TabIndex = 5
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(334, 1)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(106, 23)
        txtFirst.TabIndex = 6
        ' 
        ' txtCommon
        ' 
        txtCommon.Location = New Point(334, 52)
        txtCommon.Name = "txtCommon"
        txtCommon.Size = New Size(106, 23)
        txtCommon.TabIndex = 7
        ' 
        ' txtNoOfTerms
        ' 
        txtNoOfTerms.Location = New Point(334, 101)
        txtNoOfTerms.Name = "txtNoOfTerms"
        txtNoOfTerms.Size = New Size(106, 23)
        txtNoOfTerms.TabIndex = 8
        ' 
        ' lblFirstTerm
        ' 
        lblFirstTerm.AutoSize = True
        lblFirstTerm.Location = New Point(222, 4)
        lblFirstTerm.Name = "lblFirstTerm"
        lblFirstTerm.Size = New Size(58, 15)
        lblFirstTerm.TabIndex = 9
        lblFirstTerm.Text = "First Term"
        ' 
        ' lblCommonRatio
        ' 
        lblCommonRatio.AutoSize = True
        lblCommonRatio.Location = New Point(220, 50)
        lblCommonRatio.Name = "lblCommonRatio"
        lblCommonRatio.Size = New Size(88, 15)
        lblCommonRatio.TabIndex = 10
        lblCommonRatio.Text = "Common Ratio"
        ' 
        ' lblNoOfTerms
        ' 
        lblNoOfTerms.AutoSize = True
        lblNoOfTerms.Location = New Point(222, 101)
        lblNoOfTerms.Name = "lblNoOfTerms"
        lblNoOfTerms.Size = New Size(101, 15)
        lblNoOfTerms.TabIndex = 11
        lblNoOfTerms.Text = "Number Of Terms"
        ' 
        ' lstGenNumbers
        ' 
        lstGenNumbers.FormattingEnabled = True
        lstGenNumbers.ItemHeight = 15
        lstGenNumbers.Location = New Point(456, -1)
        lstGenNumbers.Name = "lstGenNumbers"
        lstGenNumbers.Size = New Size(100, 154)
        lstGenNumbers.TabIndex = 12
        ' 
        ' btnComputr
        ' 
        btnComputr.Location = New Point(222, 145)
        btnComputr.Name = "btnComputr"
        btnComputr.Size = New Size(190, 28)
        btnComputr.TabIndex = 13
        btnComputr.Text = "Compute"
        btnComputr.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(222, 191)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(190, 28)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear List"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(12, 193)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(115, 31)
        btnRemove.TabIndex = 15
        btnRemove.Text = "Remove Items"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(12, 239)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(115, 31)
        btnDelete.TabIndex = 16
        btnDelete.Text = "Delete Item"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnDelSelectedItem
        ' 
        btnDelSelectedItem.Location = New Point(13, 287)
        btnDelSelectedItem.Name = "btnDelSelectedItem"
        btnDelSelectedItem.Size = New Size(115, 31)
        btnDelSelectedItem.TabIndex = 17
        btnDelSelectedItem.Text = "delete a selected item"
        btnDelSelectedItem.UseVisualStyleBackColor = True
        ' 
        ' btnClearAll
        ' 
        btnClearAll.Location = New Point(12, 324)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(115, 41)
        btnClearAll.TabIndex = 18
        btnClearAll.Text = "Clear selected items"
        btnClearAll.UseVisualStyleBackColor = True
        ' 
        ' btnClList
        ' 
        btnClList.Location = New Point(13, 382)
        btnClList.Name = "btnClList"
        btnClList.Size = New Size(130, 22)
        btnClList.TabIndex = 19
        btnClList.Text = "Clear the list"
        btnClList.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(156, 260)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(234, 23)
        ComboBox1.TabIndex = 20
        ComboBox1.Text = "iphone"
        ' 
        ' btnAddCombo
        ' 
        btnAddCombo.Location = New Point(156, 304)
        btnAddCombo.Name = "btnAddCombo"
        btnAddCombo.Size = New Size(83, 34)
        btnAddCombo.TabIndex = 21
        btnAddCombo.Text = "Add Items"
        btnAddCombo.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveCombo
        ' 
        btnRemoveCombo.Location = New Point(259, 305)
        btnRemoveCombo.Name = "btnRemoveCombo"
        btnRemoveCombo.Size = New Size(90, 32)
        btnRemoveCombo.TabIndex = 22
        btnRemoveCombo.Text = "Remove Items"
        btnRemoveCombo.UseVisualStyleBackColor = True
        ' 
        ' btnClearCombo
        ' 
        btnClearCombo.Location = New Point(369, 307)
        btnClearCombo.Name = "btnClearCombo"
        btnClearCombo.Size = New Size(60, 27)
        btnClearCombo.TabIndex = 23
        btnClearCombo.Text = "Clear"
        btnClearCombo.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(587, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 112)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Location = New Point(587, 124)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(146, 112)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' OFGSelectImage
        ' 
        OFGSelectImage.FileName = "OFSelectImage"
        OFGSelectImage.Filter = "JPEG FILES| *.JPG| GIF FILES| *.GIF| Windows Bitmaps| *.BMP "
        ' 
        ' btnClick
        ' 
        btnClick.Location = New Point(670, 298)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(81, 25)
        btnClick.TabIndex = 26
        btnClick.Text = "Click"
        btnClick.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClick)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnClearCombo)
        Controls.Add(btnRemoveCombo)
        Controls.Add(btnAddCombo)
        Controls.Add(ComboBox1)
        Controls.Add(btnClList)
        Controls.Add(btnClearAll)
        Controls.Add(btnDelSelectedItem)
        Controls.Add(btnDelete)
        Controls.Add(btnRemove)
        Controls.Add(btnClear)
        Controls.Add(btnComputr)
        Controls.Add(lstGenNumbers)
        Controls.Add(lblNoOfTerms)
        Controls.Add(lblCommonRatio)
        Controls.Add(lblFirstTerm)
        Controls.Add(txtNoOfTerms)
        Controls.Add(txtCommon)
        Controls.Add(txtFirst)
        Controls.Add(lstBox1)
        Controls.Add(lblAnswer)
        Controls.Add(lblSum)
        Controls.Add(btnAdd)
        Controls.Add(txtInput2)
        Controls.Add(txtInput1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblSum As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lstBox1 As ListBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtCommon As TextBox
    Friend WithEvents txtNoOfTerms As TextBox
    Friend WithEvents lblFirstTerm As Label
    Friend WithEvents lblCommonRatio As Label
    Friend WithEvents lblNoOfTerms As Label
    Friend WithEvents lstGenNumbers As ListBox
    Friend WithEvents btnComputr As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDelSelectedItem As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnClList As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnAddCombo As Button
    Friend WithEvents btnRemoveCombo As Button
    Friend WithEvents btnClearCombo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OFGSelectImage As OpenFileDialog
    Friend WithEvents btnClick As Button

End Class
