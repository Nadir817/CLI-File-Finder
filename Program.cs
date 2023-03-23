using System;
using System.IO;
using System.Collections.Generic;

public class Functions
{
    public static IEnumerable<string> FindFiles(string folderName, string fileName)
    {
        List<string> salesFiles = new List<string>();

        var fileNames = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

        foreach (var file in fileNames)
        {
            if (file.EndsWith(fileName))
            {
                salesFiles.Add(file);
            }
        }

        return salesFiles;
    }
}


class MainClass
{
    static int Main(string[] args)
    {
        // Test if input arguments were supplied.
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter folder name.");
            return 1;
        }
        string folderName = args[0];
        string fileName = args[1];
        var saleFiles = Functions.FindFiles(folderName, fileName);
        foreach (var file in saleFiles)
        {
            Console.WriteLine(file);
        }
        return 0;
    }
}



