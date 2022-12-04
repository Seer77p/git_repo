//dz-7.1
//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillingRandomArray(double[,] arr) //Заполнение массива рандомными вещественными 
                                       //числами округленные до 2 знаков после запятой
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
}
void printArray(double[,] array) // Печать массива c вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
while (line <= 0 || column <= 0)
{
    if (line <= 0) Console.Write("Размер массива не может быть нулевым или отрицательным, Введите количество строк: ");
    line = Convert.ToInt32(Console.ReadLine());
    if (column <= 0) Console.Write("Размер массива не может быть нулевым или отрицательным, Введите количество столбцов: ");
    column = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив состоит из {line} строк и {column} столбцов ");
double[,] array = new double[line, column];
FillingRandomArray(array);
printArray(array);

//dz -7.2
// Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillingRandomArrayIntejer(int[,] arr) //Заполнение массива рандомными целыми числами от 1 до 9 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void printArrayInt(int[,] array) // Печать массива с целыми числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
int[,] arr2 = new int[line, column];
FillingRandomArrayIntejer(arr2);
printArrayInt(arr2);
Console.Write("Введите целочисленое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void PoiskNumber(int[,] array, int number) // Поиск введенного пользователем числа в массиве
{
    int empty = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Искомое число: {number} находится в ячейке строка {i+1} столбец {j+1} ");
                empty++;
            }
        }
    }
    if (empty == 0) Console.WriteLine($"Искомоuе число: {number} отсутствует в массиве {empty}");
}
PoiskNumber(arr2, num);
//dz-7.3
// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void SredneeArifmeticheskoe(int[,]arr) //Поиск среднего арифметического каждого столбца с округлением до 2 знаков после запятой
{
    //int srednee=0;
for (int j = 0; j < arr.GetLength(1); j++)
{
    double srednee=0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
      srednee += arr[i,j];  
    }
   // Console.WriteLine($" число: {srednee} ");
    srednee=srednee/arr.GetLength(1);
    Console.WriteLine($" Среднее арифметическое число столбца {j+1} = {Math.Round(srednee, 2)} ");   
}
}

int[,] arr3 = new int[line, column];
FillingRandomArrayIntejer(arr3);
printArrayInt(arr3);
SredneeArifmeticheskoe(arr3);