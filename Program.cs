// Функция подсчета подходящих элементов
int CountElement(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            size++;
    }
    return size;
}

// Функция формирования нового массива с заданными элементами по условию задачи
string[] ConvertArray(string[] array, int size)
{
    int j = 0;
    string[] resultArray = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

// Код программы
string[] originalArray = { "hello", "2", "world", ":-)" };
int sizeArray = CountElement(originalArray);
string[] finalArray = new string[sizeArray];
finalArray = ConvertArray(originalArray, sizeArray);
Console.WriteLine(string.Join(", ", finalArray));