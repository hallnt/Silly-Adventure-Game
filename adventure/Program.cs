using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventure
{
    /// <summary>
    /// Silly Adventure Game
    /// User responds to some questions and these responses
    /// are used to write a goofy story.
    /// Teleisha Hall, 18/04/16
    /// </summary>
    class Adventure
    {
        static void Main(string[] args)
        {
            string person;
            string occupation;
            string seaCreature;
            string animal;
            string friend;
            string tool;
            string problem;

            Console.WriteLine("Simple Adventure Game");

            Console.WriteLine("What is your name?");
            person = Console.ReadLine();

            Console.WriteLine("What is your occupation?");
            occupation = Console.ReadLine();

            Console.WriteLine("Please tell me your favourite animal: ");
            animal = Console.ReadLine();

            Console.WriteLine("What is the name of one of your friends?");
            friend = Console.ReadLine();

            Console.WriteLine("Name a problem you might face: ");
            problem = Console.ReadLine();

            Console.WriteLine("Name a tool: ");
            tool = Console.ReadLine();

            Console.WriteLine("Please give me the name of a sea creature: ");
            seaCreature = Console.ReadLine();

            // create some blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Write the story


        }
    }
}
