// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомедуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"]->["2", ":-)"]

void Main()
{
    string[] ourArray = FillArray();
    PrintArray(ourArray);
    int sizeLimit = 3;
    string[] newArray = FindSize(ourArray, sizeLimit);
    Console.Write("-> ");
    PrintArray(newArray);
}
string[] FillArray()
{
    Console.WriteLine("Enter a few words with a space without commas:");
    string ourLine = Console.ReadLine()!;
    string[] array = ourLine.Split(' ');
    return array;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
string[] FindSize(string[] arr, int sizeLimit)
{
    // int sizeLimit = 3;
    string line = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= sizeLimit)
        {
            line += arr[i] + ' ';
        }
    }
    string[] resultArray = line.Split(' ');
    return resultArray;
}
Main();