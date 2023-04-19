




void ShortStrings(string[] array, string[] creatArray, int num)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
        {
            creatArray[j] = array[i];
            j++;
        }
    }
}

int CountSizeArray(string[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
            count++;
    }
    return count;
}