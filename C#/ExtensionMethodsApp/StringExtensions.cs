namespace ExtensionMethodsApp;

public static class StringExtensions
{
    public static string Capitalize(this string text)
    {
        return char.ToUpper(text[0]) + text[1..].ToLower();
    }

    private static bool IsLower(this string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]) == false)
                return false;
        }

        return true;
    }

    public static bool IsCapitalized(this string text)
    {
        return text.IsCapitalized(false);
    }

    public static bool IsCapitalized(this string text, bool throwException)
    {
        bool isCapitalized = char.IsUpper(text[0]) && text[1..].IsLower();

        // return throwException && isCapitalized
        //     ? throw new Exception($"String 'text' is not capitalized!")
        //     : isCapitalized;

        if (throwException && isCapitalized == false)
        {
            throw new Exception($"String '{text}' is not capitalized!");
        }

        return isCapitalized;
    }
}