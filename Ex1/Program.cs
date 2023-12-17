/*Задача 1: Напишите программу, которая бесконечно 
запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ 
или при вводе числа, сумма цифр которого чётная.
*/
bool flag = true; //Условие завершения программы
int digit;
while(flag)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();
    if(input == "q") //Если введено q, закончить выполнение 
    {
        flag = false;
        continue;
    }
    try
    {
        digit = Convert.ToInt32(input);
        int sum = 0;
        do //Найдём сумму цифр числа
        {
            sum += digit % 10;
            digit = digit / 10;
        } while(digit / 10 != 0);
        if(sum % 2 == 0) //Если сумма чётная завершить программу
            flag = false;
    }
    catch(FormatException e){
        Console.WriteLine("Это не целое число.");
    }
}