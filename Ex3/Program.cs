/*
Задача 3: Напишите программу, которая перевернёт одномерный массив 
(первый элемент станет последним, второй – предпоследним и т.д.)
*/
int[] arr = new int[11]; //Инициализируем массив
int temp;
Random rng = new Random();
for(int i=0;i<arr.Length;i++)//Заполним и напечатаем массив
{
    arr[i] = rng.Next(100, 1000);
    if(i != 0) Console.Write(", ");
    Console.Write(arr[i]);
}
for(int i=0;i<arr.Length/2;i++)//Посчитаем чётные числа в массиве
{
    temp = arr[i];                   //Проходим массив с обоих концов к центру
    arr[i] = arr[arr.Length - 1 - i];//меняя элементы местами попарно
    arr[arr.Length - 1 - i] = temp;
}
Console.WriteLine();
for(int i=0;i<arr.Length;i++)//Напечатаем получившийся массив
{
    if(i != 0) Console.Write(", ");
    Console.Write(arr[i]);
}