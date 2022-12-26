string [] sourceArray = new string [] {"hhhh", "kkkkk", "ll", "i5", ".j"};

int size=0;
for (int i = 0; i < sourceArray.Length; i++)
{
  Console.WriteLine(sourceArray[i].Length);
  if (sourceArray[i].Length <=3 ) 
  {
    size++;
  }
}
Console.WriteLine($" Количество искомых слов {size}");

string[] sampleArray = new string[size];
int cout=0;
 for (int i = 0; i < sourceArray.Length; i++)
 {
     if (sourceArray[i].Length <=3 ) 
  {
    sampleArray[cout] = sourceArray[i];
    Console.WriteLine($" Ячейка {cout} содержит {sampleArray[cout]}");
    cout++;
 }
 }