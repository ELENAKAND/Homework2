/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите  число, соответствующее дню недели от 1 до 7");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
if (number > 0 && number < 6)
{
    Console.WriteLine("День недели не является выходным днем");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("День недели является выходным днем");
}
if (number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
if (number < 1)
{
    Console.WriteLine("Такого дня недели не существует");
}
