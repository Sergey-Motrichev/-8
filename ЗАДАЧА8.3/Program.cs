// Задача 58.Задайте две матрицы.Напишите программу, которая будет
// находить произведение двух матриц.
//2 4|3 4
//3 2|3 3
//Результирующая матрица будет:
//18 20
//15 18 

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
int [,] MultiplyMatrix(int [,] matrix1,int[,] matrix2 )
{  
    int[,] matrix3= new int [matrix1.GetLength(0),matrix2.GetLength(1)];
    for ( int i=0; i<matrix1.GetLength(0); i++)
    {
        for( int j=0; j<matrix2.GetLength(1); j++)
        {
            for( int k=0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i,j] += matrix1[i,k]* matrix2[k,j];
            }
        }
    } 
    return matrix3;
}
int [,] array1 =GenerateArray(rows:3,columns:3,minRnd:0,maxRnd:05);
System.Console.WriteLine("Первая матрица:");
PrintArrayMatrix(array1);
int [,] array2 =GenerateArray(rows:3,columns:3,minRnd:0,maxRnd:05);
System.Console.WriteLine("Вторая матрица:");
PrintArrayMatrix(array2);
if(array1.GetLength(1)!=array2.GetLength(0))
{
    System.Console.WriteLine($"Данное действие невозможно: " +
    $"число столбцов первой({array1.GetLength(1)}) не равняется " +
    $"числу строк второй({array2.GetLength(0)})");
}
else
{
System.Console.WriteLine("Произведение двух матриц:");

PrintArrayMatrix(MultiplyMatrix(array1,array2));
}
