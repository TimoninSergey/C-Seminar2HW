// Задача №2. По двум заданным числам определить, является ли одно число квадратом другого.

string Quad(double A, double B)
{
    string Result = ("0");
    if (A == B*B)
    {
        Result = ("Число A - квадрат числа В");
    }

    else if (B == A*A)
    {
        Result = ("Число В - квадрат числа А");
    }

    else

    {
        Result = ("Числа не являются квадратами друг друга");
    }
    return Result;
}

Console.WriteLine ("Введите число А");
double A = double.Parse(Console.ReadLine());

Console.WriteLine ("Введите число В");
double B = double.Parse(Console.ReadLine());

string Answer = Quad(A, B);
Console.WriteLine(Answer);
