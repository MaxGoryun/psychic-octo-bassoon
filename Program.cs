/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/* int[] arrNum = new int [15];
int count = 0;

for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = new Random(). Next(100, 999);
    Console.Write(arrNum[i] + " ");

    if ( arrNum[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count); */


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/* int[] arrNum = new int [5];

int SumNum = 0;

for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = new Random(). Next(11, 100);
    Console.Write(arrNum[i] + " ");

    if (i % 2 == 0)
    {
        SumNum +=arrNum[i];
    }
}
Console.WriteLine(" ");
Console.Write(SumNum);
 */


/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

/* double[] arrNum = new double[8];

double NumMax = 0;
double NumMin = 0;

for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = new Random().Next(-99, 99);
    Console.Write(arrNum[i] + " ");
    if (arrNum[i] > NumMax)
    {
        NumMax = arrNum[i];
    }
    if (arrNum[i] < NumMin)
    {
        NumMin = arrNum[i];
    }
}
Console.WriteLine(" ");
Console.WriteLine(NumMax - NumMin); */

/* double min = double.MaxValue;
double max = double.MinValue;
 
double k;
 
for (int i = 0; i < 10; i++)
    {
        Console.Write("Введите {0}-е число: ", i + 1);
        k = double.Parse(Console.ReadLine());
 
    if (k > max)
    {
        max = k;
    }
    if (k < min)
    {
        min = k;
    }
    }
 Console.WriteLine("Разница между макс и мин: {0}", max - min);
 Console.ReadKey(); */
        