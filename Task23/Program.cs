// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int i = 1;

while (i <= n)
{
    double result = Math.Pow(i, 3);
    Console.Write(result + " ");
    i++;
}
