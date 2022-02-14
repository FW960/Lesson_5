using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
namespace Lesson_5

{

    public class ToDo
    {
        static void Main()
        {
            string FilePath = @"C:\Users\windo\source\repos\Lesson_5\Lesson_5\Lesson_5\json1.json";

            Title title = new Title();

            IsDone isDone = new IsDone();

            string ReadingTextFromJson = File.ReadAllText(FilePath);

            Title DeserializingTextFromJson = JsonSerializer.Deserialize<Title>(ReadingTextFromJson);

            Console.WriteLine(ReadingTextFromJson);

            Console.WriteLine("Введите номер задачи, которую вы выполнили.");

            userChoice();
        }


        static void userChoice()
        {
            string FilePath = @"C:\Users\windo\source\repos\Lesson_5\Lesson_5\Lesson_5\json1.json";

            Title title = new Title();

            IsDone isDone = new IsDone();

            int UsersChoice = Convert.ToInt32(Console.ReadLine());

            switch (UsersChoice)
            {
                case 1:
                    isDone.done1 = "X";
                    title.Exercise = isDone.done1;
                    string firstChoice = JsonSerializer.Serialize(title);
                    File.WriteAllText(FilePath, firstChoice);
                    string firstTitleIsDone = File.ReadAllText(FilePath);
                    Console.WriteLine(firstTitleIsDone);
                    break;
                case 2:
                    isDone.done2 = "X";
                    title.Cooking = isDone.done2;
                    string secongChoice = JsonSerializer.Serialize(title);
                    File.WriteAllText(FilePath, secongChoice);
                    string secondTitleIsDone = File.ReadAllText(FilePath);
                    Console.WriteLine(secondTitleIsDone);
                    break;
                case 3:
                    isDone.done3 = "X";
                    title.Work = isDone.done3;
                    string thirdChoice = JsonSerializer.Serialize(title);
                    File.WriteAllText(FilePath, thirdChoice);
                    string thirdTitleIsDone = File.ReadAllText(FilePath);
                    Console.WriteLine(thirdTitleIsDone);
                    break;
                case 4:
                    isDone.done4 = "X";
                    title.WatchingTV = isDone.done4;
                    string fourthChoice = JsonSerializer.Serialize(title);
                    File.WriteAllText(FilePath, fourthChoice);
                    string fourthTitleIsDone = File.ReadAllText(FilePath);
                    Console.WriteLine(fourthTitleIsDone);
                    break;
                default: break;
            }
        }




    }

    public class Title
    {
        public string Exercise { get; set; }

        public string Cooking { get; set; }

        public string Work { get; set; }

        public string WatchingTV { get; set; }

    }
    public class IsDone
    {
        public string done1 { get; set; }
        public string done2 { get; set; }
        public string done3 { get; set; }
        public string done4 { get; set; }

    }
}




