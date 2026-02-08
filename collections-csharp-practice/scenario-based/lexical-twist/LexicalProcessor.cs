using System;
using System.Collections.Generic;
using System.Text;

public class LexicalProcessor
{
    public bool IsInvalidWord(string word)
    {
        // Invalid if contains space (more than one word)
        return word.Contains(" ");
    }

    public bool IsReverse(string word1, string word2)
    {
        char[] arr = word1.ToLower().ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return reversed.Equals(word2.ToLower());
    }

    public string ProcessReverseCase(string word)
    {
        char[] arr = word.ToCharArray();
        Array.Reverse(arr);

        string reversed = new string(arr).ToLower();

        StringBuilder sb = new StringBuilder();
        foreach (char c in reversed)
        {
            if ("aeiou".Contains(c))
                sb.Append('@');
            else
                sb.Append(c);
        }

        return sb.ToString();
    }

    public string ProcessNonReverseCase(string word1, string word2)
    {
        string combined = (word1 + word2).ToUpper();

        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char c in combined)
        {
            if ("AEIOU".Contains(c))
                vowelCount++;
            else
                consonantCount++;
        }

        if (vowelCount > consonantCount)
        {
            return GetFirstTwoDistinct(combined, "AEIOU");
        }
        else if (consonantCount > vowelCount)
        {
            return GetFirstTwoDistinct(conbined: combined, allowed: "BCDFGHJKLMNPQRSTVWXYZ");
        }
        else
        {
            return "Vowels and consonants are equal";
        }
    }

    private string GetFirstTwoDistinct(string conbined, string allowed)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        foreach (char c in conbined)
        {
            if (allowed.Contains(c) && !seen.Contains(c))
            {
                result.Append(c);
                seen.Add(c);
            }

            if (result.Length == 2)
                break;
        }

        return result.ToString();
    }
}
