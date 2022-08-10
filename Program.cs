//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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
    int i_min = 1;
    int i_max  = 1;
    int max = 0;
    int min = 0;
    int result = 0;

    for(int i = 0; i < array.Length; i++ )
    {
            if(array[i]<array[i_min])
            { 
             i_min = i;
             min=array[i_min];
            
            }
    
            if(array[i]>array[i_max])
            { 
             i_max = i;
             max=array[i_max];
            }
            
    }
Console.WriteLine(max+ " "+min);

return result=max-min;
}

int[] arr = {333,44,63, 45, 76, 14, 13};
int res = SumNonEvenNum(arr);
ShowArray(arr);
Console.WriteLine(res);