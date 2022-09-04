/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуема пользоваться коллекциями, лучше 
 обойтись исключительно массивами.
*/
//["hello","2","world",":-)"] -> ["2",":->"]
//["1234","1567","-2","computer science"] :-> ["-2"]
//["Russia","Denmark","Kazan"] :-> []


Console.Clear();
Console.Write("Введите количество строк: ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());

string[] fillingTheArray = FillingTheArray(numberOfRows);
string[] FillingTheArray(int numberOfRows)
{
    string[] array = new string[numberOfRows];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        string text = Convert.ToString(Console.ReadLine());
        if (i < array.Length - 1) array[i] = ($"{text}, ");
        else array[i] = ($"{text}");
    }
    return array;
}

Console.Write("Первоначальный массив: ");
PrintArray(fillingTheArray);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + "]");
    }
}

string[] sortedArray = SortedArray(fillingTheArray);
string[] SortedArray(string[] metod)
{
    string[] array = new string[metod.Length];
    int count = 0;
    for (int i = 0; i < metod.Length; i++)
    {
        if (metod[i].Length <= 5)
        {
            array[count] = metod[i];
            count++;
        }
    }
    return array;
}
Console.WriteLine("");
Console.Write("Отсортированный массив с длиной строк меньше либо равно 3 символам: ");
PrintArray(sortedArray);


// string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
// string[] array2 = new string[array1.Length];
// void SecondArrayWithIF(string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//     if(array1[i].Length <= 3)
//         {
//         array2[count] = array1[i];
//         count++;
//         }
//     }
// }
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// SecondArrayWithIF(array1, array2);
// PrintArray(array2);