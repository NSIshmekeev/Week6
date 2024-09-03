namespace Week6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Edition> catalog = new List<Edition>
            {
                new Book("C#", "Nikita", 2020, "XOR"),
                new Article("Java vs C#", "Nikita", "XOR", 5, 2021),
                new Ebook("Справочник по C#", "Unknown", "https://metanit.com/sharp/", "Какая-та аннотация"),
            };
            Console.WriteLine("Список изданий");
            foreach (var edition in catalog)
            {
                edition.DisplayInfo();
            }

            // Поиск изданий по фамилии автора
            Console.WriteLine("\nПоиск издания по автору");
            foreach (var edition in catalog.Where(e => e.IsMatchingAuthor("Nikita")))
            {
                edition.DisplayInfo();
            }
        }

    }
}