using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    // Language Integrated Query (LINQ) provides
    // many tools for working with data
    // LINQ is similar to SQL, but it can work
    // with data aside from databases
    // You manipulate data using Query Expressions

    internal class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();

            // Get the array returned and print it...
            int[] intArray = QueryIntArray();

            // have to cycle intArray to see result..
            // remember if you have one line
            // after any loop then you can delete
            // curly brackets.
            foreach (int i in intArray)
                Console.WriteLine(i);

            QueryArrayList();
            QueryCollection();





            Console.ReadKey();

        }

        private static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal
                {
                    Name = "German Shepherd",
                    Height = 25f,
                    Weight = 77
                },
                new Animal
                {
                    Name = "Pekinesse",
                    Height = 7f,
                    Weight = 100
                },

                new Animal
                {
                    Name = "Dogo-Adana",
                    Height = 50f,
                    Weight = 250
                }
            };


            var bigDogs = from dog in animalList
                          where (dog.Weight > 10) && (dog.Height > 10)
                          orderby dog.Name
                          select dog;
            foreach (var dog in bigDogs)

                Console.WriteLine("A {0} weighs {1} kg",
                    dog.Name, dog.Weight);
            

            Console.WriteLine();
            
        }

        private static void QueryArrayList()
        {
            var FavouriteAnimals = new ArrayList()
            {
                new Animal
                {
                Name = "Heidi",
                Height = .7f,
                Weight = 20
               
                }, 
                new Animal
                {
                Name = "Shrek",
                Height = 2f,
                Weight = 200
               
                }, 
                new Animal
                {
                Name = "Blackhead",
                Height = 1f,
                Weight = 55
               
                }, 
                new Animal
                {
                Name = "Peter",
                Height = 1.5f,
                Weight = 35
               
                },

                
            };

            // have to convert arraylist into
            // an IEnumerable
            var FavAnimalEnum = FavouriteAnimals.OfType<Animal>();

            var smallAnimals = from animal in FavAnimalEnum
                               where animal.Weight <= 250
                               orderby animal.Name
                               select animal;

            //Cycle it...
            foreach (var animal in smallAnimals)
                Console.WriteLine("{0} weighs {1} kg",
                    animal.Name, animal.Weight);
            Console.WriteLine();
        }

        private static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            // Get numbers bigger than 25
            var gt25 = from num in nums // get numbers from nums to temp num
                       where num > 25 // check which is bigger than condition
                       orderby num // order by number
                       select num; // then select number
            // Cycle it...
            Console.WriteLine("Before adding 40");
            foreach (var i in gt25)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Get the type, which is Enumerable
            Console.WriteLine($"Get Type : {gt25.GetType()}");

            // Let's convert it into anything like list or array
            var listgt25 = gt25.ToList<int>();
            var arraygt25 = gt25.ToArray();

            // Linq will automatically updates the array
            nums[0] = 40;

            // Cycle it...
            foreach (var i in gt25)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //let's return array version of that...

            return arraygt25;

        }

        private static void QueryStringArray()
        {
            string[] dogs = {"K9","Brian Griffin",
            "Scooby Doo", "Old Yeller", "Rin Tin Tin",
            "Benji", "Charlie B. Barkin", "Lassie",
                "Snoopy"};
           
            // Get strings with spaces and put in 
            // Alphabetical order

            // from states where data comes from and
            // where to store each piece as you cycle

            // where defines condition conditions that must be met

            // orderby defines what data is used for
            // ordering results (ascending / descending)

            // select defines the variable that is
            // checked against the condition

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            // Now dogSpaces contains the dog which
            // has space in its name...
            // Let's cycle it...

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }


    }
}
