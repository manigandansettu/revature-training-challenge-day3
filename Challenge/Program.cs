using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        // Challenge 1: Write methods in the class Giraffe
        //  to override base class Animal's behavior.
        //  Find Animal in Animal.cs
        public class Giraffe : Animal
        {

        }

        // Challenge 2: Modify the following method toattempt to
        //  downcast the given Animal to a Giraffe and provide suitable 
        //  behavior.I.e. return "This is a giraffe." only if it is 
        //  a giraffe.
        public static string Downcast(Animal a)
        {
            throw new NotImplementedException();
        }

        // Challenge 3: Take a collection of type object and cast them
        //  to Animals. Populate a new collection of type Animal
        //  and return it.
        public static List<Animal> ConvertObjects(IEnumerable<object> objectCollection)
        {
            throw new NotImplementedException();
        }
        
        // Do not modify main!
        static void Main(string[] args)
        {
            Console.WriteLine("Testing...");
            int testsPassed = 0, totalTests = 3;
            
            Animal a = new Animal();
            Giraffe g = new Giraffe();

            // Test for Challenge 1
            if ( !a.ToString().Equals(g.ToString()) && !a.Move().Equals(g.Move()) )
                ++testsPassed;
            else Console.WriteLine("Challenge 1 failed!");

            // Test for Challenge 2
            try 
            {
                string generic = Downcast(a), nongeneric = Downcast(g);
                if (generic != nongeneric)
                    ++testsPassed;
                else Console.WriteLine("Challenge 2 failed! Outputs are the same.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Challenge 2 failed with exception: " + e.Message);
            }
            
            // Test for Challenge 3
            List<object> myList = new List<object>();
            for (int i = 0; i < 10; ++i)
                myList.Add(new Animal());
            
            try
            {
                List<Animal> newList = ConvertObjects(myList);

                bool good = true;
                for (int i = 0; i < newList.Count; ++i)
                    if (!newList[i].ToString().Equals(a.ToString()))
                        good = false;

                if (good)
                    ++testsPassed;
                else
                    Console.WriteLine("Challenge 3 failed!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Challenge 3 failed with exception: " + e.Message);
            }

            // Final output
            Console.WriteLine(testsPassed + " out of " + totalTests + " passed.");

            if (testsPassed == totalTests)
                Console.WriteLine("Challenge complete!");
        }
    }
}
