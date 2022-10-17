// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


/*System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i,j] = new Random().Next(1,10);
        System.Console.Write(array[i,j]);
    }
    System.Console.WriteLine();
}
System.Console.WriteLine(); // вывод строк массива в обратном порядке;
for (int i = rows - 1; i >= 0; i--)
{
    for (int j = 0; j < columns; j++)
    {
         System.Console.Write(array[i,j]);
    }
    System.Console.WriteLine();
}


// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        System.Console.Write(array[i, j]);
    }
    System.Console.WriteLine();
}

if (m == n)
{
    int help = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < 0; j++)
        {
           
        }
    }
}
else
{
    System.Console.WriteLine("Введите размеры квадратной матрицы");
}
*/

// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том , сколько раз встречался 
// элемент входных данных.

System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        System.Console.Write(array[i, j]);
    }
    System.Console.WriteLine();
}




// Задача 59: Задайте двумерный массив из целых чисел.Напишите программу
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.


// Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника