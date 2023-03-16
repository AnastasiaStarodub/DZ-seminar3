// Программа, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координату X точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

// Нахождение расстояния между двумя точками в 3D пространстве это
//корень из (x2-x1)в квадрате + (y2-y1)в квадрате + (z2-z1)в квадрате
//Math.Sqrt - корень
//Math.Pow - возведение в степень

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

//distance:F2 - показывает результат до второго знака после запятой
Console.WriteLine($"Расстояние между двумя точками: {distance:F2}");
