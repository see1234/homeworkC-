﻿Console.WriteLine("Введите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(max < numberB) {
    max = numberB;
}
if(max < numberC) {
    max = numberC;
}
Console.WriteLine(max);