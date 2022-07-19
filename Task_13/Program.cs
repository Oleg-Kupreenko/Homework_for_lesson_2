// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int a = int.Parse(Console.ReadLine());
int b = (int)Math.Log10(a)-2;
Console.WriteLine(b < 0 ? "Третьей цифры нет" : (a % (int)Math.Pow(10, b + 1) / (int)Math.Pow(10, b)).ToString());