//Программа, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов чисел от 1 до " + N + ": ");

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i + " в кубе равно " + (i*i*i));
}

