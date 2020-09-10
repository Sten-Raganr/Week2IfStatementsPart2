using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal1;

            Console.WriteLine("Personality Test. What kind of animals you like? Dogs Or Cats or something else. ");
            animal1 = Console.ReadLine();
            if (animal1 == "cats")
                Console.WriteLine("You Like cats, you are homebird.");
            else if (animal1 == "dogs")
                Console.WriteLine("You like dogs, you are partygoer.");
            else Console.WriteLine($"You like {animal1}, you are animal friend.");



            


        }    
    }    
}
