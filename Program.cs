string[] array1 = new string[4] {"456", "8548", "Orlando","Echo"};
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
