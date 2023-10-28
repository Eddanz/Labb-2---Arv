using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Dog : Animal
    {
        public string _breed;

        public Dog(string Name, string Color, int Age, string Gender, bool MeatEater, string Breed) : base(Name, Color, Age, Gender, MeatEater)
        {
            _breed = Breed;
        }

        public void Walk()
        {
            Console.WriteLine($"You take the dog {_name} out for a walk.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The dog {_name} wants to play! *BARKS!*");
        }

        public override string ToString()
        {
            return $"The dog's name is {_name}, {_gender} is a {_color} {_breed} and is {_age} years old.";
        }
    }
}
