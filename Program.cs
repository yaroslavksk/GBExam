using System;
//Method
string [] RefreshArray(string [] StartArray)
{
int LengthArray = StartArray.Length;
Random rnd = new Random();
string [] ResultArray  = new string [rnd.Next(0, StartArray.Length)];

for (int index = 0; index < LengthArray; index++)
{
    for(int iteration = rnd.Next(0,10); iteration < rnd.Next(3,10); iteration++)
    {
        int Position = rnd.Next(0,15);
        if(Position > ResultArray.Length-1) continue;
        else 
        {
            string random = StartArray[rnd.Next(0, StartArray.Length)];
            
            if (random.Length !<=3) ResultArray[Position] = random;
            else random = StartArray[rnd.Next(0, StartArray.Length)];
        }
        
    }
}
return ResultArray;;
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
Console.WriteLine();
PrintStringArray(RefreshArray(StartingData));
Console.ReadKey();
