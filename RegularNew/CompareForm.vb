

Public Class CompareForm


    Public Sub CompareForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userarray() As String = RegForm.userTextget()
        Dim mas() As String = RegForm.arrgood(RegForm.txtgettext.Text.Split)
		Dim j As Integer = 0
		Dim isAdded As Boolean = False
		Dim score As Integer = 0
		Dim userAray As List(Of String) = userarray.ToList
		If userarray.Length < RegForm.val_number + 1 Then
            MsgBox("Недостатньо слів у вашому тексті")
        End If
        If userarray.Length > RegForm.val_number + 1 Then
            MsgBox("Забагато слів у вашому тексті")
        End If

		For Each correctWord As String In RegForm.val_words
			j += 1
			For Each userWord As String In userAray
				If (userWord = correctWord) Then
					datacompare.Rows.Add(j, correctWord, "     =", userWord)
					score += 1
					isAdded = True
					userAray.Remove(correctWord)
					Exit For
				Else
					isAdded = False
				End If

			Next
			If (isAdded = False) Then datacompare.Rows.Add(j, correctWord, "     !=", "Не знайденно!")


		Next

		For i = 0 To datacompare.Rows.Count - 2

            With datacompare.Rows(i)
                If .Cells("equals1").Value = "     !=" Then
                    .DefaultCellStyle.BackColor = Color.LightPink
                ElseIf .Cells("equals1").Value = "     =" Then
                    .DefaultCellStyle.BackColor = Color.LightGreen
                Else
                    .DefaultCellStyle.BackColor = Color.LightYellow
                End If
            End With

        Next

        If datacompare.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) < 700 Then
            datacompare.Width = datacompare.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 18
            Width = datacompare.Width + 18
        Else
            Width = datacompare.Width + 18
        End If
        If score = RegForm.val_number + 1 Then
            MsgBox("Усі слова співпали")
        ElseIf score = 0 Then
            MsgBox("Не має співпадань")
        Else
            MsgBox("Тількі " + CStr(score) + " із " + CStr(RegForm.val_number + 1) + " слів спiвпадають")
        End If
    End Sub


End Class