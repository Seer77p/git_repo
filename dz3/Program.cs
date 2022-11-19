//dz3.1 Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while ( 9999 > num || num > 100000)
{
  Console.Write("Введите пятизначное число: ");
  num = Convert.ToInt32(Console.ReadLine());
}
int[] nambers = new int [5];
int discharge=10000;
for(int i=0; i < nambers.Length; i++)
{
   nambers[i]=num/discharge%10; 
   discharge=discharge/10;
}
if(nambers[0]==nambers[4] && nambers[1]==nambers[3]) Console.WriteLine("Введенное число является палиндромом");
else Console.WriteLine("Введенное число не является палиндромом");

//dz3.2 Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double[,] coordinates = new double [2,3];
for(int line=0; line<2; line++)
{
    for(int column=0; column<3; column++)
    {
        Console.WriteLine ("Введите координату x1, y1, z1, x2, y2, z2: ");
        coordinates[line, column] = Convert.ToInt32(Console.ReadLine());
    }
}
double distance = Math.Sqrt(Math.Pow(coordinates[1, 0]-coordinates[0, 0],2)+
                            Math.Pow(coordinates[1, 1]-coordinates[0, 1],2)+
                            Math.Pow(coordinates[1, 2]-coordinates[0, 2],2));
Console.WriteLine ( $"Расстояние между точками в 3D пространстве равно = {Math.Round (distance,2)} ");

//dz3.3 Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("Введите число N (до которого будет выводиться таблица): ");
int num1 = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=num1; i++)
{
    Console.Write($"Начальное число: {i} ");
    Console.WriteLine($"Возведенное в куб число: {Math.Pow(i,3)} ");
}




