// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int Check(int[] array)
{   
    int count = 0;
    int[] mas = array;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void FillArray(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine("Введите элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int M = 8;
int[] mas = new int[M];
FillArray(mas);
PrintArray(mas);
System.Console.WriteLine();
int res = Check(mas);
System.Console.WriteLine(res);

