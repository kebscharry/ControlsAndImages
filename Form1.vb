Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'adding two numbers in two text boxes
        MsgBox("The sum is" & Val(txtInput1.Text) + Val(txtInput2.Text))

        REM Displaying output on a label
        lblAnswer.Text = Val(txtInput1.Text) + Val(txtInput2.Text)

        'adding an item to a listbox
        lstBox1.Items.Add("Nokia")


        ' adding items to a listbox via an input box
        Dim myitem = InputBox("Enter your item: ")
        lstBox1.Items.Add(myitem)

    End Sub

    Private Sub btnComputr_Click(sender As Object, e As EventArgs) Handles btnComputr.Click

        'creating geometric progression
        Dim x, n, num As Double
        Dim r As Double
        x = txtFirst.Text
        r = txtCommon.Text
        num = txtNoOfTerms.Text
        lstGenNumbers.Items.Add("n" & vbTab & "x")
        lstGenNumbers.Items.Add("__________")

        n = 1

        Do
            x = x * r
            lstGenNumbers.Items.Add(n & vbTab & x)
            n = n + 1

        Loop Until n = num + 1

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear list
        lstGenNumbers.Items.Clear()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click


        'removing items
        lstBox1.Items.Remove("Ipad")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'deleting an item

        Dim delitem
        delitem = InputBox("Enter your item for deletion: ")
        lstBox1.Items.Remove(delitem)

    End Sub

    Private Sub btnDelSelectedItem_Click(sender As Object, e As EventArgs) Handles btnDelSelectedItem.Click

        'remove selected item
        lstBox1.Items.Remove(lstBox1.SelectedItem)
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click

        'delete multiple items
        If lstBox1.SelectedItems.Count > 0 Then
            For n As Integer = lstBox1.SelectedItems.Count - 1 To 0

                'remove the current selected items from the listbox
                lstBox1.Items.Remove(lstBox1.SelectedItems(n))


            Next n

        End If

    End Sub

    Private Sub btnClList_Click(sender As Object, e As EventArgs) Handles btnClList.Click

        'clear the entire list
        lstBox1.Items.Clear()

    End Sub

    Private Sub btnAddCombo_Click(sender As Object, e As EventArgs) Handles btnAddCombo.Click
        ' adding items to combo box

        ComboBox1.Items.Add("A15")

        'allow user to add items via input box
        Dim comboitems
        comboitems = InputBox("Enter your item")
        ComboBox1.Items.Add(comboitems)

    End Sub

    Private Sub btnRemoveCombo_Click(sender As Object, e As EventArgs) Handles btnRemoveCombo.Click

        ComboBox1.Items.Remove("iphone")
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)

    End Sub

    Private Sub btnClearCombo_Click(sender As Object, e As EventArgs) Handles btnClearCombo.Click

        ComboBox1.Items.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox2.Image = Image.FromFile("D:\images\download (1).jfif ")

    End Sub

    Private Sub OFGSelectImage_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFGSelectImage.FileOk

    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        If OFGSelectImage.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class
