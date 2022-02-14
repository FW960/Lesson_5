using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_5

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\";
            string b = @"C:\Users";
            string c = @"C:\Users\windo";
            string d = @"C:\Users\windo\Branch";

            string FileCreation = Path.Combine(d, "File.txt");

            File.AppendAllText(FileCreation, Environment.NewLine);

            string[] firstDir = Directory.EnumerateFileSystemEntries(a).ToArray();

            for (int i = 0; i < firstDir.Length; i++)
            {
                if (firstDir[i] == b)
                {
                    string[] secondDir = Directory.EnumerateFileSystemEntries(firstDir[i]).ToArray();

                    for (int j = 0; j < secondDir.Length; j++)
                    {
                        if (secondDir[j] == c)
                        {
                            string[] thirdDir = Directory.EnumerateFileSystemEntries(secondDir[j]).ToArray();

                            for (int k = 0; k < thirdDir.Length; k++)
                            {
                                if (thirdDir[k] == d)
                                {
                                    string[] fourthDir = Directory.EnumerateFileSystemEntries(thirdDir[k]).ToArray();

                                    for (int l = 0; l < fourthDir.Length; l++)
                                    {
                                        if (fourthDir[l] == FileCreation)
                                        {
                                            WritingAllDirAndFilesBranchesInOneFile(firstDir, secondDir, thirdDir, fourthDir, FileCreation);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }

        }
        static void WritingAllDirAndFilesBranchesInOneFile(string[] dir1, string[] dir2, string[] dir3, string[] dir4, string File1)
        {
            string[][] c = new string[4][];

            c[0] = dir1;

            c[1] = dir2;

            c[2] = dir3;

            c[3] = dir4;
            File.AppendAllText(File1, "@Branch 1: ");
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllLines(File1, c[0]);
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllText(File1, "Branch 2: ");
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllLines(File1, c[1]);
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllText(File1, "Branch 3: ");
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllLines(File1, c[2]);
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllText(File1, "Where file is: ");
            File.AppendAllText(File1, Environment.NewLine);
            File.AppendAllLines(File1, c[3]);


        }
    }
}


