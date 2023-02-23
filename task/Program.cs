int size = InputNum("Введите длину массива:\t");

string[] firstArray = new string[size];
string[] secondArray = new string[firstArray.Length];

int count = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    System.Console.Write($"Введите элемент под индексом {i + 1}:\t");
    firstArray[i] = System.Console.ReadLine();
    if (firstArray[i].Length <= 3)
    {
        secondArray[count] = firstArray[i];
        count++;
    }
}

void PrintArray(string[] array, string msg)
{
    System.Console.WriteLine(msg);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

int InputNum(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

PrintArray(firstArray, "Базовый массив");
PrintArray(secondArray, "Измененный массив");