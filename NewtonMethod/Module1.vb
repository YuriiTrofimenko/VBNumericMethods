Module Module1
    ''' <summary>
    ''' Уточнение до ε=0,001 корня уравленния x^3+3*x^2-3,
    ''' расположенного на отрезке  [-2,75; -2,5],
    ''' методом Ньютона (касательных)
    ''' </summary>
    ''' главная процедура
    Sub Main()
        'вызов функции уточнения корня
        Dim result = SearchRootNewton(a:=-2.75, b:=-2.5, e:=0.001)
        'вывод результата
        Console.WriteLine(result)
        'вывод проверки -
        'при подставновке ответа в функцию получается приблизительно 0
        'Console.WriteLine(F(result))
    End Sub
    'функция, для которой уточняется корень
    Function F(x) As Double
        F = x ^ 3 + 3D * x ^ 2 - 3D
    End Function
    'функция, вычисляющая значение производной исходной функции
    Function dFdx(x As Double) As Double
        Dim h As Double
        h = 0.0001
        dFdx = (F(x + h) - F(x - h)) / (2 * h)
    End Function
    'функция уточнения
    Function SearchRootNewton(ByRef a As Double, ByRef b As Double, ByRef e As Double) As Double
        Dim xa = a
        Dim xb = b
        'повторение цикла, пока не достигнута нужная точность результата
        Do While (Math.Abs(xb) > e)
            'вычисление корня по формуле
            xa -= F(xa) / dFdx(xa)
            'вычисление полученной точности
            xb = F(xa)
            'вывод промежуточных результатов
            'Console.WriteLine($"xa = {xa}")
            'Console.WriteLine($"xb = {xb}")
        Loop
        'возврат уточненного значения функцией
        SearchRootNewton = xa
    End Function

End Module
