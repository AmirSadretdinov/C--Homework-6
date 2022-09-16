// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] array = {b1,k1,b2,k2};

string TochkaPeresechenia(double[] array)
{
    
    double x = (array[2]-array[0])/(array[1]-array[3]);
    double y1 = array[1] * x + array[0];
    double y2 = array[3] * x + array[2];
    string res = $"({y1} ; {y2})";
    return res;
}

string res = TochkaPeresechenia(array);
System.Console.WriteLine($"{res}");

