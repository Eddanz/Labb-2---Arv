using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Cat : Lion
    {
        public int _jumpHeight;
        public Cat(string Name, string Color, int Age, string Gender, bool MeatEater, int Speed, string Type, int JumpHeight) : base(Name, Color, Age, Gender, MeatEater, Speed, Type) 
        { 
            _jumpHeight = JumpHeight;
        }
        public void Jump()
        {
            Random random = new Random();
            if (random.NextDouble() < 0.2) 
            {
                Console.WriteLine($"The cat {_name} jumped from the height of {_jumpHeight}cm and did NOT land on it's feet..  *SMACK!*");
            }
            else
            {
                Console.WriteLine($"The cat {_name} jumped from the height of {_jumpHeight}cm and landed on it's feet!");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The cat {_name} wants to cuddle! *MEOW!*");
        }
    }
}
