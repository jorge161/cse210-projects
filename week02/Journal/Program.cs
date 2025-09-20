using System;
using System.Collections.Generic;

// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO;

Journal journal = new Journal();
Options option = new Options();


PromptGenerator promptGenerator = new PromptGenerator();

bool exit = false;

while (!exit)
{
    option.DisplayAll();


    string choice = Console.ReadLine();
    Console.WriteLine("");

    Options options = new Options();
    options.DisplayAll();

    switch (choice)
    {
        case "1":
            Entry entry = new Entry();
            Console.WriteLine("");
            Console.WriteLine("You choose option 1.");
            Console.WriteLine("");
            entry._promptText = promptGenerator.getPrompt();
            Console.WriteLine(entry._promptText);
            entry._entryText = Console.ReadLine();
            entry._date = DateTime.Now.ToShortDateString();


            // Agregar a la lista del Journal
            journal._entries.Add(entry);



            break;

        case "2":
            Console.WriteLine("");
            Console.WriteLine("You choose option 2.");
            journal.ShowList();


            break;

        case "3":

            Console.Write("Chose the file name you want to open.");
            string fileName = Console.ReadLine();
            string file = $"{fileName}.txt";

            if (File.Exists(file))
            {
                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"El archivo {file} no existe.");
            }

            break;

        case "4":

            Console.Write("Chose the file name whithout space and whithout txt.");
            string myFile = Console.ReadLine();
            string address = $"{myFile}.txt";



            using (StreamWriter outputFile = new StreamWriter(address, true))
            {

                foreach (Entry entri in journal._entries)
                {
                    outputFile.WriteLine($"{entri._date} - {entri._promptText} - {entri._entryText}");
                }   
                    
            }

            Console.WriteLine($"The file {address} was saved.");

            break;
        case "5":
            Console.WriteLine(" Exiting the program. Goodbye!");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            Console.WriteLine(" ");
            break;
    }
}

