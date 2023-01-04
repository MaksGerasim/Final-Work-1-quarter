
string[] enterArray(int size)
{
    string[] NewArray = new string[size];
    for (int i = 0; i < NewArray.Length; i++)
    {
        Console.WriteLine("enter the cell value");
        NewArray[i] = Console.ReadLine();
    }
    Console.WriteLine(string.Join(",  ", NewArray));
    return NewArray;
}


void filterValuesOfArray(string[] Array, int ValuesFilter)
{
    int Index = 0;
    int Count = 0;

    while (Index < Array.Length)
    {
        if (Array[Index].Length < ValuesFilter + 1 && Array[Index].Length > 0)
        {
            Count++;
            Index++;
        }
        else
        {
            Index++;
        }
    }

    string[] NewArray = new string[Count];
    Index = 0;
    int IndexNew = 0;

    while (IndexNew < NewArray.Length)
    {
        if (Array[Index].Length < ValuesFilter + 1 && Array[Index].Length > 0)
        {
            NewArray[IndexNew] = Array[Index];
            IndexNew++;
            Index++;
        }
        else
        {
            Index++;
        }
    }
    Console.WriteLine(string.Join(",  ", NewArray));
}


const int SIZE = 7;    // размер массива
const int VALUESFILTER = 3; // ввод значения фильтра, максимальное количество искомых символов в ячейке

string[] Arr = enterArray(SIZE);
filterValuesOfArray(Arr, VALUESFILTER);



