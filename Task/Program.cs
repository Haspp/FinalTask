string[] StartArray;

Console.WriteLine("Введите массив строк через проблем: ");
string userString = Console.ReadLine();

StartArray = userString.Split(' ');
string[] FinalArray = new string[StartArray.Length];

void SearchFinalArray(string[] StartArray, string[] FinalArray)
{
    int count = 0;
    for (int i = 0; i < StartArray.Length; i++)
    {
    if(StartArray[i].Length <= 3)
        {
        FinalArray[count] = StartArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SearchFinalArray(StartArray, FinalArray);
PrintArray(FinalArray);