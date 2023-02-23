int size = InputNum("Введите длину массива:\t");

string[] array = new string[size];
string[] array1 = new string[array.Length];

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите элемент под индексом {i + 1}:\t");
    array[i] = System.Console.ReadLine();
    if (array[i].Length <= 3)
    {
        array1[count] = array[i];
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

PrintArray(array, "Базовый массив");
PrintArray(array1, "Измененный массив");