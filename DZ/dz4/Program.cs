// dz 4.1
//Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Exponentiationr(int a, int b)
{
int degree=1;
for(int i=0; i<b; i++)
{   
   degree=degree*a;
}
return degree;
}

Console.Write("Введите возводимое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа, которое надо возвести: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Возводимое число {num1} в степень {num2} = {Exponentiationr(num1, num2)}");

//dz 4.2
//Задача 27: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int NumberOfDigits(int number, int coun)
{
int temp=number;
while(temp!=0)
{
temp=temp/10;
coun++;
}
return coun;
}

void ArrayInitialization(int num3, int []numb, int coun)
{
int discharge=1;
for(int i=1; i<coun; i++)
{
discharge=10*discharge;
}
for(int i=0; i < coun; i++)
{
   numb[i]=num3/discharge%10; 
   discharge=discharge/10;
}
int summ=0;
for(int i=0; i < coun; i++)
{
   summ=summ+numb[i];
}
Console.WriteLine($"Сумма цифр в числе {num3} = {summ}");
Console.WriteLine();
}

Console.Write("Введите число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int coun=0;
int counter = NumberOfDigits(num3, coun);
int[] numbers = new int [counter];
ArrayInitialization(num3, numbers, counter);

//dz4.3
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void arr (int [] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(0,100);
        Console.Write(arr[i]+"  ");
    }
}

int size=8;
int[] array = new int[size];
arr(array);
