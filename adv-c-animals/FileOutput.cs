namespace adv_c_animals;

public class FileOutput
{
    private StreamWriter rWriter = null;
    
    private string fileName;

    public FileOutput(string fileName)
    {
        this.fileName = fileName;

        try
        {
            rWriter = new StreamWriter("animals.txt");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("file open error: " + fileName + " " + e);
            throw;
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            rWriter.Write(line + "\n");
        }
        catch (Exception e)
        {
            Console.WriteLine("file write error: "+ fileName + " " + e);
            throw;
        }
    }

    public void FileClose()
    {
        if (rWriter != null)
        {
            try
            {
                rWriter.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}