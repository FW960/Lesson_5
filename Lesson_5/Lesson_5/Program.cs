using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lesson_5

{
    [Serializable]
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое будет определять количество символов, которые вы хотите сериализовать в бинарный файл: ");

            int num = Convert.ToInt32(Console.ReadLine());

            string fileWay = @"C:\Users\windo\source\repos\Lesson_5\Lesson_5\Lesson_5\NewFile.bin";

            int[] randomNum = new int[num + 1];

            Console.WriteLine("Введите число от 0 до 255: ");

            for (int i = 1; i < randomNum.Length; i++)
            {
                int usersNum = Convert.ToInt32(Console.ReadLine());

                if (usersNum > 255)
                {
                    Console.WriteLine("Введите число в заданном диапазоне.");
                    i = i - 1;
                    continue;
                }

                randomNum[i] = usersNum;
            }
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(new FileStream(fileWay, FileMode.OpenOrCreate), randomNum);

            object[] c = File.ReadAllLines(fileWay);




        }
    }
}

