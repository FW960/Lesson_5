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
        static void Main()
        {

            Console.WriteLine("Введите число от 0 до 255: ");

            int UserNum = 0;

            try
            {
                UserNum = Convert.ToInt32(Console.ReadLine());



                if (UserNum > 255)
                {
                    Console.WriteLine("Введите число в заданном диапазоне");

                    return;
                }
            }
            catch
            {
                Console.WriteLine("Введите корректное число.");

                return;

            }

            string fileWay = @"C:\Users\windo\source\repos\Lesson_5\Lesson_5\Lesson_5\NewFile.bin";

            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(new FileStream(fileWay, FileMode.OpenOrCreate), UserNum);

            Console.WriteLine("Число успешно сериализовано в файл");

        }
    }
}

