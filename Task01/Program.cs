string[] array1 = new string[5] { "Mon", "2", "Wens", "Thursday", "Fri" };
string[] CopyArray(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        }
    }
    string[] array2 = new string[count];
    count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    return array2;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] array2 = CopyArray(array1);
PrintArray(array2);