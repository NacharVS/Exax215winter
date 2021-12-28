using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Start : Singer
    {
        public Start(string label, string style, string composition, string album, int year)
        {
            Label = label;
            Style = style;
            Composition = composition;
            Album = album;
            Year = year;
        }
        

        public static void StartProggram()
        {
            List<Start> listsingers = new List<Start>();
            listsingers.Add(new Start("Ramstein", "Industrial Metal", "Sonne", "Mutter", 2001));
            listsingers.Add(new Start("Svarga", "Folk Metal", "Veter", "Tam, gde dremlyut lesa", 2007));
            listsingers.Add(new Start("Ariya", "Metal", "Oskolok lda", "Himera", 2001));
            listsingers.Add(new Start("Lypis Trubetskoy", "Punk Rock", "Jelezniy", " Rabkor", 2012));
            Start.Question(listsingers);

        }
        public static void ListSingers(List<Start> listsingers)
        {
            foreach (var item in listsingers)
            {
                Console.WriteLine($"Исполнитель: {item.Label} Стиль: {item.Style} Композиция: {item.Composition} Альбом {item.Album} Год: {item.Year}");
            }
        }
        public static void NextProgram(List<Start> listsingers)
        {
            Console.Write("Введие год: ");
            int mindate = int.Parse(Console.ReadLine());
            for (int i = 0; i < listsingers.Count; i++)
            {
                if (mindate == listsingers[i].Year)
                {
                    Console.WriteLine($"Исполнитель: {listsingers[i].Label} Стиль: {listsingers[i].Style} Композиция: {listsingers[i].Composition} Альбом {listsingers[i].Album} Год: {listsingers[i].Year}");

                }
                else
                {
                    continue;
                }
            }
        }
        public static void Question(List<Start> listsingers)
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть список всех исполнителей");
            Console.WriteLine("2 - Просмотреть список исполнителей, по году выхода альбома");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Start.ListSingers(listsingers);
                    Question(listsingers);
                    break;
                case 2:
                    Start.NextProgram(listsingers);
                    Question(listsingers);
                    break;
                default:
                    Console.WriteLine("Неверная цифра");
                    Question(listsingers);
                    break;
            }
        }
            

            
            

            

    }
}
