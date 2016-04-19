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
            string gender1, gender2;
            string occupation;
            string seaCreature;
            string animal;
            string friend;
            string tool;
            string problem;

            Console.WriteLine("Simple Adventure Game");
            Console.WriteLine();

            Console.Write("What is your name? ");
            person = Console.ReadLine();

            Console.Write("What is your gender? Please type f or m: ");
            gender1 = Console.ReadLine();

            if (gender1 == "f" || gender1 == "F" ) {
                gender1 = "she";
                gender2 = "her";
            }
            else {
                gender1 = "he";
                gender2 = "his";
            }

            Console.Write("What is your occupation? ");
            occupation = Console.ReadLine();

            Console.Write("Please tell me your favourite animal: ");
            animal = Console.ReadLine();

            Console.Write("What is the name of one of your friends? ");
            friend = Console.ReadLine();

            Console.Write("Name a problem you might face: ");
            problem = Console.ReadLine();

            Console.Write("Name a tool: ");
            tool = Console.ReadLine();

            Console.Write("Please give me the name of a sea creature: ");
            seaCreature = Console.ReadLine();

            // create some blank lines
            Console.WriteLine();
            Console.WriteLine();

            // rrite the story
            Console.WriteLine("Now one day there was a person named {0}. Now {0} was usually ", person);
            Console.WriteLine("very content to work as a {0}, but sometimes the job ", occupation);
            Console.WriteLine("was extremely difficult.");
            Console.WriteLine("One day, {0} discovered that the heartbreak of {1} had ", person, problem);
            Console.WriteLine("occurred just one time too often. \"I cant stand being a ");
            Console.WriteLine("{0} anymore!\" yelled {1}, as {2} hurled away {3}", occupation, person, gender1, gender2);
            Console.WriteLine("{0} in anger. No {1} will keep me from fulfilling ", tool, problem);
            Console.WriteLine("my dreams! What I really want, said {0}, is to be just like ", person);
            Console.WriteLine("{0}. Now THAT's somebody to admire. So {1} put away the ", friend, person);
            Console.WriteLine("{0} forever, and followed {1} into the pastoral ", tool, friend);
            Console.WriteLine("world of {0}-ranching. Eventually, {1} was able to ", animal, person);
            Console.WriteLine("retire, as happy as a {0}.", seaCreature);

            // create some blank lines
            Console.WriteLine();
            Console.WriteLine();

            // ask for Enter to quit
            Console.Write("Please press Enter to quit");
            Console.ReadLine();

        } // end main
    } // end class
} // end namespace
