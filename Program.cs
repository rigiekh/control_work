string[] arrString = { "понедельник", "три", "127", "утро", "23" };

string[] FormArray(string[] arrString, int n)
{
    int lengthArray = 0; 
    for (int i = 0; i < arrString.Length; i++)
    {
        int length = arrString[i].Length;
        if (length <= n)
        {
            lengthArray++; 
        }
    }

    string[] changedArray = new string[lengthArray];
    int k = 0;
    for (int j = 0; j < arrString.Length; j++)
    {
        int length = arrString[j].Length;
        if (length <= n)
        {
            changedArray[k] = arrString[j];
            k++;
        }
    }
    return changedArray;
}

void PrintArray(string[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}
Console.Write($"Первоначальный массив строк: ");
Console.WriteLine(" ");
PrintArray(arrString);
Console.Write($"Новый массив строк: ");

string[] array = FormArray(arrString, 3);
foreach (string i in array)
    Console.Write($"{i} ");
