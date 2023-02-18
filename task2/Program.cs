// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
// for (int i = 0; i < m; i++) {

//  for (int j = 0; j < n; j++) {

//  }
// }

for (int b = 0; b < m; b++)
    {
       
        for (int i = 0; i < n; i++)
        
            for (int j = 0; j < n -1; j++)
            {
                
          
            if (array[b,j] < array[b, j + 1])
            {
                int temp = array[b, j];
                array[b, j] = array[b, j + 1];
                array[b, j + 1] = temp;
            }
        }
    }
    

PrintMas(array);
