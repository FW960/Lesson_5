using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Lesson_5

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string creatingExampleDir = @"C:\Users\windo\exampleDir";

            Directory.CreateDirectory(creatingExampleDir);

            string FileText = "Something";

            string creatingAFile = Path.Combine(creatingExampleDir, "AlmostFirstFile.txt");

            File.WriteAllText(creatingAFile, FileText);
        }
    }
}

