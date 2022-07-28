// Знакомство с языками программирования,домашняя работа к уроку 7. Как не нужно писать код.
Console.WriteLine("Задача № 52");
Console.WriteLine("------------------------------");

int[,] arrayWhole = new int[3,4];

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < 3; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < 4; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / 3, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < 3; i++)
  {
      for (int j = 0; j < 4; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}