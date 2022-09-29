// 54.Задайте двумерный массив.Напишите программу,которая
// упорядочит по убыванию элементы каждой строки двумерного
// массива.
// Например:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоги получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}

void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] Sortstring(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j <array.GetLength(1); j++)
        {
        for(int k=0; k<array.GetLength(1)-1; k++)
        {
            if (array[i,k] < array[i,k+1])
            {
                int temp= array[i,k+1];
                array [i,k+1]= array[i,k] ;
                array [i,k]=temp;
            }
        }
        }
    }
    return array;
}

int [,] myarray=GenerateArray(rows:3,columns:4,minRnd:0,maxRnd:10);
System.Console.WriteLine("Исходный массив:");
PrintArrayMatrix(myarray);
System.Console.WriteLine("Сортированный массив:");
PrintArrayMatrix(Sortstring(myarray));

 