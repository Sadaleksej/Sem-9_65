// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();

Console.WriteLine("Введите значение a: ");
int a = Convert.ToInt32(ReadLine());
Console.WriteLine("Введите значение b: ");
int b = Convert.ToInt32(ReadLine());
WriteLine(Numbers(a,b));



int Numbers (int aa, int bb)
{
    if (aa <= bb) return aa + Numbers(aa+1, bb); 
    else return 0;
}