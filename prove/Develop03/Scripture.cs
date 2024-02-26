namespace Scripture;
using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Scripture{

    private void ConvertToList(string verses)
    {
       List<string> scriptureWords = verses.Split(' ').ToList();
       scriptureWords = new List<string>();
       foreach (string words in scriptureWords)
       {
        Word singleWord = new Word(words);
            scriptureWords.Append(singleWord);
        };
    }


    };