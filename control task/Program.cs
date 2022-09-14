// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] stringArray1 = new string[] {"56783", "September", "34", "Sun"};

Console.WriteLine(stringArray1[0]);
Console.WriteLine(stringArray1[1]);
Console.WriteLine(stringArray1[2]);
Console.WriteLine(stringArray1[3]);
string[] stringArray2 = new string[stringArray1.Length];

void NewArray(string[] stringArray1, string[] stringArray2)
{
    int count = 0;
    for (int i = 0; i < stringArray1.Length; i++)
    {
    if(stringArray1[i].Length <= 3)
        {
        stringArray2[count] = stringArray1[i];
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
NewArray(stringArray1, stringArray2);
PrintArray(stringArray2);


