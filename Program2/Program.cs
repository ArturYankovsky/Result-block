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

