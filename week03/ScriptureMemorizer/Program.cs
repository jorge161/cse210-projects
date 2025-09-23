using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   // Leer las escrituras desde el archivo
        string filePath = "Escriptures.txt";
        string[] lines = File.ReadAllLines(filePath);
        Random randi = new Random();
        int randomIndex = randi.Next(lines.Length);
        string randomLine = lines[randomIndex];

        // Separar la referencia y el texto usando '#'
        string[] parts = randomLine.Split('#');
        string reference = parts[0].Trim();
        string verseText = parts[1].Trim();

        // Extraer book, chapter y verse
        string[] refParts = reference.Split(' ');
        string book = refParts[0];
        string[] chapVerse = refParts[1].Split(':');
        string chapter = chapVerse[0];
        string verse = chapVerse[1];

        // Separar el texto en palabras y crear la lista de Word
        string[] wordsArray = verseText.Split(' ');
        /////////  List<Word> words = new List<Word>();  //////////
        
        List<Word> words = new List<Word>();
        foreach (string w in wordsArray)
        {
            words.Add(new Word(w));
        }
        Scripture scriptureText = new Scripture(words);

        Console.WriteLine("Scripture Memorize");
        Console.WriteLine("-------------------");
        Console.WriteLine("Memorize the following scripture:");
        Console.Write($"{book} {chapter}:{verse}");
        Console.Write(" -- ");
        Console.WriteLine(scriptureText.GetWordsText());
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
         string input = Console.ReadLine();
         while (input.ToLower() != "quit")
         {
             // Hide a word
             Random rand = new Random();
             int index = rand.Next(words.Count);
             words[index].Hide();

             // Display the scripture with hidden words
             foreach (Word word in words)
             {
                 Console.Write(word.GetText() + " ");
             }
             Console.WriteLine();
             Console.WriteLine("-------------------");
             Console.WriteLine("Press Enter to hide another word, or type 'quit' to exit.");
             input = Console.ReadLine();
         }   

    }

}


    



