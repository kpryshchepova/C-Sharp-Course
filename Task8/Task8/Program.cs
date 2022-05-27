class Task8
{
    public static void Main()
    {
        Console.WriteLine("Add some text:\n");
        List<string> text = new List<string>();
        text.Add(Console.ReadLine());
        TextTransformer.Show(text);

    }
}
