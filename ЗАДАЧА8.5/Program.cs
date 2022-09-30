// Задача 62.Напишите программу,которая заполнит спирально массив 4 на 4.
//Например,на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j],4:D2}");
        }
        System.Console.WriteLine();
    }
}
int[,] SpiralArray(int[,] array)
{
    int counter=1;
    int startRow=0;
    int endRow=array.GetLength(0)-1;
    int startCol=0;
    int endCol=array.GetLength(1)-1;

    while(startRow<=endRow && startCol<=endCol)
    {
        for(int j=startCol; j<=endCol; j++)
        {
            array[startRow,j]=counter;
            counter++;
        }
        startRow++;
        for(int i=startRow; i<=endRow; i++)
        {
            array[i,endCol]=counter;
            counter++;
        }
        endCol--;
        for(int j=endCol; j>=startCol; j--)
        {
           array[endRow,j]=counter;
           counter++;
        }
        endRow--;
        for(int i=endRow; i>=startRow; i--)
        {
            array[i,startCol]=counter;
            counter++;
        }
        startCol++;
    }
    return array;
}

int[,] myarray= new int[4,4];
PrintArrayMatrix(SpiralArray(myarray));
