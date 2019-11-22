using System;
using System.Text;

namespace T1ReadFileFromGivenPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path: ");
            var folderPath = Console.ReadLine();

            if (!folderPath.Contains("\\"))
            {
                Console.WriteLine("this is not a path");
                return;
            }
            Console.WriteLine("Enter file name: ");
            
            var fileName = Console.ReadLine();
            var builder = new StringBuilder();

            builder.Append(@"");
            builder.Append(folderPath);
            builder.Append(fileName);
            Console.WriteLine(builder.ToString());
            var fullPath = builder.ToString();

            ReadFromGivenPath read = new ReadFromGivenPath();
            read.RunFromGivenPathAndFile(fullPath);
        }

    }
}
