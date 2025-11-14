using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("\nEntry added successfully!!");

    }
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You don't have entries yet.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                string line = string.Join(",",
                    EscapeCSV(e._date),
                    EscapeCSV(e._promptText),
                    EscapeCSV(e._entryText)
                );
                outputFile.WriteLine(line);
            }
        }
        Console.WriteLine("Journal saved successfully as CSV\n");
    }
    private string EscapeCSV(string text)
    {
        if (text.Contains(",") || text.Contains("\"") || text.Contains("\n"))
        {
            text = text.Replace("\"", "\"\"");
            return $"\"{text}\"";
        }
        return text;
    }
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _entries.Clear(); // Clean current entries

        foreach (string line in lines)
        {
            string[] parts = ParseCSVLine(line);

            if (parts.Length == 3)
            {
                Entry e = new Entry();
                e._date = parts[0];
                e._promptText = parts[1];
                e._entryText = parts[2];

                _entries.Add(e);
            }
        }

        Console.WriteLine("Journal loaded successfully!\n");
    }

    private string[] ParseCSVLine(string line)
    {
        List<string> parts = new List<string>();
        bool insideQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '"')
            {
                insideQuotes = !insideQuotes;
                continue;
            }

            if (c == ',' && !insideQuotes)
            {
                parts.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }

        parts.Add(current);

        return parts.ToArray();
    }
}