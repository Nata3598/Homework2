// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) {
    Console.WriteLine("Третьей цифры нет");
}
else if (num >= 100)
{
   int ind = 2;
   string number;
   number = num.ToString();
   Console.WriteLine($"Третья цифра введённого числа: {number[2]}");
}