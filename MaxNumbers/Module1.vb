Module Module1
    ''' <summary>
    ''' Вычиследние трех наибольших чисел из введенной последовательности
    ''' </summary>
    ''' главная процедура
    Sub Main()
        'список для хранения чисел
        Dim nums As New List(Of Integer)()
        'число элементов в списке
        Dim i As Integer = 0
        Console.WriteLine("Введите последовательно не менее трех чисел. Чтобы завершить - введите 0")
        'ввод чисел из консоли, пока не будет введен 0
        Do
            Console.Write("{0}-е число: ", i + 1)
            Dim newNumber = 0
            'если введенная пользователем строка успешно приведена к целому типу,
            'сохраняем это число в переменную newNumber и выполняем действия с ним
            If Integer.TryParse(Console.ReadLine(), newNumber) Then
                'если число не равно нулю - добавляем его в список
                'и увеличиваем индекс на единицу 
                If newNumber <> 0 Then
                    nums.Add(newNumber)
                    i = i + 1
                Else
                    'иначе, если ранее уже введено не менее трех элементов списка,
                    'завершаем выполнение цикла 
                    If nums.Count >= 3 Then
                        Exit Do
                    End If
                End If
            End If
        Loop While True
        'сортировка списка методом пузырька
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
        'вывод первых трех элементов отсортированного списка,
        'то есть трех наибольших чисел
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
