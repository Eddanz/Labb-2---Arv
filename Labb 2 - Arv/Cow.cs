using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Cow : Animal
    {
        public bool _outdoor;

        public Cow(string Name, string Color, int Age, string Gender, bool MeatEater, bool Outdoor) : base(Name, Color, Age, Gender, MeatEater)
        {
            _outdoor = Outdoor;
        }

        public void Lives()
        {
            if (_outdoor == true) 
            {
                Console.WriteLine("The cow roams free outdoors.");
            }
            else
            {
                Console.WriteLine("The cow lives inside of a barn.");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The cow {_name} sounds happy! *MOOOO!*");
        }

        public override string ToString()
        {
            return $"The cow's name is {_name}, {_gender} is {_color} and is {_age} years old.";
        }
    }
}
