
using System;

public interface IJournal
{
    void ShowList();
}

public class Journal : IJournal
{
    public List<Entry> _entries = new List<Entry>();

    public void ShowList()
    {
        foreach (Entry journal in _entries)
        {
            
             journal.DisplayEntry();
              
        }
    }


     
}