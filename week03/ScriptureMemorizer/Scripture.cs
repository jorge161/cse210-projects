using System.IO;

public class Scripture
{
   
    private List<Word> _words = new List<Word>();

    public Scripture(List<Word> words)
    {
        _words = words;
    }

    public string GetWordsText()
    {
        return string.Join(" ", _words.Select(word => word.GetText()));
    }

}