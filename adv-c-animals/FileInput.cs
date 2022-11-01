using System.Linq.Expressions;
using System;
using System.IO;


namespace adv_c_animals;

public class FileInput
{
    StreamReader sr;
    
    private string fileName;

    public FileInput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            sr = new StreamReader("animals.txt");
            sr.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
            throw;
        }
    }

    public void FileRead()
    {
        string text = File.ReadAllText("animals.txt");
        Console.WriteLine(text);
    }

    public String FileReadLine() {
        try {
            String line = sr.ReadLine();
            return line;
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + fileName + " " + e);
            return null;
        }
    }

    public void FileClose()
    {
        try
        {
            sr.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine(e.StackTrace);
            throw;
        }
    }
}