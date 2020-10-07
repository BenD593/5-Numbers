Imports System

Module Program
    Public total_prime, total_even, total_odd As Integer
    Sub Main(args As String())
        total_prime = 0
        total_odd = 0
        total_even = 0
        Dim num1, num2, num3, num4, num5 As Integer
        Console.WriteLine("Enter First Number")
        num1 = Console.ReadLine()
        Console.WriteLine("Enter Second Number")
        num2 = Console.ReadLine()
        Console.WriteLine("Enter Third Number")
        num3 = Console.ReadLine()
        Console.WriteLine("Enter Forth Number")
        num4 = Console.ReadLine()
        Console.WriteLine("Enter Fith Number")
        num5 = Console.ReadLine()
        Console.WriteLine("All the Numbers added togther is: " & add_numbers(num1, num2, num3, num4, num5))
        Console.WriteLine(prime_numbers(num1))
        Console.WriteLine(prime_numbers(num2))
        Console.WriteLine(prime_numbers(num3))
        Console.WriteLine(prime_numbers(num4))
        Console.WriteLine(prime_numbers(num5))
        Console.WriteLine(even_numbers(num1))
        Console.WriteLine(even_numbers(num2))
        Console.WriteLine(even_numbers(num3))
        Console.WriteLine(even_numbers(num4))
        Console.WriteLine(even_numbers(num5))
        Console.WriteLine(total_prime)
        Console.WriteLine(total_odd)
        Console.WriteLine(total_even)


    End Sub
    Function add_numbers(num1 As Integer, num2 As Integer, num3 As Integer, num4 As Integer, num5 As Integer)
        Dim add_total As Integer
        add_total = num1 + num2 + num3 + num4 + num5
        Return add_total
    End Function

    Function prime_numbers(number As Integer)
        Dim prime_total As Decimal
        prime_total = number / 2
        If prime_total.ToString.Contains(".") Or prime_total = 2 Then
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
