// int[] generateArray()
// {
//     Console.WriteLine("Please enter a number:");
//     int num = int.Parse(Console.ReadLine());
//     int[] result = new int[num];
//     Random rd = new Random();
//     for (int i = 0; i < num; i++)
//     {

//         result[i] = rd.Next(10);
//         Console.WriteLine("arr[" + i + "] = " + result[i]);
//     }
//     return result;
// }

// int countNumber(int[] arr, int num)
// {
//     int count = 0;
//     foreach (var item in arr)
//     {
//         if (item == num) count++;
//     }
//     return count;
// }

// int[] arr = generateArray();

// Console.WriteLine(countNumber(arr, 7));


// int[] mergeTwoArray(int[] arr1, int[] arr2)
// {
//     int[] result = new int[arr1.Length + arr2.Length];
//     for (int i = 0; i < arr1.Length; i++)
//     {
//         result[i] = arr1[i];
//     }
//     for (int i = 0; i < arr2.Length; i++)
//     {
//         result[arr1.Length + i] = arr2[i];
//     }
//     return result;
// }
// //[1,2,3,4] [3,4,5,6];
// //[1,2,3,4,3,4,5,6]
// int[] array1 = { 1, 3, 2, 6 };
// int[] array2 = { 2, 4, 5, 7 };

// int[] demo = mergeTwoArray(array1, array2);

// foreach (var item in demo)
// {
//     Console.Write(item + " ");
// }
void printArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
}
int mySqrt(int num)
{
    int a = 10;
    int b = 20;
    for (int i = 1; i < num; i++)
    {
        if (i * i == num)
        {
            return i;
        }
    }
    return -1;
}
//[1,2,3,4], 2
//[1,3,4,0] 2 => 1
// int result1 = mySqrt(12);
// int result2 = mySqrt(9);
// int result3 = mySqrt(16);
// Console.WriteLine(result1);
// Console.WriteLine(result2);
// Console.WriteLine(result3);

int findIndex(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return i;
        }
    }
    return -1;
}

int removeNumber(int[] array, int num)
{
    int result = findIndex(array, num);
    if (result == -1)
    {
        return -1;
    }
    for (int i = result; i < array.Length - 1; i++)
    {
        array[i] = array[i + 1];
    }
    array[array.Length - 1] = 0;
    printArray(array);
    return result;
}
int[] arr = { 1, 2, 4, 5 };
Console.WriteLine("Index = " + removeNumber(arr, 2));

