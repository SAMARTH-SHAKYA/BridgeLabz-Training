using System.Text;

public class StringUtility
{
    public string CleanseAndInvert(string input)
    {
        // Rule 1: Null or length < 6
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return string.Empty;
        }

        // Rule 2: Only alphabets allowed
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return string.Empty;
            }
        }

        // Convert to lowercase
        input = input.ToLower();

        StringBuilder filtered = new StringBuilder();

        // Remove characters with even ASCII values
        foreach (char c in input)
        {
            if ((int)c % 2 != 0)
            {
                filtered.Append(c);
            }
        }

        // Reverse the filtered characters
        char[] arr = filtered.ToString().ToCharArray();
        System.Array.Reverse(arr);

        StringBuilder result = new StringBuilder();

        // Convert even index characters to uppercase (0-based)
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                result.Append(char.ToUpper(arr[i]));
            else
                result.Append(arr[i]);
        }

        return result.ToString();
    }
}
