// Задайте значения M и N. Напишите рекурсивный метод, который выведет
//  все натуральные числа кратные 3-ём в промежутке от M до N.

using System.Diagnostics.Contracts;

int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task1()
{
    int M = Input("Введите первое число: ");
    int N = Input("Введите второе число: ");

    void Recursion1()
    {
        if (M > N) return;
        if (M % 3 == 0) Console.Write($"{M} ");
        M++;
        Recursion1();
    }
    Recursion1();

}



// Задайте значения M и N. Напишите рекурсивный метод, 
// который найдёт сумму натуральных элементов в промежутке от M до N.

void Task2()
{
    int M = Input("Введите первое число: ");
    int N = Input("Введите второе число: ");
    int result = 0;

    void Recursion1()
    {
        if (M > N) return;
        Console.Write(M + " ");
        result = M + result;
        M++;
        Recursion1();
    }
    Recursion1();
    Console.WriteLine($"\nСумма всех чисел равна {result}");
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Task3()
{
    int m = 1;
    int n = 1;
    A(m,n);

    static int A(int n, int m)
    {
        if (m == 0) return n + 1;
        if (n == 0) return A(m - 1, 1);
        if (n > 0 && m > 0) return A(m - 1, A(m, n - 1));
        return A(n, m);
    }
    Console.WriteLine(A(m, n));
}

Console.Clear();
Task3();