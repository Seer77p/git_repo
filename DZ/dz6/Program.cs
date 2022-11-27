//dz-6.1
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int LongArrayDefinition()//ввод размера массива пользователем
{
Console.WriteLine("Введите количество цифр: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num<=0)
{
    Console.Write("Количество вводимых цыфр не может быть нулевым или отрицательным, Введите количество элементов: ");
    num = Convert.ToInt32(Console.ReadLine());
}
return num;
}
void ArrayInitialization (int[] arr)//Заполнение массива пользователем
{
 for(int i=0; i < arr.Length; i++)
 {
 Console.Write($"Введите число = {i+1}: ");
 arr[i] = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Ячейка {i+1} = "+arr[i]+"  ");
 }
 Console.WriteLine();
}

int NumberOfPositiveNumbers(int[] arr)//Функция определения количества положительных чисел введенных пользователем
{
int cout=0;  
for (int i=0; i< arr.Length; i++)
{
   if(arr[i]>0)
    {
         Console.WriteLine(" Положительное число: "+arr[i]);
         cout++;
    }
}
return cout;
}

int size=LongArrayDefinition();
Console.WriteLine($"Количество элементов для решения задачи  = {size}");
Console.WriteLine();
int[] array = new int[size];
ArrayInitialization(array);
Console.WriteLine($"Количество введенных положительных чисел = {NumberOfPositiveNumbers(array)}");

//dz-6.2
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
// k1*x+b2=k2*x+m2
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void StraightLineCoordinates()// Функция определения координат точки пересечения двух прямых
{
Console.WriteLine("Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());  
Console.WriteLine("Введите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()); 
double x=Math.Round(-(b1-b2)/(k1-k2), 3);
double y=Math.Round((k1*x+b1),3);
Console.WriteLine($"Точка пересечения (координаты x = {x} ; y = {y})");
}
StraightLineCoordinates();
