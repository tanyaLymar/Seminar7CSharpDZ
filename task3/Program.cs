// В прямоугольной матрице найти строку с наименьшей суммой элементов
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
int sum = 0;

FillMas(array);
PrintMas(array);
Console.WriteLine();

for (int row = 0; row < m; row++)
{
    sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + array[row,j];
    }
      Console.WriteLine(sum);
}
