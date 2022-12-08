// Задайте двухмерный массив. Напишите программу которая поменяет местами две любые строки массива.

/*
int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(min, max+1);
    }
    return newArray;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

int [,] ChangeArrayRows(int [,] array1, int row1, int row2)
{
    if (row1 >= 0 && row1 < array1.GetLength(0) && row2 >= 0 && row2 < array1.GetLength(0) && row1 != row2)
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

int [,] createdArray = Create2dArray(userRows, userColumns, userMinValue, userMaxValue);
ShowArray (createdArray);
ShowArray (ChangeArrayRows(createdArray, userRow1, userRow2));
*/
//Вариант 2 (с вводом строк которые меняем)

/*
int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(min, max+1);
    }
    return newArray;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

int [,] ChangeArrayRows(int [,] array1)
{
    Console.WriteLine("Input number of 1st row for remove: ");
    int row1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of 2nd row for remove: ");
    int row2 = Convert.ToInt32(Console.ReadLine());

    if (row1 >= 0 && row1 < array1.GetLength(0) && row2 >= 0 && row2 < array1.GetLength(0) && row1 != row2)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int temp = array1[row1, j];
            array1[row1, j] = array1[row2, j];
            array1[row2, j] = temp;
        }
    return array1;
    }
    else 
    {
        Console.WriteLine("incorrect input!");
        ChangeArrayRows(array1);
        return array1;
    }
}

Console.WriteLine("Input numbers of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of column: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2dArray(userRows, userColumns, userMinValue, userMaxValue);
ShowArray (createdArray);
ShowArray (ChangeArrayRows(createdArray));
*/

// Задайте думерный массив. Написать программу, которая заменяет строки на столбцы .
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
1 2 3 4     1 3 7 4 
3 4 5 6     2 4 8 5
7 8 9 1     3 5 9 6 
4 5 6 7     4 6 1 7
*/
/*
int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(min, max+1);
    }
    return newArray;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

void ChangeRowsColumnsArray (int [,] array2)
{
    if (array2.GetLength(0) <= 0 && array2.GetLength(1) <= 0)
        Console.WriteLine("It should be matrix");
    else
    {
        int [,] array3 = new int [array2.GetLength(1), array2.GetLength(0)];
        for (int i = 0; i < array2.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
                array3[j,i] = array2[i,j];
    ShowArray(array3);
    }

}

Console.WriteLine("Input numbers of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of column: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

int [,] newMatrix = Create2dArray(userRows, userColumns, userMinValue, userMaxValue);
ShowArray(newMatrix);
ChangeRowsColumnsArray(newMatrix);
*/

//Задайте думерный массив из целых чисел. Напишите программу, котроая обнулит строку и столбец, 
// на пересечении которых расположен первый наименьший элемент массива.

int [,] Create2dArray (int rows, int columns, int min, int max)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(min, max+1);
    }
    return newArray;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

int [] GetMinIndex (int [,] inArray)
{
    int iMin = 0;
    int jMin = 0;

     for (int i = 0; i < inArray.GetLength(0); i++)
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j] < inArray[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    return new [] {iMin, jMin};     // int[] minIndex = {i= 0,j= 0} iMin = minIndex[0]; iMin = minIndex[1]
}

void GetZero(int [,] arrayStart, int [] minInd)
{
    for (int i = 0; i < arrayStart.GetLength(0); i++)
        arrayStart[i, minInd[1]] = 0;
            for(int j = 0; j < arrayStart.GetLength(1); j++)
                arrayStart[minInd[0], j] = 0;
    ShowArray(arrayStart);
}

Console.WriteLine("Input numbers of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of column: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

int [,] frirstArray = Create2dArray(userRows, userColumns, userMinValue, userMaxValue);
ShowArray(frirstArray);
int [] minIndexArray = GetMinIndex(frirstArray);
GetZero(frirstArray, minIndexArray);

