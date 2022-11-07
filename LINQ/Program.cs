using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names...
            //Order the list of games by length of the game name.
            //Use the lambda expression in this exercise as well.
            //use Method Syntax for this exercise
            var fishSpecies = new List<string> { "Largemouth Bass", "Smallmouth Bass", "Yellow Perch", "White Perch", "Black Crappie", 
                "White Crappie", "Walleye", "Sauger", "Saugeye", "Bluegill" };

            var speciesByLength = fishSpecies.OrderBy(x => x.Length).ToList();

            foreach(var fish in speciesByLength)
            {
                Console.WriteLine(fish);
            }
            
        }
    }
}
