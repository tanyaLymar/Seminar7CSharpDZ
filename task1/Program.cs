// Написать программу, которая обменивает элементы первой строки и последней строки

void FillMas (int[,]array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintMas(int [,] array)
{for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}


    
Console.Write("Введите количество строк: ");    
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");    
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] array = new int[m, n];


FillMas(array);
PrintMas(array);
Console.WriteLine();




    for (int i = 0; i <= n-1; i++)
    {
        int temp = array[0, i];
        array [0, i] = array[m-1, i];
        array[m-1, i] = temp;
    }
   

    PrintMas(array);
