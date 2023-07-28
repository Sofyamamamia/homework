//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//645 -> 5 
//78 -> третьей цифры нет 
//32679 -> 6

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int thirdDigit = (num / 100) % 10;
if (thirdDigit == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
