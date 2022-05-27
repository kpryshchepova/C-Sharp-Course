using System.Collections;

public class TextTransformer
{
	public static IEnumerable Transformer(List<string> str)
    {
        if (str == null) yield return "This is null value";
        foreach (var letter in str)
        {
            yield return letter.ToUpper();
        }
    }

    public static void Show(List<string> str)
    {
        foreach (var text in Transformer(str)) Console.WriteLine(text);
    }
}
