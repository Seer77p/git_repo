// //dz2.1
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num%100/10);

//dz2.2
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1<100) Console.WriteLine("Третьей цифры нет");
else 
{
    int discharge=0;
    int buffer=num1;
     while(buffer>1)
     {
         buffer=buffer/10;
         discharge++;
     }
     discharge=discharge-3;
    for(int i=0; i<discharge; i++)
    {
        num1=num1/10;
    }
   int figure=num1%10;
Console.WriteLine( $"Третья с лева цифра в введенном числе: {figure}");
}

//dz2.3
Console.Write("Введите число соответствующее дню недели по порядку (от 1 до7): ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2<=5) Console.Write("Вы ввели число соответствующее будничному дню ");
else Console.Write("Вы ввели число соответствующее выходному дню ");