//Task 1.  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16

// int Number(int numA, int numB)
// {
//     int res = 1;
//     for(int i = 0; i < numB; i++)
//     {
//         res *= numA;
//     }    
//     // int res = Math.Pow(numA, numB);
//     return res;    
// }
// Console.Write("Input number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int GetNum = Number(numA, numB);
// Console.Write("Answear: " + GetNum);



//Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012-> 12

// int someCount(int num)
// {

//     int digits = 0; // кол-во цифр
//     while (num > 0)
//     {
//         digits += num % 10;
//         num = num / 10;
//     }
//     return digits; 
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum {num} - {someCount(num)}");



//Task 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;    
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//          Console.Write(array[i] + " ");
//     Console.Write(array[array.Length - 1] + " ");
    
// }
// Console.Write("Input size for array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreatRandomArray(size, min, max);
// ShowArray(array);
