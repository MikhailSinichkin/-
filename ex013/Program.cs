﻿/* Дан текст. В тексте все пробелы заменить черточками. k->K C ->c .*/

string text = " - я думаю , - сказал князь , улыбаясь , - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля. "
            + " Вы так красноречивы . вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++ )
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text,  ' ', '|');
Console.WriteLine(newText);
