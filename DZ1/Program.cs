// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10000 | N > 99999)
{
    Console.WriteLine("Введите пятизначное число!");
}
else
{
    string number = Convert.ToString(N);

    if (number [0] == number [4] && number [1] == number [3])
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число не является палиндромом");
    }
}




