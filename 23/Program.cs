Console.WriteLine("Таблица кубов от 1 до N");

int i = 1;
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Число должно быть > 0");
    return;
}

Console.WriteLine("Таблица кубов: ");

while (i < N + 1)
{
    Console.WriteLine(i * i * i);
    i++;
}

