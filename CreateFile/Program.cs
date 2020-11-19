using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateNewFile();
            Console.WriteLine("Enter the file name:");
            string UserInput = Console.ReadLine();
            //CreateUserFile(UserInput);
            CreateFileWithExtension(UserInput);
        }

        public static void CreateNewFile()
        {
            string roothPath = @"C:\Users\opilane\samples\playerOne";
            string fileName = "ball.txt";
            File.Create(Path.Combine(roothPath,fileName));
        }

        public static void CreateUserFile(string fileName)
        {
            string roothPath = @"C:\Users\opilane\samples\playerTwo";
            File.Create(Path.Combine(roothPath, fileName));

        }
        public static void CreateFileWithExtension(string fileName)
        {
            string roothPath = @"C:\Users\opilane\samples\playerTwo";
            string fullFileName = $"{fileName}.txt";
            File.Create(Path.Combine(roothPath, fullFileName));
        }
    }
}
