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
Console.WriteLine("Введите число элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
void  Numbers ( int [] array)
{
    for (int i = 0; i < array.Length; i++)
             array[i] = new Random().Next(-99, 100);
}




int [] arr = new int[n];
Numbers(arr);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + " ]");