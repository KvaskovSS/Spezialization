using System;

void printArr(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(i == arr.Length - 1 )
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}

void fillArr(string[] arr)
{
    Console.Write("Заполните массив :");
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

void newArr(string[] arr)
{
    Console.WriteLine("");
    Console.WriteLine("Новый массив");

    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4)
        {
            j++;
        }
    }

    string[] newArrString = new string[j];
    j = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4)
        {
            newArrString[j] = arr[i];
            j++;
        }
    }
    printArr(newArrString);
}

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());


string[] arrString = new string[length];

fillArr(arrString);
printArr(arrString);
newArr(arrString);