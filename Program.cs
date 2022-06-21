/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] FillArray(int[] array, int length)
{

    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-77, 77);
    }

return array;
}

void PrintArray(int[] array, int length)
{

    for(int i = 0; i < length; i++)
    {
            Console.Write($"{array[i]}");
            if (i+1 != length)
            {
                Console.Write(", ");  
            }
            else
            {
                Console.WriteLine(". ");
            }
    } 
}

void DiffMaxMinArray (int[] array)
{
    int MinNumber = array[0];
    int MaxNumber = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < MinNumber)
        {
            MinNumber = array[i];
        }
        else if(MaxNumber < array[i]) 
        {
            MaxNumber = array[i];
        }

    } 

    Console.Write($"The difference between the maximum and minimum number = {MaxNumber-MinNumber}");
}



Console.Write("Input length array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array, length);
PrintArray(array, length);
DiffMaxMinArray(array);