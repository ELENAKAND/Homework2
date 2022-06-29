/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 
*/
Console.WriteLine("Введите трехзначное число");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr); 
int result = ((number % 100)/10);
if (99 < number && number < 1000)
{
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Это не трехзначное число");
}
