using System;
using System.Collections;

namespace adv_c_animals;

public class UserStuff
{
    public static void AddingAnimal()
    {
        string? choice;
        int numberChoice, miceThing;
        string? catName, dogName;
        bool valid = false;
        int friendlyChoice;
        bool friendly;
        
        // ask the user what type of animal they want to create
        Console.WriteLine("You may create either a cat or a dog.");

        while (valid == false)
        {
            Console.WriteLine("1. for cat\n2. for Dog");
            choice = Console.ReadLine();
            
            if (int.TryParse(choice, out numberChoice))
            {
                valid = true;
                
                // accept the input(s) necessary to instantiate that type of object
                if (numberChoice == 1)
                {
                    Console.WriteLine("What is its name?");
                    catName = Console.ReadLine();
                    
                    Console.WriteLine("How many mouses has it killed?");
                    miceThing = Convert.ToInt32(Console.ReadLine());
                    
                    // create an object of that type
                    ArrayList zoo = new ArrayList();
                    zoo.Add(new Cat(miceThing, catName));
                }

                if (numberChoice == 2)
                {
                    Console.WriteLine("what is its name?");
                    dogName = Console.ReadLine();
                    
                    Console.WriteLine("is it friendly?\n1.Yes\n2.No");
                    friendlyChoice = Convert.ToInt32(Console.ReadLine());

                    if (friendlyChoice == 1)
                    {
                        friendly = true;
                    }
                    else
                    {
                        friendly = false;
                    }
                    
                    // create an object of that type
                    ArrayList zoo = new ArrayList();
                    zoo.Add(new Dog(friendly, dogName));
                }
            }
            else
            {
                Console.WriteLine("Not a valid choice, pleas try again.");
            }
        }

        

       
        
        
        //add the object to the ArrayList
    }
}