class Task9 {
    public static DirectoryInfo DirectoryInfo;
    public static string DirectoryPath = @"D:\Pryshchepava\IBA\C# 5.0 and .Net Course\C-Sharp-Course\Task9\testFolder";
    public static void ListFiles(string directory)
    {
        DirectoryInfo = new DirectoryInfo(directory);

        try
        {
            var i = 0;
            foreach (FileInfo fileInfo in DirectoryInfo.GetFiles())
            {
                i++;
                Console.WriteLine("{0}: {1}", i, fileInfo.Name);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Some problem!");
            return;
        }
        
    }

    public static void GetFile()
    {
        var value = Console.ReadLine();
        var selectedNumber = int.Parse(value) - 1;
        if (selectedNumber == null || selectedNumber > DirectoryInfo.GetFiles().Length || selectedNumber < 0)
        {
            Console.WriteLine("Select valid number!");
        } 
        else {
            Console.WriteLine(File.ReadAllText(Path.Combine(DirectoryPath, DirectoryInfo.GetFiles()[selectedNumber].Name)));
        }
    }


    static void Main()
    {
        ListFiles(DirectoryPath);
        Console.WriteLine("\nPlease, select some file from the list\n");
        GetFile();
    }
}