using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Animal
    {
        public string _name;
        public string _color;
        public int _age;
        public string _gender;
        public bool _meatEater;

        public Animal(string Name, string Color, int Age, string Gender, bool MeatEater)
        { 
            _name = Name;
            _color = Color;
            _age = Age;
            _gender = Gender;
            _meatEater = MeatEater;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal growls! *GRRRR!*");
        }

        public void Eat() 
        {
            if (_meatEater == true)
            {
                Console.WriteLine("The animal eats meat.");
            }
            else
            {
                Console.WriteLine("The animal eats grass.");
            }
        }

        public void Sleep()
        {
            Console.WriteLine($"{_name} is sleeping.. *zzZZzz*");
        }

        public static void Run()
        {
            Cow Daisy = new Cow("Daisy", "black with white spots", 5, "she", false, true);
            Dog Sixten = new Dog("Sixten", "brown", 10, "he", true, "border terrier");
            Lion Simba = new Lion("Simba", "yellow", 3, "he", true, 70, "lion");
            Tiger Zara = new Tiger("Zara", "orange with black stripes", 8, "she", true, 60, "tiger", true);
            Cat Louie = new Cat("Louie", "cream and black", 3, "he", true, 30, "cat", 200);

            Console.WriteLine(Daisy);
            Daisy.MakeSound();
            Daisy.Lives();
            Console.WriteLine();

            Console.WriteLine(Sixten);
            Sixten.MakeSound();
            Sixten.Walk();
            Console.WriteLine();

            Console.WriteLine(Simba);
            Simba.MakeSound();
            Simba.Run();
            Console.WriteLine();

            Console.WriteLine(Zara);
            Zara.MakeSound();
            Zara.Run();
            Zara.Hunt();
            Console.WriteLine();

            Console.WriteLine(Louie);
            Louie.MakeSound();
            Louie.Run();
            Louie.Jump();
        }
    }
}
