// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] SourceArray = new string[6] { "1239", "73", "smile", "wow", "algoritm" };
string[] FinalArray = new string[SourceArray.Length];

void SecondArrayWithIF(string[] SourceArray, string[] FinalArray)
{
    int count = 0;
    for (int i = 0; i < SourceArray.Length; i++)
    {
        if (SourceArray[i].Length <= 3)
        {
            FinalArray[count] = SourceArray[i];
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
SecondArrayWithIF(SourceArray, FinalArray);
PrintArray(FinalArray);