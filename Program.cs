using System.Collections.Generic;
using System;
using System.Text;
namespace TextAnalysis;

public static class TextGeneratorTask
{
    public static string ContinuePhrase(Dictionary<string, string> nextWords, string phraseBeginning, int wordsCount)
    {
        if (wordsCount == 0) return phraseBeginning;
        string[] a = phraseBeginning.Split(' ');
        string begin1 = a[a.Length - 1];
        if (a.Length > 1)
        {
            string begin = string.Join(" ", a[a.Length - 2], a[a.Length - 1]);
            if (nextWords.ContainsKey(begin))
            {
                phraseBeginning += " " + nextWords[begin];
            }
            else if (nextWords.ContainsKey(begin1))
            {
                phraseBeginning += " " + nextWords[begin1];
            }
        }
        else if (nextWords.ContainsKey(begin1))
            phraseBeginning += " " + nextWords[begin1];
        return ContinuePhrase(nextWords, phraseBeginning, wordsCount - 1);
    }
}
public static class FrequencyAnalysisTask
{
    public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
    {
        var result = new Dictionary<string, string>();
        var dictionary = BiGramm(text);
        var dictionary2 = ThreeGramm(text);
        DictionaryAdd(dictionary,result);
        DictionaryAdd(dictionary2,result);
        return result;
    }
    public static Dictionary<string,string> DictionaryAdd (Dictionary<string, Dictionary<string, int>> dictionary,Dictionary<string,string>result)
    {
        
        foreach (var c in dictionary)
        {
            foreach (var item in c.Value)
            {
                result[c.Key] = item.Key;
            }
        }
        return result;

    }
    public static Dictionary<string, Dictionary<string, int>> BiGramm (List<List<string>> text)
    {
        var dictionary = new Dictionary<string, Dictionary<string, int>>();

        foreach (var item in text)
        {
            for (int i = 0; i < item.Count - 1; i++)
            {
                string key = item[i];
                string value = item[i + 1];
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, new Dictionary<string, int>());
                }
                if (!dictionary[key].ContainsKey(value))
                {
                    dictionary[key][value] = 1;
                }
                else
                {
                    dictionary[key][value]++;
                }
            }
        }

        DictionaryNewSort(dictionary); 
            return dictionary;
    }
    public static Dictionary<string, Dictionary<string, int>> ThreeGramm(List<List<string>> text)
    {
        var dictionary = new Dictionary<string, Dictionary<string, int>>();

        foreach (var item in text)
        {
            if (item.Count < 3) continue;
            for (int i = 0; i < item.Count - 2; i++)
            {
                string key = item[i]+" "+item[i+1];
                string value = item[i + 2];
                if (!dictionary.ContainsKey(key))
                {
                    dictionary.Add(key, new Dictionary<string, int>());
                }
                if (!dictionary[key].ContainsKey(value))
                {
                    dictionary[key][value] = 1;
                }
                else
                {
                    dictionary[key][value]++;
                }
            }
        }
        DictionaryNewSort(dictionary);
        return dictionary;
    }
    public static Dictionary<string, Dictionary<string, int>> DictionaryNewSort(Dictionary<string, Dictionary<string, int>> dictionary)
    {
        foreach (var c in dictionary)
        {
            int number = 0;
            string s = null;
            foreach (var item in c.Value)
            {
                if (item.Value > number)
                {
                    number = item.Value;
                    s = item.Key;
                }
                else if (item.Value == number)
                {
                    if (string.CompareOrdinal(s, item.Key) > 0)
                    {
                        s = item.Key;
                    }
                }
            }
            c.Value.Clear();
            c.Value.Add(s, 1);
        }
            return dictionary;
    }
}
public static class SentencesParserTask
{
    public static List<List<string>> ParseSentences(string text)
    {
        List<List<string>> result = new List<List<string>>();
        var res = new List<string>();
        var sentenseList = text.ToLower()
                        .Split(new[] { ".", "!", "?", ";", ":", "(", ")" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        foreach (var sentense in sentenseList) 
        {
            if (!sentense.Any(s => Char.IsLetter(s)))
                continue;
            res.Add(sentense.Trim());
        }
        foreach (var sentense in res)
        {
            var res1 = Parse(sentense);
            result.Add(res1);       
        }
        return result;
    }
    public static List<string> Parse (string text)
    {
        var list = text.Trim().Split(new[]  {
'^', '#', '$', '-', '—', '+', '0', '1',
'2', '3', '4', '5', '6', '7', '8', '9', '=',
'\t', '\n', '\r', ',', '…', '“',
'”', '<', '>', '‘', '*', ' ', '/','\u00A0'}, StringSplitOptions.RemoveEmptyEntries).ToList();
        return list;
    }
}
