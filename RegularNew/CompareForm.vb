

Public Class CompareForm


    Public Sub CompareForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userarray() As String = RegForm.userTextget()
        Dim mas() As String = RegForm.arrgood(RegForm.txtgettext.Text.Split)
        Dim k As Integer = 0
        Dim j As Integer = 0


        If userarray.Length < RegForm.val_number + 1 Then
            MsgBox("Недостатньо слів у вашому тексті")
        End If
        If userarray.Length > RegForm.val_number + 1 Then
            MsgBox("Забагато слів у вашому тексті")
        End If

        For Each word As String In mas
            For i = 0 To RegForm.val_number
                If word = RegForm.val_words(i) Then
                    j += 1
                    If k < userarray.Length Then

                        If (word = userarray(k)) Then
                            datacompare.Rows.Add(j, word, "     =", userarray(k))

                            'datacompare.Rows Then[j].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                            k += 1
                                Exit For
                            Else
                                datacompare.Rows.Add(j, word, "     !=", userarray(k))
                            k += 1
                            Exit For
                        End If
                    Else
                        datacompare.Rows.Add(j, word, "   ???", " - - -")
                        Exit For
                    End If

                End If
            Next
        Next
        For i = 0 To datacompare.Rows.Count - 2
            'For i = 0 To 5


            With datacompare.Rows(i)
                If .Cells("equals").Value = "     !=" Then
                    .DefaultCellStyle.BackColor = Color.LightPink
                ElseIf .Cells("equals").Value = "     =" Then
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

    End Sub


End Class