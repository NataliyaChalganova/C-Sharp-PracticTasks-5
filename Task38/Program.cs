// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine ("Введите количество элементов в массиве: ");
int n = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [n];

int diff = 0;
for (int i=0; i<n; i++)
{
    array[i] = new Random().Next (1, 10);
    Console.Write ($" {array[i]} ");
}
int max = array[1];
int min = array[1];

for (int m=0; m<n; m++)
{
    if (array[m] > max)
    max = array[m];
}
//Console.WriteLine ($" -->{max} ");
for (int m=0; m<n; m++)
{
    if (array[m] < min)
    min = array[m];
}  
//Console.WriteLine ($" -->{min} ");
 diff = max - min;

 Console.WriteLine ($"Разница между максимальным и минимальным значениями:  {diff}");