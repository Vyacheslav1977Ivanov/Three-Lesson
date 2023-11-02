int[] GenerateArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"Сгенерированный массив размерностью {array.Length} элементов : ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int FindingEvenNumbers(int[] arg1)
{
   int result = 0;
   int i = 0;
  for(i = 0; i < arg1.Length;i++)
  {
    if(arg1[i] % 2 == 0 ) 
    {
         result++;
        Console.Write($" Этот Элемент чётный - {arg1[i]} "); 
    }
    else
    {
        Console.Write($" Этот элемент не четный  - {arg1[i]} ");
    }
  }
  Console.Write($"Четных элементов : {result}");
  return result;
}          

int[] mass = GenerateArray();
PrintArray(mass);
FindingEvenNumbers(mass);