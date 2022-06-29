/*
Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите  число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
int result1 = number%10; //переменная для вывода третьей цифры 3-значного числа 
int result2 = (number % 100)/10; // переменная для вывода третьей цифры 4-зн числа 
int result3 = (number % 1000)/100; // переменная для вывода третьей цифры 5-зн числа
if (number > 99 && number < 1000)
{
    Console.WriteLine(result1);
}
if (number > 999 && number < 10000)
{
    Console.WriteLine(result2);
}
if (number > 9999 && number < 100000)
{
    Console.WriteLine(result3);
}
if (number > 0 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

