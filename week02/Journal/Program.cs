using System;

class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
}

class Program
{
    static List<JournalEntry> journal = new List<JournalEntry>();
    static Random random = new Random();
    static string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nJournal Entry App");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load Journal from File");
            Console.WriteLine("4. Save Journal to File");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    LoadJournal();
                    break;
                case "4":
                    SaveJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void WriteEntry()
    {
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine("\n" + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        journal.Add(new JournalEntry { Date = DateTime.Now.ToString("yyyy-MM-dd"), Prompt = prompt, Response = response });
        Console.WriteLine("Entry saved!");
    }

    static void DisplayEntries()
    {
        if (journal.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in journal)
        {
            Console.WriteLine($"[{entry.Date}] {entry.Prompt}\nResponse: {entry.Response}\n");
        }
    }

    static void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    static void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            journal.Clear();
            foreach (var line in File.ReadAllLines(filename))
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    journal.Add(new JournalEntry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

