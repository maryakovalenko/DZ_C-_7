// Знакомство с языками программирования,домашняя работа к уроку 7. Как не нужно писать код.
Console.WriteLine("Задача № 50");
Console.WriteLine("----------------------");

Console.Write("\nMассив возьмем из предыдущей задачи (№ 47).\n");
Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= 3
&& position[1] <= 4 
&& position[0] >= 0 
&& position[1] >= 0) 
{
 
  Console.Write($"Значение элемента:  ");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ',') 
    {
      output += input[i];
    }
  }
  return output;
}
