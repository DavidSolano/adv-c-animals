using System;
using System.Collections;

namespace adv_c_animals // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static FileOutput _output = null;
        private static FileInput _input = new FileInput("animals.txt");

        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();

            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            foreach (Talkable thing in zoo)
            {
                Console.WriteLine(thing);
            }
            
            _input.FileRead();
            _input.FileClose();

            FileInput indata = new FileInput("animals.txt");
            string line;

            while ((line = indata.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(Talkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.talk());
            _output = new FileOutput("animals.txt");
            _output.FileWrite(p.GetName() + " | " + p.talk());
        }
    }
}