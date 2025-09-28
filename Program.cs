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
            List<DiaryEntry> entries = new List<DiaryEntry>
            {
                
            };
            foreach (var entry in entries)
            {
                Console.WriteLine($"{entry.Date.ToShortDateString()}: {entry.Text}");
            }
        }
    }
}
