// Задача 56:Задайте прямоугольный двумерный массив. Напишите программу 
//которая будет находить строку с наименьшей суммой элементов.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдает номер строки
// с наименьшей суммой элементов:1 строка.


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
int SumlineMin(int [,] array )
{
    int minSum=array[0,0];
    int minSumline= 0;
    for (int i= 1; i < array.GetLength(0); i++)
    {
        int sum=0;
        for(int j=0;j<array.GetLength(1); j++)
        {
            sum +=array[i,j];
        }
        if(minSum>sum)
        {
            minSum=sum;
            minSumline=i;
        }
    }
    return minSumline+1;
}    
int [,] myarray =GenerateArray(rows:4,columns:4,minRnd:-9,maxRnd:10);
System.Console.WriteLine("Исходный массив:");
PrintArrayMatrix(myarray);
System.Console.WriteLine($"Номер строки с наименьшей суммой: " +
$"{SumlineMin(myarray)}");

