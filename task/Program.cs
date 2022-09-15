// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите число элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void  Numbers ( int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//              array[i] = new Random().Next(100, 1000);
// }
// int NumbersEven (int [] array)
// {
//     int amount = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//             amount++;
//     return amount;
// }

// int [] arr = new int [n];
// Numbers(arr);
// Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");
// Console.WriteLine("Кол-во четных чисел: " + NumbersEven(arr));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Massiv (int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-99, 100);
// }
// int Summ (int [] array)
// {
//     int result = 0;
//     for(int i = 1; i < array.Length; i += 2) 
//     result = result + array[i];
//     return result;
// }

// int [] arr = new int [n];
// Massiv(arr);
// Console.WriteLine("Исходный массив : [" + string.Join (", ", arr) + " ]");
// Console.WriteLine("Сумма нечётных элементов в массиве = " + Summ(arr));

// Задача 38: Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,5 7,78 22 2,23 78, 25] -> 76,02

double [] array = {85.4 , 33.5 , 45.5 , 34.56 , 67.4 , 78 , 37.4 , 75.57 };
double Massiv(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
     {   if(arr[i] >= max)
            max = arr[i];
        for (int j = 0; j < arr.Length; j++)
          {  if (min >= arr[j])
                min = arr[j];
          }
     }
     double result = max - min;
     return result;
}
Massiv(array);
Console.WriteLine("Массив : [ " + string.Join(", ", array) + " ]");
Console.WriteLine("Разница между максимальным и "  + Massiv(array));