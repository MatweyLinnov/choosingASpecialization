string[] firstArray = new string [5] {"123","11", "hi","Hello",":-:-:-"};
string[] secondArray = new string[firstArray.Length];

TransArray(firstArray, secondArray);
PrintArray(secondArray, "Переведенный массив");

void TransArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i <firstArray.Length; i++)
    {
        if(firstArray[i].Length <=3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array, string msg)
{   
    System.Console.WriteLine(msg);
    for (int i = 0; i <array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}");
    }
}
