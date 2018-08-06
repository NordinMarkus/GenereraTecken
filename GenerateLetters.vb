Imports System.IO
Module GenerateLetters
    Sub Main()
        Dim GeneratedText As New List(Of String)
        Dim antal As Long = 0
        Dim cLetters() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" &
            "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "å", "ä", "ö" &
        "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
        'Kommer att generera fem tecken i alla kombinationer som finns i cLetters
        For i = 0 To cLetters.Count - 1
            For j = 0 To cLetters.Count - 1
                For k = 0 To cLetters.Count - 1
                    For l = 0 To cLetters.Count - 1
                        For m = 0 To cLetters.Count - 1
                            If antal = 200000 Then 'Ser till att hålla ner minnesanvändningen
                                Call SkrivTillFil(GeneratedText)
                                GeneratedText.Clear()
                                antal = 0
                            End If
                            GeneratedText.Add(cLetters(i) & cLetters(j) & cLetters(k) & cLetters(l) & cLetters(m))
                            antal = antal + 1
                        Next
                    Next
                Next
            Next
        Next
        SkrivTillFil(GeneratedText)
        GeneratedText.Clear()
        antal = 0
        Console.WriteLine("1: " & cLetters(0) & vbNewLine & "2: " & cLetters(1) & vbNewLine & "3: " & cLetters(2) & vbNewLine)
        Console.ReadKey()
    End Sub
    Sub SkrivTillFil(ByVal Fil As List(Of String))
        Dim Sökväg As String = "d:\test\genLetters.txt"
        Dim Buffer As List(Of String) = Fil
        Try
            File.AppendAllLines(Sökväg, Buffer)
        Catch ex As Exception
            Console.WriteLine("Något gick med att skriva till fil")
        End Try
    End Sub
End Module
