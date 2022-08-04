Console.WriteLine("Введите количество строк в массиве:  ");
int Line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:  ");
int Column = Convert.ToInt32(Console.ReadLine());

double[,] myArray = new double[Line, Column];

for (int i = 0; i < Line; i++)
    {
      for (int j = 0; j < Column; j++)
      {
        myArray[i,j] = new Random().NextDouble()*100;
        Console.Write("{0,6:F2}", myArray[i,j]);
      }
      Console.WriteLine();
    }
