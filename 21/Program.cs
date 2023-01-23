Console.WriteLine("Поиск расстояния между 2 точками");


Console.WriteLine("Введите координату xA");
if (!double.TryParse(Console.ReadLine(), out double xA))
{
    Console.WriteLine("Введена неверная координата");
    return;
}

Console.WriteLine("Введите координату xB");
if (!double.TryParse(Console.ReadLine(), out double xB))
{
    Console.WriteLine("Введена неверная координата");
    return;
}

Console.WriteLine("Введите координату yA");
if (!double.TryParse(Console.ReadLine(), out double yA))
{
    Console.WriteLine("Введена неверная координата");
    return;
}

Console.WriteLine("Введите координату yB");
if (!double.TryParse(Console.ReadLine(), out double yB))
{
    Console.WriteLine("Введена неверная координата");
    return;
}

Console.WriteLine("Введите координату zA");
if (!double.TryParse(Console.ReadLine(), out double zA))
{
    Console.WriteLine("Введена неверная координата");
    return;
}

Console.WriteLine("Введите координату zB");
if (!double.TryParse(Console.ReadLine(), out double zB))
{
    Console.WriteLine("Введена неверная координата");
    return;
}


double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine($"Расстояние между точками - {distance}");