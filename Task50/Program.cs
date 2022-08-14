// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Random random = new Random();
int rows = random.Next(3, 9);
int columns = random.Next(3, 9);
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
FindPosition(array);

void FillArray(int[,] array, int startnumber = 0, int finishnumber = 10)
{
    finishnumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startnumber, finishnumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindPosition(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine($"Insert the line number from {1} to {rows}:");
    int rowsconsumer = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Insert the column number from {1} to {columns}:");
    int columnsconsumer = Convert.ToInt32(Console.ReadLine());
    if ((columnsconsumer < 1 || columnsconsumer > columns) || (rowsconsumer < 1 || rowsconsumer > rows))
    {
        Console.WriteLine($"The number with coordinates ({rowsconsumer}, {columnsconsumer}) does not exist. Please repeat insert");
    }
    else
    {
        Console.WriteLine($"The number with coordinates ({rowsconsumer}, {columnsconsumer}) is {array[rowsconsumer - 1, columnsconsumer - 1]}");
    }
}

