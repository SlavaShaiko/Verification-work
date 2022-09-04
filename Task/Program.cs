/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуема пользоваться коллекциями, лучше 
 обойтись исключительно массивами.
*/
//["hello","2","world",":-)"] -> ["2",":->"]
//["1234","1567","-2","computer science"] :-> ["-2"]
//["Russia","Denmark","Kazan"] :-> []

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину строки: ");
int stringLength = Convert.ToInt32(Console.ReadLine());

string[] fillingTheArray = FillingTheArray(numberOfRows);
string[] FillingTheArray(int numberOfRows)
{
    string[] array = new string[numberOfRows];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку:");
        string text = Convert.ToString(Console.ReadLine());
        array[i] = text;
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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i] + "]");
    }
}

string[] sortedArray = SortedArray(fillingTheArray, stringLength);
string[] SortedArray(string[] metod, int length)
{
    string[] array = new string[metod.Length];
    for (int i = 0; i < metod.Length; i++)
    {
        if (metod[i].Length <= length)
        {
            array[i] = metod[i];
        }
    }
    return array;
}

Console.WriteLine("");
Console.Write("Отсортированный массив с длиной строк меньше либо равно 3 символам: ");
PrintArray(sortedArray);
Console.WriteLine("");

//Что-то я завис не могу понять, как не выводить пустое значение из string[] sortedArray!