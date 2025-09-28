using Dagboksappen;
using System;
using System.Collections.Generic;

namespace Dagboksappen
{
    public class DiaryEntry
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    public class Program
    {
        private static List<DiaryEntry> entries = new();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Skriv ny anteckning");
                Console.WriteLine("2. Anteckningslista");
                Console.WriteLine("3. Sök anteckningar på datum");
                Console.WriteLine("4. Spara");
                Console.WriteLine("5. Läs fil");
                Console.WriteLine("6. Avsluta");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEntry();
                        break;
                    case "2":
                        ListEntries();
                        break;
                    case "3":
                        SearchEntry();
                        break;
                    case "4":
                        SaveEntry();
                        break;
                    case "5":
                        ReadEntry();
                        break;
                    case "6": return;
                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }

        private static void AddEntry()
        {
            Console.WriteLine("Skriv datum här: (YYYY-MM-DD)");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Ogiltigt datum.");
                return;
            }
            Console.WriteLine("Skriv din anteckning här:");
            string text = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Anteckningen kan inte vara tom.");
                return;
            }
            entries.Add(new DiaryEntry { Date = date, Text = text });
            Console.WriteLine("Anteckning tillagd.");
        }

        private static void ListEntries()
        {
            foreach (var entry in entries)
                Console.WriteLine($"{entry.Date:yyyy-MM-dd}: {entry.Text}");
        }

        // Placeholder methods 
        private static void SearchEntry() { }
        private static void SaveEntry() { }
        private static void ReadEntry() { }
    }
}