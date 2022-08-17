// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int rows = random.Next(3, 8);
int columns = random.Next(3, 8);
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Arithmetic(array);

void FillArray(int[,] array, int startnumber = 0, int finishnumber = 9)
{
    finishnumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for ( int i = 0; i < rows; i++)
    {
        for (int j =0 ; j < columns; j++)
        {
            array[i, j] = random.Next(startnumber, finishnumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i =0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Arithmetic(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine ($"The arithmetic mean of each of the columns: ");
    for (int j = 0; j < columns; j++)
    {
        double sum = 0.0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{Math.Round(sum/rows, 2)}; ");
    }
}
