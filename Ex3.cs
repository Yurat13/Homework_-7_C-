// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] matr, int[] randommas)
{
    int x = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = randommas[x];
                x++;
                Console.WriteLine(" " + randommas[x]+" "+x);
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < matr.GetUpperBound(1) + 1; j++)
        {
            for (int k = 0; k < matr.GetUpperBound(2) + 1; k++)
                Console.WriteLine($"{matr[i, j, k]}[{i},{j},{k}] ");
        }
    }

}

Random rnd = new Random();
int[] randommas = new int[90];
randommas[0] = rnd.Next(10, 100);
int i = 0, b = 0;
while (i < 90)
{
    int num = rnd.Next(10, 100);
    int j;
    int repit = 0;
    for (j = 0; j < i; j++)
        if (num == randommas[j])
            repit++;
    if (repit == 0)
    {
        randommas[i] = num;
        i++;
    }
}


foreach (var element in randommas)
    Console.Write(" " + element);
Console.WriteLine();


int[,,] mas3d = new int [3,3,3];
if (((mas3d.GetUpperBound(0) + 1) * (mas3d.GetUpperBound(1) + 1) * (mas3d.GetUpperBound(2) + 1)) < 90)
{
    FillArray(mas3d, randommas);
    PrintArray(mas3d);
}
else
    Console.WriteLine("Размерность матрицы больше количества неповторяющихся двузначных элементов!!!");