using System;
using System.IO;

namespace Createdirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatefolderOne();
        }

        public static void CreatefolderOne()
        {
            string roothPath = @"C:\Users\opilane\samples";
            string folderName = "playerOne";
            string fullFolderPath = Path.Combine(roothPath, folderName);
            Console.WriteLine(fullFolderPath);
            if (Directory.Exists(fullFolderPath))
            {
                Console.WriteLine("The folder already exists.");
            }else
            {
                Directory.CreateDirectory(fullFolderPath);
            }
        }
    }
}
