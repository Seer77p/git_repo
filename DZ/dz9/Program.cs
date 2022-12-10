//dz-9.1-3
// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Введите число от которого будут выводиться числа:");
int n=Convert.ToInt32(Console.ReadLine());
natural(n, 1);
    int natural(int n, int b)
    {
        if (n == b)
        {
            Console.Write($"{n}");
            return 0;
        }
        Console.Write($"{n}, ");
        return natural(n-1, b);
    }
Console.WriteLine();
// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число от которого будут суммироваться числа:");
int N=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число до которого будут суммироваться числа:");
int M=Convert.ToInt32(Console.ReadLine());
Console.Write($"{summ(N, M)}, ");
    int summ(int N, int M)
    {
        if (M < N) return 0;
        //Console.WriteLine($"{M}, ");
        return M+summ(N, M-1);
    }
Console.WriteLine();
// Задача 68: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Write("Введите число m:");
int am=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n:");
int an=Convert.ToInt32(Console.ReadLine());
int Akkerman(int an, int am)
{
    if (an == 0) return am + 1;
    else if ((an != 0) && (am == 0)) return Akkerman(an - 1, 1);
    else return Akkerman(an - 1, Akkerman(an,am - 1));
}
Console.WriteLine(Akkerman(am, an));
