// Задайте двухмерный массив. Напишите программу которая поменяет местами две любые строки массива.

int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newAraay[i, j] = new Random().Next(min, max+1);
    return newArray;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(newAraay[i, j] + " ");
        Console.WriteLine();
    Console.WriteLine(); 
}

int [,] ChangeArrayRows(int [,] array1, int row1, int row2)
{
    if (row1 >= 0 && row1 >= array1.GetLength(0) && row2 >= 0 && row2 >= array1.GetLength(0) && row1 != row2)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int temp = array1[row1, j];
            array1[row1, j] = array1[row2, j];
            array1[row2, j] = temp;
        }
    }
    else Console.WriteLine("incorrect input!");
    return array1;
}

Console.WriteLine("Input numbers of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of column: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of 1st row for remove: ");
int userRow1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of 2nd row for remove: ");
int userRow2 = Convert.ToInt32(Console.ReadLine());