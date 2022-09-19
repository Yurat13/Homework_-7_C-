// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int x = 1;
int y = 1;
int step = 0;
    while (step < 10)
    {
        double result = Math.Pow(x + y, step);
        Console.WriteLine (result);
        step++;
    }
