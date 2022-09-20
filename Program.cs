Console.Write("Введите размер массива строк ");
int n = Convert.ToInt32(Console.ReadLine());

string[] arrInput = new string[n];
string[] arrResult = new string[n];

for (int i = 0; i < arrInput.Length; i++)
{
    Console.Write("Строка " + (i + 1) + ": ");
    arrInput[i] = Console.ReadLine();
}

Console.WriteLine("Введеный массив ");

for (int i = 0; i < arrInput.Length; i++)
{  
     Console.Write($"{arrInput[i]} ");   
}

int count = 0;

for (int i = 0; i < arrInput.Length; i++)
{
    if(arrInput[i].Length <= 3)
    {
        arrResult[count] = arrInput[i];
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Итоговый массив строк: ");

for (int i = 0; i < arrResult.Length; i++)
{  
     Console.Write($"{arrResult[i]} ");   
}
Console.WriteLine();