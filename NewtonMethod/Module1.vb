Module Module1

    Sub Main()
        Dim result = SearchRootNewton(x1:=-2.75, x2:=-2.5, e:=0.0001)
        Console.WriteLine(result)
        Console.WriteLine(F(result))
    End Sub

    Function F(x) As Double
        F = x ^ 3 + 3D * x ^ 2 - 3D
        'Console.WriteLine(F)
    End Function

    Function dFdX(x As Double) As Double
        Dim h As Double
        h = 0.0000001
        dFdX = (F(x + h) - F(x - h)) / (2 * h)
        'dFdX = (F(x + h) - F(x)) / h
    End Function

    Function SearchRootNewton(ByRef x1 As Double, ByRef x2 As Double, ByRef e As Double) As Double
        Dim Result As Double
        Dim x As Double
        Dim a As Double
        x = x1
        a = F(x) / dFdX(x)
        Do While (Math.Abs(a) > e) And (x < x2)
            x = x - a
            a = F(x) / dFdX(x)
            'Console.WriteLine(x)
        Loop
        Result = x
        SearchRootNewton = Result
    End Function

End Module
