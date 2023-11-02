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

int KolvoElem(int[] array)
{
    int Kolvo = 0;
    int index = 0;
    while(index < array.Length)
    {
        if(array[index] >= 20 && array[index] <= 90)
        {
            Kolvo++;
        }
        index++;
    }
    return Kolvo;
}
int[] mass = GenerateArray();
PrintArray(mass);
// int N = KolvoElem(mass);
Console.Write($"КОЛИЧЕСТВО ЭЛЕМЕНТОВ = {KolvoElem(mass)}");