using System.Globalization;

class Task8
{
    public static void Main()
    {
        DateTime dt = new DateTime();

        Console.WriteLine(dt.ToString("d", new CultureInfo("fr-FR")));
        Console.WriteLine("Add some text:\n");
        List<string> text = new List<string>();
        text.Add(Console.ReadLine());
        TextTransformer.Show(text);

    }
}
