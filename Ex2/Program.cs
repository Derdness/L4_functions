/*
Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/
int[] arr = new int[88]; //Инициализируем массив
int evens = 0;
Random rng = new Random();
for(int i=0;i<arr.Length;i++)//Заполним и напечатаем массив
{
    arr[i] = rng.Next(100, 1000);
    if(i != 0) Console.Write(", ");
    if(arr[i] % 2 == 0) //Выделим чётные числа
        Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(arr[i]);
    Console.ResetColor();
}
for(int i=0;i<arr.Length;i++)//Посчитаем чётные числа в массиве
{
    if(arr[i] % 2 == 0)
        evens++;
}
Console.WriteLine();
Console.WriteLine(evens);
