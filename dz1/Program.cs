// dz1.1
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max=num1;
if(max>num2)
{
   Console.WriteLine($" Максимальное число {max} Минимальное число {num2} ");  
}
else
{
    Console.WriteLine($"Максимальное число {num2} Минимальное число {max}"); 
}

//dz1.2
Console.Write("Введите первое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num5 = Convert.ToInt32(Console.ReadLine());
int max1=num3;
if(max1<num4)
{
max1=num4;
}
if (max1<num5)
{
    max1=num5;
}
Console.WriteLine($"Максимальное число {max1}");

//dz1.3
Console.Write("Введите число: ");
int num6 = Convert.ToInt32(Console.ReadLine());
if(num6%2==0)
{
Console.WriteLine("Число является четным");
}
else
{
  Console.WriteLine("Число является нечетным");  
}

//dz 1.4
Console.Write("Введите максимальное число интервала: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=2; i<=N; i++)
{
    if(i % 2 == 0)
    {
      Console.WriteLine(i);  
    }
}