using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                output.WriteLine(entry.Date + "|" + entry.Prompt + "|" + entry.Response);
            }
        }

        Console.WriteLine("Journal saved!");
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry();
            entry.Date = parts[0];
            entry.Prompt = parts[1];
            entry.Response = parts[2];

            Entries.Add(entry);
        }

        Console.WriteLine("Journal loaded!");
    }
}