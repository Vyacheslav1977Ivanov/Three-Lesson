double[] GenerateArray()
{
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        array[i] = Math.Round((0.01 + rnd.NextDouble() * (0.01 + 100.00)),2);
        
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.Write($"Сгенерированный массив размерностью {array.Length} элементов : ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void MaxMin(double[] array)
{
    double max = 0;
    double min = array[0];
    for(int i = 0; i < array.Length;i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        
    }
    for(int i = 0; i < array.Length;i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        
    }
   
    double result = max - min; 
    Console.Write($"МАКСИМАЛЬНЫЙ {max} - МИНИМАЛЬНЫЙ {min} = РЕЗУЛЬТАТ {result}");
}

double[] mass = GenerateArray();
PrintArray(mass);
MaxMin(mass);