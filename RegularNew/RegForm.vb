
Imports System.Text.RegularExpressions
Imports System.IO

Public Class RegForm
    Public smask As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Function truevar() As Boolean
        If OtherReg() Then
            Exit Function
        ElseIf (var = 9) Or (var = 8) Or (var = 19) Or (var = 10) Or (var = 11) Or (var = 18) Or (var = 23) Or (var = 16) Or (var = 17) Or (var = 26) Then
            Return True
        Else
            Return False
        End If

    End Function


    ''' <summary>
    ''' Заміна для деяких варіантів
    ''' </summary>
    ''' <param name="r">Варіант</param>
    Sub zaminasmask2(r As Integer)
        Dim d As Boolean = True
        Select Case d
            Case r = 2
                smask = "\[[a-z]-[a-z]]"

            Case r = 15
                smask = "\{[0-9],[0-9]}"

            Case r = 30
                smask = "\{[0-9]}"

            Case r = 12
                smask = "\{[0-9]}"

            Case r = 29
                smask = "\{[0-9],[-/*+]}"

            Case r = 28
                smask = "\([@#$%^&*~!]\/[@#$%^&*~!]\/[@#$%^&*~!]\)"

            Case r = 27
                smask = "\{[a-zA-Z]}"

            Case r = 24
                smask = "\{[a-zA-Z],[0-9]}"
            Case r = 1
                smask = "\[[A-Za-z]+\]"
            Case r = 6
                smask = "\[![A-Za-z]+\]"
            Case r = 4
                smask = "\[![a-z]-[a-z]\]"
            Case r = 7
                smask = "\([A-Za-z]+\/[A-Za-z]+\)"
            Case r = 13
                smask = "\([A-Za-z]+\)\*"
        End Select
    End Sub

    Public Function truereg(ByVal wword As String, ByVal reg As String)

        If truevar() Then
            smask = "\" + reg
        Else
            If OtherReg() Then

            Else
                If (var = 25) Then
                    smask = "\\" + reg
                Else
                    smask = reg
                End If
            End If
        End If

        Dim rreg As New Regex(smask)
        Dim mm As MatchCollection
        mm = rreg.Matches(wword)
        Return mm.Count
    End Function

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As Random = New Random()
        Return Generator.Next(Min, Max)
    End Function

    Sub chekvariant()
        Dim fa As Boolean = True
        Select Case fa

            Case txtvar.Text = 20
                ee = "&"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 26
                ee = "\p"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 18
                ee = "\g"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 11
                ee = "+"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 3
                ee = "@"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 5
                ee = "!#"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 21
                ee = "#"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 22
                ee = "~"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 16
                ee = "\w"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 17
                ee = "\a"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 23
                ee = "^"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 10
                ee = "$"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 14
                ee = "%"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 19
                ee = "\G"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 25
                ee = "\+"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 2
                ee = "\[a-z]"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 15
                ee = "\{0,8}"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 30
                ee = "{3}"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 12 '--однокові варіанти 12-30
                ee = "{121}"
                var = 12
            Case txtvar.Text = 30 '--однокові варіанти 12-30
                ee = "{30}"
                var = 30
            Case txtvar.Text = 29
                ee = "{2,+}"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 28
                ee = "\([-+/*]\/[-+/*]\/[-+/*]\)"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 27
                ee = "\{[a-zA-Z]}"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 24
                ee = "\{[a-z],[0-9]}"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 1
                ee = "\{[a-z]+"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 4
                ee = "\[!a-z]"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 6
                ee = "\[[A-Za-z]+\]"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 7
                ee = "\([a-z]+\/[a-z]+\)"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 8
                ee = "*"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 9
                ee = "?"
                var = CInt(txtvar.Text)
            Case txtvar.Text = 13
                ee = "\([a-z]+\)\*"
                var = CInt(txtvar.Text)

        End Select
    End Sub


    ''' <summary>
    ''' Масив малих букв
    ''' </summary>
    Dim alphabet() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    ''' <summary>
    ''' Масив великих букв
    ''' </summary>
    Dim alphabet2() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    ''' <summary>
    ''' Масив усіх букв
    ''' </summary>
    Dim alphabet3() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                 "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim numerik() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
    Dim symbol() As String = {".", ",", ";", ":"}
    Dim arf() As String = {"+", "-", "*", "/"}
    Dim symbol2() As String = {"~", "!", "*", "@", "$", "#", "^", "&", "%", "-", ",", ":"} ' 11

    Dim gluhabukva() As String = {"k", "p", "s", "f", "t", "h"}
    Dim dzvinka() As String = {"b", "v", "g", "d", "z", "l", "m", "n", "r"}
    Dim vocala() As String = {"a", "e", "u", "i", "o", "y",
                              "A", "E", "O", "I", "U", "Y"}
    Dim consoala() As String = {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z",
                                "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z"}

    Dim textr As String = ""
    Dim getregexp As String = ""
    Dim var As Integer
    Dim i As Integer
    Dim ee As String = ""
    Dim v1, v2 As Integer
    Function OtherReg() As Boolean
        Dim h
        Dim k As Boolean = False
        Dim variante() As String = {"2", "15", "30", "12", "29", "28", "27", "24", "1", "4", "6", "7", "13"}
        For h = 0 To variante.Length - 1
            If CStr(var) = variante(h) Then
                k = True
            End If
        Next
        Return k
    End Function
    Dim var1 As Integer
    Dim vrr1(10) As String
    Function vr1(vr As Integer)
        Dim result As String = ""
        For q = 0 To vr - 1
            result += alphabet3(GetRandom(0, 51))
        Next
        Return result
    End Function

    Function GetRegOld() As String
        Dim oldreg As String = ""
        Dim c As Boolean = True
        Select Case c
            Case var = 15
                oldreg = "{" + CStr(numerik(GetRandom(1, 4))) + "," + CStr(numerik(GetRandom(5, 9))) + "}"
            Case var = 2
                oldreg = "[" + alphabet(GetRandom(0, 12)) + "-" + alphabet(GetRandom(13, 25)) + "]"
            Case var = 30
                Dim c1 As Integer = GetRandom(1, 9)
                oldreg = "{" + CStr(numerik(c1))
                oldreg += "}"
            Case var = 12
                Dim c1 As Integer = GetRandom(1, 9)
                oldreg = "{" + CStr(numerik(c1))
                oldreg += "}"
            Case var = 29
                oldreg = "{" + CStr(numerik(GetRandom(1, 9))) + "," + arf(GetRandom(0, 3)) + "}"
            Case var = 28
                oldreg = "(" + symbol2(GetRandom(0, 8)) + "/" + symbol2(GetRandom(0, 8)) + "/" + symbol2(GetRandom(0, 8)) + ")"
            Case var = 27
                oldreg = "{" + alphabet3(GetRandom(0, 51)) + "}"
            Case var = 24
                oldreg = "{" + alphabet3(GetRandom(0, 51)) + "," + CStr(numerik(GetRandom(1, 9))) + "}"
            Case var = 1
                oldreg = "["
                var1 = GetRandom(2, GetRandom(3, 6))
                oldreg += vr1(var1) + "]"
            Case var = 6
                oldreg = "[!"
                var1 = GetRandom(2, GetRandom(3, 6))
                oldreg += vr1(var1) + "]"
            Case var = 4
                oldreg = "[!" + alphabet(GetRandom(0, 12)) + "-" + alphabet(GetRandom(13, 25)) + "]"
            Case var = 7
                var1 = GetRandom(2, GetRandom(3, 6))
                oldreg = "(" + vr1(var1) + "/"
                var1 = GetRandom(2, GetRandom(3, 6))
                oldreg += vr1(var1) + ")"
            Case var = 13
                var1 = GetRandom(2, GetRandom(3, 6))
                oldreg = "(" + vr1(var1) + ")*"

        End Select
        Return oldreg

    End Function

    Public Function GetReg(ByVal reg As String, Optional tor As Boolean = True) As String
        Dim j As Integer
        Dim t As Boolean = True
        For w = 0 To 3
            getregexp = ""
            For i = 0 To GetRandom(1, 5)
                j = GetRandom(1, 44)
                If (j Mod 2 = 0) Then
                    getregexp = getregexp + CStr(numerik(GetRandom(0, 9)))
                End If
                getregexp = getregexp + alphabet(GetRandom(0, 25))
                If j < 40 And j > 20 Then
                    getregexp = getregexp + alphabet2(GetRandom(0, 25))
                End If

                If (tor = True) Then
                    If OtherReg() Then
                        zaminasmask2(var)
                        reg = GetRegOld()
                    End If
                    If (GetRandom(1, 5) > 2) Then
                        getregexp = getregexp + reg
                        'Імовірність поряд метасимволів
                        If GetRandom(1, 3) = 2 Then
                            If OtherReg() Then
                                zaminasmask2(var)
                                reg = GetRegOld()
                            End If
                            If var <> 8 Then
                                getregexp = getregexp + reg
                            End If
                        End If
                    End If
                End If
            Next

            If truereg(getregexp, ee) >= 1 Then
                Exit For
            End If
        Next
        Return getregexp

    End Function

    Public num_words As Integer = 19
    Public val_number As Integer = GetRandom(num_words - 9, num_words - 5)
    Dim fal_number As Integer = val_number
    Public val_words(val_number) As String
    Dim fal_words(fal_number) As String
    Public outtext(num_words) As String
    Dim getword As String = ""


    ''' <summary>
    ''' Повертає позиции початку  діапазону 
    ''' </summary>
    ''' <param name="beginpos">Перший символ</param>
    ''' <returns></returns>
    Private Function getFirstPosition(beginpos As String) As Integer
        If IsNumeric(beginpos) Then

        Else
            For g = 0 To 25
                If beginpos = alphabet(g) Then
                    beginpos = g
                    Exit For
                End If
            Next
        End If
        Return beginpos
    End Function

    ''' <summary>
    ''' Повертає позиции кінця діапазону 
    ''' </summary>
    ''' <param name="lastpos">Останній </param>
    ''' <returns></returns>
    Private Function getLastPosition(lastpos As String) As Integer
        If IsNumeric(lastpos) Then

        Else
            For g = 0 To 25
                If lastpos = alphabet(g) Then
                    lastpos = g
                    Exit For
                End If
            Next
        End If
        Return lastpos

    End Function
    Public Sub rez()

        Dim mask(100) As String
        Dim podil As New Regex("(" + smask + ")")
        Dim rezz3(100) As String
        Dim optvar9 As Boolean = False
        Dim var9 As String = ""
        Dim f As Boolean = True
        Dim words_cheker As String = ""
        Dim fal_cheker As String = ""
        Dim rezz2() As String = podil.Split(getregexp)
        Dim lo As Integer = -1
        txtval.Clear()
        txt.Clear()
        For i As Integer = 0 To rezz2.Length - 1
            If rezz2(i) <> "" Then
                lo += 1
                rezz3(lo) = rezz2(i)
                mask(lo) = rezz2(i)
            End If
        Next

        ReDim Preserve rezz3(lo)
        Dim ufal(lo) As String
        ReDim Preserve mask(lo)

        For i = 0 To lo
            txt.Text += mask(i) + "_"
            ufal(i) = rezz3(i)
        Next
        Dim l, l2, l3, l4, num
        Dim pos1 As Integer = 0
        Dim pos2 As Integer = 1

        '----------------------------------
        If OtherReg() Then
            Dim check1 As New Regex(smask)
            For j = 0 To val_number
                words_cheker = ""

                For i = 0 To rezz3.GetUpperBound(0)

                    If check1.IsMatch(mask(i)) Then
                        If var = 7 Then
                            Dim mas1(10) As String
                            Dim mas2(7) As String

                            Dim len As Integer = mask(i).Length
                            l = mask(i)
                            l2 = Strings.Right(l, l.Length)
                            'uno
                            For x = 2 To Text.Length - 1
                                If Strings.Right(Strings.Left(l, x), 1) = "/" Then
                                    Exit For
                                Else
                                    mas1(x - 2) = Strings.Right(Strings.Left(l, x), 1)
                                End If
                            Next
                            Dim lenmas1 As Integer = 0
                            For z = 0 To mas1.Length - 1
                                If mas1(z) <> vbNullString Then
                                    lenmas1 += 1
                                End If
                            Next
                            'duo
                            For x = 2 To Text.Length - 1
                                If Strings.Left(Strings.Right(l, x), 1) = "/" Then
                                    Exit For
                                Else
                                    mas2(x - 2) = Strings.Left(Strings.Right(l, x), 1)
                                End If
                            Next
                            Dim lenmas2 As Integer = 0
                            For z = 0 To mas2.Length - 1
                                If mas2(z) <> vbNullString Then
                                    lenmas2 += 1
                                End If
                            Next
                            If GetRandom(1, 10) > 4 Then
                                rezz3(i) = mas1(GetRandom(0, lenmas1))
                            Else
                                rezz3(i) = mas2(GetRandom(0, lenmas2))
                            End If
                            ufal(i) = CStr(numerik(GetRandom(0, 9)))

                        Else
                            If var = 13 Then '-----------------------13---ok!+-
                                Dim var1Mas(10) As String


                                l = mask(i)
                                l2 = Strings.Right(mask(i), mask(i).Length)
                                For x = 2 To mask(i).Length - 2
                                    l = Strings.Left(l, mask(i).Length - x)
                                    l3 = Strings.Left(Strings.Right(l2, i), 1)
                                    var1Mas(x - 1) = Strings.Right(l, 1)

                                Next
                                ReDim Preserve var1Mas(mask(i).Length - 3)
                                num = GetRandom(1, 18)
                                rezz3(i) = var1Mas(GetRandom(1, var1Mas.Length))
                                If num > 12 Then
                                    rezz3(i) = ""
                                ElseIf num < 6 Then
                                    For faf = 0 To GetRandom(1, 3)
                                        rezz3(i) += var1Mas(GetRandom(1, var1Mas.Length))
                                    Next
                                End If
                                ufal(i) = ""
                                For inma = 1 To var1Mas.Length - 1
                                    For faf = 0 To 21
                                        If alphabet(faf) <> var1Mas(inma) Then
                                            ufal(i) += alphabet(faf)
                                            If GetRandom(1, 10) > 4 Then
                                                Exit For
                                            End If
                                        End If
                                    Next
                                    If GetRandom(1, 10) > 4 Then
                                        Exit For
                                    End If
                                Next

                            Else

                                If var = 2 Then     '-----------------------2---ok!+-
                                    l2 = Strings.Right(Strings.Left(mask(i), mask(i).Length - 3), 1)
                                    l4 = Strings.Right(Strings.Left(mask(i), mask(i).Length - 1), 1)
                                    pos1 = getFirstPosition(l2)
                                    pos2 = getLastPosition(l4)

                                    rezz3(i) = alphabet(GetRandom(pos1, pos2))
                                    If pos1 > 10 Then
                                        ufal(i) = alphabet(GetRandom(0, 9))
                                    Else
                                        ufal(i) = numerik(GetRandom(0, 9))
                                    End If
                                Else


                                    If var = 4 Then '------------------------5---ok+-

                                        l2 = Strings.Right(Strings.Left(mask(i), mask(i).Length - 3), 1)
                                        l4 = Strings.Right(Strings.Left(mask(i), mask(i).Length - 1), 1)
                                        pos1 = getFirstPosition(l2)
                                        pos2 = getLastPosition(l4)
                                        num = GetRandom(0, 9)

                                        If pos1 > 1 And num > 4 Then
                                            rezz3(i) = alphabet(GetRandom(0, pos1))
                                        ElseIf pos2 < 25 Then
                                            rezz3(i) = alphabet(GetRandom(pos2, 25))
                                        Else
                                            rezz3(i) = numerik(GetRandom(0, 9))

                                        End If
                                        ufal(i) = alphabet(GetRandom(pos1, pos2))
                                    Else
                                        If (var = 30) Or (var = 12) Then '------------------12-30 var--ok
                                            l = Strings.Left(mask(i), mask(i).Length - 1)
                                            l2 = Strings.Right(l, 1)

                                            Dim randSymbol As Char = alphabet3(GetRandom(0, 51))
                                            rezz3(i) = randSymbol
                                            For z = 1 To l2 - 1
                                                rezz3(i) += randSymbol
                                            Next
                                            ufal(i) = alphabet3(GetRandom(0, 51))
                                            For z = 1 To l2 - 1

                                                ufal(i) += alphabet3(GetRandom(0, 51))
                                            Next
                                        Else '---------2,15,29 -var---------?

                                            If var = 1 Then '--------------------var-1---ok!
                                                Dim var1Mas(10) As String

                                                Dim len As Integer = mask(i).Length
                                                l = mask(i)
                                                For x = 1 To mask(i).Length - 2

                                                    l = Strings.Left(l, len - x)
                                                    var1Mas(x - 1) = Strings.Right(l, 1)


                                                Next
                                                ReDim Preserve var1Mas(mask(i).Length - 3)
                                                rezz3(i) = var1Mas(GetRandom(0, var1Mas.Length))
                                                ufal(i) = CStr(numerik(GetRandom(0, 9)))

                                            Else
                                                If var = 6 Then '--------------------var-6---ok!
                                                    Dim var1Mas(10) As String


                                                    Dim len As Integer = mask(i).Length
                                                    l = mask(i)
                                                    For x = 1 To mask(i).Length - 2
                                                        l = Strings.Left(l, len - x)
                                                        var1Mas(x - 1) = Strings.Right(l, 1)

                                                    Next
                                                    ReDim Preserve var1Mas(mask(i).Length - 3)
                                                    For x = 0 To var1Mas.Length - 1
                                                        num = alphabet3(GetRandom(0, 51))
                                                        If var1Mas(x) <> num Then
                                                            rezz3(i) = num
                                                            Exit For
                                                        End If
                                                    Next
                                                    ufal(i) = var1Mas(GetRandom(0, var1Mas.Length - 1))
                                                Else
                                                    l = Strings.Left(mask(i), mask(i).Length - 1)
                                                    l2 = Strings.Right(l, 1)

                                                    If var = 27 Then '-------27-------------ok!
                                                        rezz3(i) = l2
                                                        ufal(i) = CStr(numerik(GetRandom(0, 9)))
                                                        For z = 1 To GetRandom(1, GetRandom(2, 8))
                                                            rezz3(i) += l2
                                                            ufal(i) += CStr(numerik(GetRandom(0, 9)))
                                                        Next
                                                        ufal(i) = CStr(numerik(GetRandom(0, 9)))
                                                    Else
                                                        l3 = Strings.Left(mask(i), mask(i).Length - 3)
                                                        l4 = Strings.Right(l3, 1)

                                                        If var = 28 Then '----------------------------28----ok!
                                                            Dim l5, l6, rand
                                                            rand = GetRandom(1, 50)
                                                            l5 = Strings.Left(mask(i), mask(i).Length - 1)
                                                            l6 = Strings.Right(l3, 1)
                                                            If rand < 17 Then
                                                                rezz3(i) = l6
                                                            ElseIf rand > 35 Then
                                                                rezz3(i) = l4
                                                            Else
                                                                rezz3(i) = l2
                                                            End If
                                                            ufal(i) = symbol2(GetRandom(9, 11))

                                                        Else
                                                            If var = 24 Then '-------------var----------24--ok
                                                                rezz3(i) = l4
                                                                ufal(i) = alphabet3(GetRandom(0, 40))
                                                                For z = 1 To CInt(l2) - 1
                                                                    rezz3(i) += l4
                                                                Next
                                                                If CInt(l2) - 1 > 3 Then
                                                                    For z = 1 To CInt(l2) - 2
                                                                        ufal(i) += l4
                                                                    Next
                                                                End If
                                                            Else
                                                                If var = 15 Then
                                                                    Dim l5, l6, rndsymbol
                                                                    rndsymbol = alphabet3(GetRandom(0, 51))
                                                                    l5 = Strings.Left(mask(i), mask(i).Length - 1)
                                                                    l6 = Strings.Right(l3, 1)
                                                                    rezz3(i) = ""
                                                                    ufal(i) = ""

                                                                    For z = 0 To CInt(l2) - 1
                                                                        If (z > CInt(l6)) Then
                                                                            If GetRandom(1, 10) > 5 Then
                                                                                If GetRandom(1, 10) > 5 Then
                                                                                    ufal(i) += CStr(GetRandom(0, 9))
                                                                                End If
                                                                                Exit For
                                                                            End If
                                                                        End If
                                                                        ufal(i) += alphabet3(GetRandom(0, 51))
                                                                        rezz3(i) += rndsymbol
                                                                    Next
                                                                Else
                                                                    If var = 29 Then '------------------------29,+-!
                                                                        rezz3(i) = l2
                                                                        For z = 2 To ((l4 - 1) + GetRandom(1, 3))
                                                                            rezz3(i) += l2
                                                                        Next
                                                                        If GetRandom(1, 5) > 3 Then
                                                                            ufal(i) = l2
                                                                            For z = 3 To CInt(l4)
                                                                                ufal(i) += l2
                                                                            Next
                                                                        Else
                                                                            ufal(i) = alphabet3(GetRandom(0, 51))
                                                                        End If

                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If

                    txtval.Text += rezz3(i)

                    fal_cheker += ufal(i)
                    words_cheker += rezz3(i)
                Next
                val_words(j) = words_cheker
                fal_words(j) = fal_cheker
                txtval.Text += " "

            Next

        Else

            For j = 0 To val_number ' - кількість слів у тексті що відповідають масці

                words_cheker = ""
                fal_cheker = ""

                For i = 0 To rezz3.GetUpperBound(0)
                    If mask(i) = ee Then
                        'згідно по варіанту,на що поміняти метасимвол ----------
                        Select Case f

                            Case var = 20 '------------ok - & – велика латинська літера 
                                rezz3(i) = alphabet2(GetRandom(0, 25))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = alphabet(GetRandom(0, 25))
                                End If

                            Case var = 3  '------------ok - @ – одна довільна мала латинська буква 
                                rezz3(i) = alphabet(GetRandom(0, 25))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = alphabet2(GetRandom(0, 25))
                                End If
                            Case var = 5  '------------ok -!# – один довільний символ,який не є цифрою
                                If GetRandom(1, 10) > 4 Then
                                    rezz3(i) = alphabet(GetRandom(0, 25))
                                Else
                                    rezz3(i) = arf(GetRandom(0, 3))
                                End If
                                ufal(i) = numerik(GetRandom(0, 9))

                            Case var = 21 '------------ok - # – одна довільна цифра 
                                rezz3(i) = numerik(GetRandom(0, 9))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = symbol(GetRandom(0, 3))
                                Else
                                    ufal(i) = alphabet(GetRandom(0, 25))
                                End If
                            Case var = 22 '------------ok - ~ – один з розділових знаків
                                rezz3(i) = symbol(GetRandom(0, 3))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = alphabet2(GetRandom(0, 25))
                                End If
                            Case var = 26 '\p - одна довільна  приголосна латинська літера 
                                rezz3(i) = consoala(GetRandom(0, 39))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = vocala(GetRandom(0, 11))
                                End If
                            Case var = 25 '\+ - ланцюжок знаків арифметичних операцій
                                rezz3(i) = arf(GetRandom(0, 3))
                                If GetRandom(1, 8) > 3 Then
                                    For q = 1 To GetRandom(2, 7)
                                        rezz3(i) += arf(GetRandom(0, 3))
                                    Next
                                End If
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = consoala(GetRandom(0, 39))
                                End If
                            Case var = 18 '\g– одна довільна глуха буква--------------------------------?
                                rezz3(i) = gluhabukva(GetRandom(0, 5))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = vocala(GetRandom(0, 11))
                                End If

                            Case var = 19 '\G – одна довільна дзвінка 
                                rezz3(i) = dzvinka(GetRandom(0, 8))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = vocala(GetRandom(0, 11))
                                End If

                            Case var = 16  '\w – один алфавітно-цифровий символ або символ “;”
                                If GetRandom(0, 10) > 4 Then
                                    rezz3(i) = alphabet3(GetRandom(0, 51))
                                ElseIf GetRandom(0, 10) > 4 Then
                                    rezz3(i) = numerik(GetRandom(0, 9))
                                Else
                                    rezz3(i) = ";"
                                End If
                                If GetRandom(1, 8) >= 6 Then
                                    ufal(i) = symbol2(GetRandom(0, 11))
                                Else
                                    ufal(i) = "+"
                                End If
                            Case var = 17 '\a – знак арифметичної операції
                                rezz3(i) = arf(GetRandom(0, 3))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                ElseIf GetRandom(0, 10) > 4 Then
                                    ufal(i) = alphabet2(GetRandom(0, 25))
                                Else
                                    ufal(i) = symbol(GetRandom(0, 3))
                                End If

                            Case var = 11 '+ - одна довільна голосна латинська літера 
                                rezz3(i) = vocala(GetRandom(0, 11))
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = consoala(GetRandom(0, 39))
                                End If
                            Case var = 9 '? - одна довільний символ або ні одного 
                                Dim rn As Integer = GetRandom(1, 24)
                                If rn > 8 Then
                                    rezz3(i) = numerik(GetRandom(0, 9))
                                ElseIf rn < 16 Then
                                    rezz3(i) = alphabet3(GetRandom(0, 51))
                                Else
                                    rezz3(i) = symbol(GetRandom(0, 13))
                                End If
                                If GetRandom(1, 8) > 4 Then rezz3(i) = ""
                                ufal(i) = ""
                                Dim length As Integer = GetRandom(1, 3)
                                For l = 0 To length - 1
                                    ufal(i) += alphabet(GetRandom(0, 25))
                                Next
                            Case var = 8 '* - ланцюжок довільних символів
                                Dim length As Integer = GetRandom(3, 7)
                                Dim podmask As String = ""
                                For l = 0 To length - 1
                                    podmask += alphabet(GetRandom(0, 25))
                                    If GetRandom(1, 8) > 4 Then
                                        Exit For
                                    End If
                                Next

                                For l = 0 To length - 1
                                    podmask += alphabet3(GetRandom(0, 51))
                                If GetRandom(0, 8) > 3 Then
                                        ufal(i) = CStr(numerik(GetRandom(0, 9)))
                                        Exit For
                                    Else ufal(i) = ""
                                    End If
                                Next
                                rezz3(i) = podmask

                            Case var = 23 '^ - ланцюжок довільних голосних букв
                                rezz3(i) = vocala(GetRandom(0, 11))
                                If GetRandom(1, 8) > 3 Then
                                    For q = 1 To GetRandom(2, 7)
                                        rezz3(i) += vocala(GetRandom(0, 11))
                                    Next
                                End If
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = numerik(GetRandom(0, 9))
                                Else
                                    ufal(i) = consoala(GetRandom(0, 39))
                                End If

                            Case var = 10 '$ – ланцюжок довільних цифр 
                                rezz3(i) = numerik(GetRandom(0, 9))
                                If GetRandom(1, 8) > 3 Then
                                    For q = 1 To GetRandom(2, 7)
                                        rezz3(i) += numerik(GetRandom(0, 9))
                                    Next
                                End If
                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = symbol(GetRandom(0, 3))
                                Else
                                    ufal(i) = alphabet(GetRandom(0, 25))
                                End If

                            Case var = 14 '% –  ланцюжок  однакових символів 
                                Dim gtr As Integer = GetRandom(1, 50)
                                Dim var14g As Integer
                                If gtr > 35 Then
                                    var14g = GetRandom(0, 51)
                                    rezz3(i) = alphabet3(var14g)
                                    For q = 1 To GetRandom(2, 7)
                                        rezz3(i) += alphabet3(var14g)
                                    Next
                                Else
                                    If gtr < 20 Then
                                        var14g = GetRandom(0, 11)
                                        rezz3(i) = symbol2(var14g)
                                        For q = 1 To GetRandom(2, 7)
                                            rezz3(i) += symbol2(var14g)
                                        Next

                                    Else
                                        var14g = GetRandom(0, 9)
                                        rezz3(i) = numerik(var14g)
                                        For q = 1 To GetRandom(2, 7)
                                            rezz3(i) += CStr(numerik(var14g))
                                        Next
                                    End If
                                End If

                                If GetRandom(1, 8) > 4 Then
                                    ufal(i) = symbol(GetRandom(0, 3))
                                Else
                                    ufal(i) = alphabet(GetRandom(0, 25))
                                End If


                        End Select
                        '--------------------------------------------------------
                    End If

                    txtval.Text += rezz3(i)

                    fal_cheker += ufal(i)
                    words_cheker += rezz3(i)

                Next

                val_words(j) = words_cheker
                fal_words(j) = fal_cheker
                txtval.Text += " "

            Next
        End If
        fal_words(1) = GetReg(ee, False)
        fal_words(2) = GetReg(ee, False)
        fal_words(3) = GetReg(ee, False)

    End Sub
    Public Sub ChooseFolder()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txt.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Public Sub filecreate()
        ChooseFolder()
        Dim txtfile As New StreamWriter(FolderBrowserDialog1.SelectedPath, False)
        txtfile.Write(txtgettext.Text)
        txtfile.Close()
    End Sub
    Public Function GetText()

        textr = ""
        Dim maschek(num_words) As Integer
        Dim opt As Integer
        Dim ji As Integer = -1

        For i = 0 To val_number
            outtext(i) = val_words(i)
        Next

        For i = val_number + 1 To num_words
            ji += 1
            outtext(i) = fal_words(ji)
        Next

        Dim q As Integer = -1
        Dim a As Integer = -1

        maschek(0) = 2
        maschek(num_words) = 4

        While (q <> num_words - 2)
            opt = GetRandom(0, num_words + 1)
            a = -1
            For ji = 0 To num_words

                If opt <> maschek(ji) Then
                    a += 1
                    If a = 19 Then
                        q += 1
                        maschek(q) = opt
                    End If

                Else
                    Exit For
                End If
            Next
        End While

        For i = 0 To num_words
            textr += outtext(maschek(i)) + " "

        Next
        Return textr

    End Function



    Public Sub btnrun_Click(sender As Object, e As EventArgs) Handles btnrun.Click

        txtgetmask.AutoSize = True
        If (txtvar.Text = "") Or (txtvar.Text = vbNullString) Or (txtvar.Text = "0") Then
            MsgBox("Введіть варіант!")
        ElseIf CInt(txtvar.Text > 30) Then
            MsgBox("Кількість варіантів всього 30")

        Else
            btnfopen.Visible = True
            txtgetmask.Enabled = True
            txtgetmask.BackColor = Color.White
            txtgettext.Enabled = True
            txtgettext.BackColor = Color.White
            smask = ""
            chekvariant()
            txtgetmask.Text = GetReg(ee)
            rez()
            txtgettext.Text = GetText()
            filecreate()
            txt1.Text = val_number + 1
            txtfal.Clear()
            For a = 0 To fal_number - 1
                txtfal.Text += fal_words(a) + " "
            Next
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnhelp.Click
        HelpForm.Show()
    End Sub

    Private Sub txtvar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvar.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub



    Private Sub RegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 414
        Height = 470


        ToolTip1.SetToolTip(txt1, "Кількість слів що підходят під маску")
    End Sub
    Public Function arrgood(arrayWord() As String)
        Dim LastNonEmpty As Integer = -1
        For i As Integer = 0 To arrayWord.Length - 1
            If arrayWord(i) <> "" Then
                LastNonEmpty += 1
                arrayWord(LastNonEmpty) = arrayWord(i)
            End If
        Next
        ReDim Preserve arrayWord(LastNonEmpty)
        For Each elem As String In arrayWord
        Next
        Return arrayWord
    End Function

    Function userTextf() As String
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        Dim readText As String

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    Dim txtrid As New StreamReader(openFileDialog1.FileName, System.Text.Encoding.GetEncoding(1251))
                    readText = txtrid.ReadToEnd
                    txtrid.Close()
                End If
            Catch Ex As Exception
                MessageBox.Show("Помилка: " & Ex.Message)
            Finally

                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
        If IsNothing(readText) Then
            Return MsgBox("Помилка при зчитуванні")

        End If
        Return readText
    End Function

    Public Function userTextget()
        Dim t As String = userTextf()
        Dim arrayWord() As String = t.Split()
        Dim LastNonEmpty As Integer = -1
        For i As Integer = 0 To arrayWord.Length - 1
            If arrayWord(i) <> "" Then
                LastNonEmpty += 1
                arrayWord(LastNonEmpty) = arrayWord(i)
            End If
        Next
        ReDim Preserve arrayWord(LastNonEmpty)
        Return arrayWord
    End Function


    Private Sub btnfopen_Click(sender As Object, e As EventArgs) Handles btnfopen.Click
        CompareForm.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        ' Displays a SaveFileDialog so the user can save the Image
        ' assigned to Button2.
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()

        ' If the file name is not an empty string open it for saving.
        If saveFileDialog1.FileName <> "" Then
            ' Saves the Image via a FileStream created by the OpenFile method.
            Dim fs As System.IO.FileStream = CType _
               (saveFileDialog1.OpenFile(), System.IO.FileStream)
            ' Saves the Image in the appropriate ImageFormat based upon the
            ' file type selected in the dialog box.
            ' NOTE that the FilterIndex property is one-based.
            Select Case saveFileDialog1.FilterIndex
                Case 1
                    Me.button2.Image.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Jpeg)

                Case 2
                    Me.button2.Image.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Bmp)

                Case 3
                    Me.button2.Image.Save(fs,
                       System.Drawing.Imaging.ImageFormat.Gif)
            End Select

            fs.Close()
        End If
    End Sub

    Private Sub chkdiagnostic_Click(sender As Object, e As EventArgs) Handles chkdiagnostic.Click
        If chkdiagnostic.Checked = True Then
            Width = 820
        Else
            Width = 414
        End If
    End Sub
End Class
