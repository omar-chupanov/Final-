string[] arr1 = new string[3] { "123", "23", "world"};
string[] arr2 = new string[arr1.Length];

void CreateArr(string[] arr1, string[] arr2)
{
    int cnt = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1.Length <= 3)
        {
            arr2[cnt]= arr1[i];
            cnt++;
        }
    }
    
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateArr( arr1,  arr2);
PrintArray(arr2);
