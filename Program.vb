Imports System

Module Program
    Public total_prime, total_even, total_odd As Integer
    Sub Main(args As String())
        total_prime = 0
        total_odd = 0
        total_even = 0
        Dim num1, num2, num3, num4, num5 As Integer
        ' Get 5 Numbers from user input 
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Enter First Number")
        Console.ForegroundColor = ConsoleColor.Blue
        num1 = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Enter Second Number")
        Console.ForegroundColor = ConsoleColor.Blue
        num2 = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Enter Third Number")
        Console.ForegroundColor = ConsoleColor.Blue
        num3 = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Enter Forth Number")
        Console.ForegroundColor = ConsoleColor.Blue
        num4 = Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Enter Fith Number")
        Console.ForegroundColor = ConsoleColor.Blue
        num5 = Console.ReadLine()
        Console.ResetColor()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("All the Numbers added togther is: " & add_numbers(num1, num2, num3, num4, num5))
        Console.WriteLine(Environment.NewLine)

        ' Prime Numbers '
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(prime_numbers(num1))
        Console.WriteLine(prime_numbers(num2))
        Console.WriteLine(prime_numbers(num3))
        Console.WriteLine(prime_numbers(num4))
        Console.WriteLine(prime_numbers(num5))

        ' Even / Odd Numbers '
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine(Environment.NewLine)
        Console.WriteLine(even_numbers(num1))
        Console.WriteLine(even_numbers(num2))
        Console.WriteLine(even_numbers(num3))
        Console.WriteLine(even_numbers(num4))
        Console.WriteLine(even_numbers(num5))

        ' Total Prime Numbers, Odd Numbers, Even Numbers
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine(Environment.NewLine)
        Console.WriteLine("There were: " & total_prime & " Prime Numbers in the 5 numbers you entered")
        Console.WriteLine("There were: " & total_odd & " Odd Numbers in the 5 numbers you entered")
        Console.WriteLine("There were: " & total_even & " Even Numbers in the 5 numbers you entered")
        Console.ResetColor()
    End Sub

    Function add_numbers(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer)
        Dim add_total As Integer
        add_total = num1 + num2 + num3 + num4 + num5
        Return add_total
    End Function

    Function prime_numbers(number As Integer)
        Dim prime_total As Decimal
        prime_total = number / 2
        If prime_total.ToString.Contains(".") Or number = 2 Then
            total_prime = total_prime + 1
            Return number & " Is Prime"
        Else
            Return ""
        End If
    End Function

    Function even_numbers(number As Integer)
        Dim even_total As Decimal
        even_total = number / 2
        If even_total.ToString.Contains(".") Then
            total_odd = total_odd + 1
            Return number & " Is Odd"
        Else
            total_even = total_even + 1
            Return number & " Is Even"
        End If
    End Function
End Module
