// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

void FillTheArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2);
    }
   Console.Write($"[{string.Join(",",arr)}]");
}

int[] arr = new int[8];

FillTheArray(arr);
