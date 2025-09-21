
using System;

public class Journal  
{
    public List<Entry> _entries = new List<Entry>();

    public void ShowList()
    {
        foreach (Entry journal in _entries)
        {
            
             journal.DisplayEntry();
             Console.WriteLine("");
        }
    }


     
}