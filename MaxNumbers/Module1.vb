Module Module1

    Sub Main()
        'Массив для хранения чисел
        Dim nums As New List(Of Integer)()
        Dim i As Integer = 0

        Console.WriteLine("Введите последовательно не менее трех чисел. Чтобы завершить - введите 0")

        Do
            Console.Write("{0}-е число: ", i + 1)
            nums.Add(Int32.Parse(Console.ReadLine()))
            i = i + 1
        Loop While nums(i - 1) <> 0

        'Алгоритм сортировки
        Dim temp As Integer = nums(0)
        For i = 0 To nums.Count - 1
            For j As Integer = i + 1 To nums.Count - 1
                If nums(i) < nums(j) Then
                    temp = nums(i)
                    nums(i) = nums(j)
                    nums(j) = temp
                End If
            Next
        Next

        'Выводим элементы массива
        i = 0
        For Each number As Integer In nums
            If i = 3 Then
                Exit For
            End If
            Console.Write("{0} ", number)
            i = i + 1
        Next

        Console.ReadLine()
    End Sub

End Module
