// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void Definition(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
    }
        else arr[i] = string.Empty;
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] array = new string[] { "Hello", "2", "World", ":-)" };
// string[] array = new string[] { "1234", "1567", "-2", "computer science" };
// string[] array = new string[] { "Russia", "Denmark", "Kazan" };

PrintArray(array);
Definition(array);
Console.Write("   ->   ");
PrintArray(array);