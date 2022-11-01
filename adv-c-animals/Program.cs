using System;
using System.Collections;

namespace adv_c_animals // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static FileOutput _output;
        private static FileInput _input;

        static void Main(string[] args)
        {
            ArrayList zoo = new ArrayList();
            
            UserStuff userStuff = new UserStuff();
            var useranimal = userStuff.AddingAnimal();

            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            zoo.Add(useranimal);
            

            foreach (Talkable thing in zoo)
            {
                PrintOut(thing);
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