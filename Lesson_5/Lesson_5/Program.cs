using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_5

{
    internal class Program
    {
        static void Main()
        {
            DirectoriesAndFile preview = new DirectoriesAndFile();

            File.Delete(preview.FileCreation);

            CalculatingMethod(preview.AllArraysOfFiles);
        }

        static string[][] CalculatingMethod(string[][] array)
        {
            DirectoriesAndFile DirAndFiles = new DirectoriesAndFile();

            bool existsFile = File.Exists(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation));

            if (existsFile == true)
            {

                return array;

            }

            bool existDirBranchRecursy = Directory.Exists(DirAndFiles.fourth);

            if (existDirBranchRecursy == true)
            {
                File.WriteAllText(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), "");

                File.Create(Path.Combine(DirAndFiles.fourth, "LastFile"));

                Directory.CreateDirectory(Path.Combine(DirAndFiles.fourth, "LastDir"));

                array[3] = Directory.EnumerateFileSystemEntries(DirAndFiles.fourth).ToArray();

                array = CalculatingMethod(array);

                return array;

            }

            bool existDirwindows = Directory.Exists(DirAndFiles.third);

            if (existDirwindows == true)
            {
                Directory.CreateDirectory(DirAndFiles.fourth);

                File.Create(Path.Combine(DirAndFiles.third, "WoWFile"));

                Directory.CreateDirectory(Path.Combine(DirAndFiles.third, "WoWDir"));

                array[2] = Directory.EnumerateFileSystemEntries(DirAndFiles.third).ToArray();

                array = CalculatingMethod(array);

                return array;


            }

            bool existDirnewUser = Directory.Exists(DirAndFiles.second);

            if (existDirnewUser == true)
            {
                Directory.CreateDirectory(DirAndFiles.third);

                File.Create(Path.Combine(DirAndFiles.second, "NewFile"));

                Directory.CreateDirectory(Path.Combine(DirAndFiles.second, "NewDir"));

                array[1] = Directory.EnumerateFileSystemEntries(DirAndFiles.second).ToArray();

                array = CalculatingMethod(array);

                return array;

            }

            Directory.CreateDirectory(DirAndFiles.second);

            array[0] = Directory.EnumerateFileSystemEntries(DirAndFiles.first).ToArray();

            array = CalculatingMethod(array);

            File.AppendAllLines(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), array[0]);
            File.AppendAllText(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), Environment.NewLine);
            File.AppendAllLines(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), array[1]);
            File.AppendAllText(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), Environment.NewLine);
            File.AppendAllLines(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), array[2]);
            File.AppendAllText(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), Environment.NewLine);
            File.AppendAllLines(Path.Combine(DirAndFiles.fourth, DirAndFiles.FileCreation), array[3]);

            return array;

        }



        public class DirectoriesAndFile
        {
            public string first = @"C:\";
            public string second = @"C:\newUser\";
            public string third = @"C:\newUser\windows\";
            public string fourth = @"C:\newUser\windows\BranchRecursy";
            public string FileCreation = "Text.txt";
            public string[][] AllArraysOfFiles = new string[4][];

        }

    }
}

