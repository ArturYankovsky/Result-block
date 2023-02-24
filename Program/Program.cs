string[] text = {"Привет", "wor", "2", ":-)"};
string Replace(string[] text)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i].Length <= 3) result = result + text[i] + " ";
        
    }
    Console.Write(result);
    return result;
    
}
Console.Clear();
Replace(text);
Console.WriteLine();
