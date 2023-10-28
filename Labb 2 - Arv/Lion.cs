using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Lion : Animal
    {
        public int _speed;
        public string _type;

        public Lion(string Name, string Color, int Age, string Gender, bool MeatEater, int Speed, string Type) : base(Name, Color, Age, Gender, MeatEater)
        { 
            _speed = Speed;
            _type = Type;
        }

        public void Run()
        {
            if (_speed >= 40)
            {
                Console.WriteLine($"The {_type} {_name} runs at a whooping speed of {_speed}km/h! *WHOOOSH!");
            }
            else
            {
                Console.WriteLine($"The {_type} {_name} runs at {_speed}km/h.");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The lion {_name} is showing who is the king of the savanna! *ROOOOAR!!*");
        }

        public override string ToString()
        {
            return $"The {_type}'s name is {_name}, {_gender} is {_color} and is {_age} years old.";
        }
    }
}
