Console.WriteLine("Введите количество строк в массиве:  ");
int Line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:  ");
int Column = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[Line, Column];
Random range = new Random();
for (int j = 0; j < Column; j++)
    {
        double Sum = 0;
        for (int i = 0; i < Line; i++)
        {
            Array[i,j] = range.Next(0, 100);
            Sum += Array[i,j];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {Math.Round((Sum/Column),3)}");
    }