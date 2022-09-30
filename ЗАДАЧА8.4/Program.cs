// Задача 60. Сформируйте трехмерный массив из неповторяющихся двухзначных
// чисел.Напишите программу,которая будет построчно выводить массив,добавляя
// индексы каждого элемента.
//Массив размером 2х2х2
//66(0,0,0) 25(0,1,0)
//34(1,0,1) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] GenerateArray3D()
{
    int[,,] array = new int[2,2,2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k=0;k<array.GetLength(2); k++)
            {
                array[i,j,k]=(int)(Math.Pow(i+1,3)+MathF.Pow(j+2,3)+
                MathF.Pow(k+3,3));
            }
        }
    }
    return array;
}

void PrintArrayMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            System.Console.Write( $" { matrix[i, j, k],3} ({i},{j},{k})");
            }
            System.Console.WriteLine();
        }
    }
}
PrintArrayMatrix3D(GenerateArray3D());
