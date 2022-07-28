using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Animal
    {
        public string Name { get; set; } = "Stray";
        public int Weight { get; set; } = 5;
        public float Height { get; set; } = .30f;
        public int AnimalID { get; set; }

        public Animal(string name = "No name", int weight = 0, float height = 0)
        {

            Name = name;
            Weight = weight;
            Height = height;


        }
       
        
        public override string ToString() // Let's override ToString...
        {
            return String.Format($"{Name} weighs {Weight} kg and {Height} cm tall...");
        }
    }
}
