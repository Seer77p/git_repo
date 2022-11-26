// dz-5.1
// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
//  чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int LongArrayDefinition()//ввод размера массива пользователем
{
Console.WriteLine("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num<=0)
{
    Console.Write("Размер массива не может быть нулевым или отрицательным, Введите размер массива: ");
    num = Convert.ToInt32(Console.ReadLine());
}
return num;
}

void FillingRandomArray (int[] arr)//Заполнение массива рандомными трехзначными числами
{
 for(int i=0; i < arr.Length; i++)
 {
 arr[i]= new Random().Next(100,1000);
 Console.Write($"Ячейка {i}: "+arr[i]+"  ");
 }
 Console.WriteLine();
}

void FillingRandomArraydouble (double[] arr)//Рандом массива для вещественных чисел
{
 for(int i=0; i < arr.Length; i++)
 {
 arr[i]= new Random().NextDouble();
 Console.Write($"Ячейка {i}: "+Math.Round(arr[i],3)+"  ");
 }
 Console.WriteLine();
}

int ParityCheck(int[] arr)//проверка массива на четность и подсчет количества таких чисел
{
 int cout=0;   
for (int i=0; i< arr.Length; i++)
{
    if(arr[i]%2==0)
    {
         Console.WriteLine(arr[i]+" Является четным числом: ");
         cout++;
    }
}
Console.WriteLine();
return cout;
}

int size=LongArrayDefinition();
Console.WriteLine($"Размер массива = {size}");
Console.WriteLine();
int[] array = new int[size];
FillingRandomArray(array);
Console.WriteLine($"Количество четных чисел в массиве = {ParityCheck(array)}");

// dz-5.2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int AdditionOfOddCellValues(int[] arr)
{
int summ=0;   
for (int i=1; i< arr.Length; i+=2)
{
    Console.WriteLine("Значение "+arr[i]+" соответствует ячейке с нечетным индексом");
    summ=summ+arr[i];
    
}
Console.WriteLine();
return summ;

}
int size1=LongArrayDefinition();
Console.WriteLine($"Размер массива = {size1}");
Console.WriteLine();
int[] array1 = new int[size1];
FillingRandomArray(array1);
Console.WriteLine($"Сумма элементов с нечетным индексом = {AdditionOfOddCellValues(array1)}");

//dz 5.3
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double SearchForTheSmallestAndMaximum(double[] arr)//поиск минимального и максимальных чисел
{
double raznica=0;
double min=1;
double max=0;   
for (int i=0; i< arr.Length; i++)
{
    //Console.WriteLine("Минимальное значение = "+arr[i]+" соответствует ячейке с нечетным индексом");
    if(arr[i]<min) min=arr[i];
    if(arr[i]>max) max=arr[i];
}
Console.WriteLine();
Console.WriteLine($"Минимальное значение = {Math.Round(min,3)}");
Console.WriteLine($"Максимальное значение = {Math.Round(max,3)}");
raznica=max-min;
return raznica;
}

int size2=LongArrayDefinition();
Console.WriteLine($"Размер массива = {size2}");
Console.WriteLine();
double[] array2 = new double[size2];
FillingRandomArraydouble(array2);
Console.WriteLine($"Сумма элементов с нечетным индексом = {Math.Round(SearchForTheSmallestAndMaximum(array2),3)}");