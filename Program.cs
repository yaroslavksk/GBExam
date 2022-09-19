using System;
//Method
string [] RefreshArray(string [] StartArray)
{
    string [] ResultArray  = new string [StartArray.Length];
    int count = 0;
    for (int index = 0; index < StartArray.Length; index++)
    {
        if (StartArray[index].Length <= 3)
        {
            ResultArray[count] = StartArray[index];
            count++;
        } 
    }
    return ResultArray;
}

void PrintStringArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Code
string [] StartingData = new string [] {"Кукла","Ра","123","Строка","Делает","Лежит","Спит","Шкаф","О","С"};
PrintStringArray(RefreshArray(StartingData));
Console.ReadKey();