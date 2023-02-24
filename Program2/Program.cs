string[] text = {"Привет", "world", "2", ":-)"};
string[] result = new string[text.Length];

void Replace(string[] text, string[] result)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3) 
        {
            result[count] = text[i];
            count++;
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

Console.Clear();
Replace(text, result);
PrintArray(result);