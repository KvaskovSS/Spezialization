# Итоговая проверочная работа

---
## Задача 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

---
## Описание алгоритма решения

В начале задаётся целочисленная переменная length длины массива. Пользователь вводит ёё с клавиатуры : 
    
    Console.WriteLine("Введите длину массива");
    int length = Convert.ToInt32(Console.ReadLine());

Задаётся массив строк с длинной равной length :

    string[] arrString = new string[length];

Вызывается функция заполнения массива :

    fillArr(arrString);

Реализация данной функции : 

    void fillArr(string[] arr)
    {
        Console.Write("Заполните массив :");
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }
    }

Вызывается функция вывода в консоль для исходного массива  :
    
    printArr(arrString);

Реализация данной функции : 

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

Вызывается функция для создания нового массива, где длинна элементов не превышает 3 :
    
    newArr(arrString);

Реализация данной функции :
   
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

Данный отрезок кода создан для того, чтобы определить длину нового массива. Пришлось так делать, так как нельзя пользоваться списками

    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4)
        {
            j++;
        }
    }

Данный отрезок кода создаёт новый массив и заполняет его элементами, размер которых не превышает 3 и после этого выводит массив

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