//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray( int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
} 

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i +1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumNonEvenNum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++ )
    {
        if(i%2!=0)
        {
            sum += array[i];
        }

    }
return sum;
}

int[] arr = CreateRandomArray(5, 100, 1000);
int result = SumNonEvenNum(arr);
ShowArray(arr);
Console.WriteLine(result);