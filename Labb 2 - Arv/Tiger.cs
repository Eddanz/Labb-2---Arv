using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Tiger : Lion
    {
        public bool _hunt;

        public Tiger(string Name, string Color, int Age, string Gender, bool MeatEater, int Speed, string Type, bool Hunt) : base(Name, Color, Age, Gender, MeatEater, Speed, Type)
        {
           _hunt = Hunt;
        }

        public void Hunt()
        {
            if (_hunt == true)
            {
                Console.WriteLine($"The tiger {_name} leaps forward to catch their prey!");
            }
            else
            {
                Console.WriteLine($"The tiger {_name} is feeling lazy today..");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The tiger {_name} is showing who is the king of the jungle! *ROOOOAR!!*");
        }
    }
}
