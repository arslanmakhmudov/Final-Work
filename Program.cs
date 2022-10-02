string[] array1 = new string[4] {"Ars", "48", "Orlando","Echo"};
string[] array2 = new string[array1.Length];
void array1_checker(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[i] = array1[i];
        }
    }
}
void PrintArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.WriteLine($" {array2[i]} ");
    }
    System.Console.WriteLine();
}
array1_checker(array1, array2);
PrintArray(array2);