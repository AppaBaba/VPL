
Public Module MyProgram
    Sub Main()
        Dim n As Integer, m As Integer, a As Integer
        Dim cmd As String, more As String
        Dim goodtogo As Boolean, doitagain As Boolean

        doitagain = True
        Do While doitagain = True
            Console.WriteLine("Enter n value")
            n = readValue()
            Console.WriteLine("Enter m value")
            m = readValue()
            goodtogo = False
            Do While goodtogo = False
                Console.WriteLine("Enter command")
                cmd = Console.ReadLine()
                If cmd = "add" Then
                    a = n + m
                    goodtogo = True
                End If
                If cmd = "sub" Then
                    a = n - m
                    goodtogo = True
                End If
                If cmd = "mul" Then
                    a = m * n
                    goodtogo = True
                End If
                If goodtogo = False Then
                    Console.WriteLine("Bad command")
                End If
            Loop
            Console.WriteLine("The answer is " & a)
            Console.WriteLine("Do you want to Calculate again? (yes or no)")
            more = Console.ReadLine()
            If more = "yes" Then
                doitagain = True
            Else
                doitagain = False
            End If
        Loop
        Console.WriteLine("The program is done")
    End Sub

    ' .NET can only read single characters or entire lines from the console.
    ' The following function safely reads a double value.
    Private Function readValue() As Double
        Dim result As Double
        While Not Double.TryParse(Console.ReadLine(), result)
            ' No code in the loop
        End While
        Return result
    End Function
End Module
