// Найти произведение двух матриц
void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] massiv, int minimum, int maximum)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(minimum, maximum);
        }
    }
}

int[,] MultiplicationArray (int[,] matrix1, int[,] matrix2)
{
    int[,] multiplicationArray = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            multiplicationArray[i, j] = 0;
            for (int column1 = 0; column1 < matrix1.GetLength(1); column1++)
            {
                multiplicationArray[i, j] += matrix1[i, column1] * matrix2[column1, j];
            }
        }
    }
    return multiplicationArray;
}

int[,] array1 = new int [2, 3];
int[,] array2 = new int [3, 2];
FillArray(array1, 1, 10);
FillArray(array2, 1, 10);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine("Multipication of Arrays:");
PrintArray(MultiplicationArray(array1, array2));