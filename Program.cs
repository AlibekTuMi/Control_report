﻿Console.Clear();
System.Console.Write("Введие первый элемент :");
string el1 = Console.ReadLine();
System.Console.Write("Введие второй элемент :");
string el2 = Console.ReadLine();
System.Console.Write("Введие третий элемент :");
string el3 = Console.ReadLine();
System.Console.Write("Введие четвертый элемент :");
string el4 = Console.ReadLine();
System.Console.Write("Введие пятый элемент :");
string el5 = Console.ReadLine();
string[] primary = new string[]{el1,el2,el3,el4,el5};
int count = 0;
for (int i = 0; i < primary.Length; i++)
{
    if (primary[i].Length <= 3)
    {
        count++;
    }
}
string [] secondary = new string[count];
int index = 0;
for (int i = 0; i < primary.Length; i++)
{
    if (primary[i].Length <= 3)
    {
        secondary[index] = primary[i];
        index++;
    }
}
System.Console.WriteLine(string.Join(",",primary));
System.Console.WriteLine(string.Join(",",secondary));