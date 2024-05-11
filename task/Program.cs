// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int size = 6;
int n = 3;
string[] arrayOne = new string[size];

Console.WriteLine($"Введите набор символов, обозначающих значение строкового элемента массива, {size} раз через энтерБ, без пробела");
//FillArray(arrayOne);
FillFillArrayRandomly(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine($"Новый массив, содержащий элементы, размер которых меньше либо равен {n}:");
Console.WriteLine();
if (GetSizeOfSecondArray(arrayOne) == 0) { Console.WriteLine("Искомых элементов строкового массива для переноса в новый массив - нет"); }
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);

}

void FillFillArrayRandomly(string[] arr)
{
    Random rand = new Random();
    string AllmostAllSymbols = "121209salnlkxzclxzn@#$&(()__)%$$#";
     for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,7);
         for (int j = 0; j < randElemSize; j++)
    {
        arr[i] +=  AllmostAllSymbols[rand.Next (0,AllmostAllSymbols.Length)];
    }

    }
}

void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";
    }
}

void PrintArray(string[] arr)
{
    int arrleng = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrleng; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSizeOfSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSizeOfSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}