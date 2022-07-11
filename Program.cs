//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] randomarray(int size, int min, int max)
{
int[] array = new int [size];
if (Check(min) & Check(max))
{
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(min,max +1);
}
}
else Console.WriteLine("Число не трехзначное или отрицательное");

return array;
}

void Showarray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    Console.WriteLine();
}

bool Check(int value) 
{
return value >99 && value <1000;
}

int CountNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0) count++;
    }
    return count;
}

int [] Myarray = randomarray(8,100,999);
Showarray(Myarray);
Console.WriteLine (CountNumbers(Myarray));
*/

//Задача 36: Задайте массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*

int[] randomarray(int size, int min, int max)
{
int[] array = new int [size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(min,max +1);
}
return array;
}

void Showarray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write (array[i] + " ");
    Console.WriteLine();
}

int Sumofnumbers (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i + 2)
    {
        sum += array[i];
    }
    
    return sum;
}

int [] Myarray = randomarray(7,1,9);
Showarray(Myarray);
Console.WriteLine (Sumofnumbers(Myarray));
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray(int elements)
{
    double[] array = new double[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (new Random().Next(1, 9)) + new Random().NextDouble();
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    
    Console.WriteLine("Максимальное значение массива: " + max);
    Console.WriteLine("Минимальное значение массива: " + min);
   
    double diff = max - min;
    diff = Math.Round(diff, 2);
    return diff;

}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

double[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Разница между max и min = : " + (Diff(newarray)));