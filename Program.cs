namespace Dagboksappen
{
    public class DiaryEntry
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            
            while (true) {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Skriv ny anteckning");
                Console.WriteLine("2. Anteckningslista");
                Console.WriteLine("3. Sök anteckningar på datum");
                Console.WriteLine("4. Spara");
                Console.WriteLine("5. Läs fil");
                Console.WriteLine("6. Avsluta");
                var choice = Console.ReadLine();
                
                switch(choice)
                {
                    case "1": AddEntry();
                        break;
                    case "2": ListEntries();
                        break;
                    case "3": SearchEntry();
                        break;
                    case "4": SaveEntry();
                        break;
                    case "5": ReadEntry();
                        break;
                    case "6": return;
                    default: Console.WriteLine("Ogiltigt val.");
                        break;
                }
        }
    }
}
