using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Week6Assignment
{
    class Program
    {


        static void Main(string[] args)
        {
            Problem1();
            Problem2();
        }



        static void Problem1()
        {

            List<string> friend1 = new List<string>();
            string friend2 = "";


            bool stop = false;


            Console.WriteLine("Enter a name: ");
            Console.WriteLine("To continue press enter without entering a name. ");

            while (stop == false)
            {
                friend2 = Console.ReadLine();
                if (string.IsNullOrEmpty(friend2))
                {
                    stop = true;
                }
                else
                {
                    friend1.Add(friend2);
                }
            }


            if (friend1.Count == 0)
            {

            }
            else if (friend1.Count == 1)
            {
                Console.WriteLine(friend1[0] + " likes your post.");
            }
            else if (friend1.Count == 2)
            {
                Console.WriteLine(friend1[0] + " and " + friend1[1] + " likes your post.");
            }
            else if (friend1.Count > 2)
            {
                Console.WriteLine(friend1[0] + ", " + friend1[1] + " and " + (friend1.Count - 2) + " others like your post.");
            }
            else
            {
                Console.WriteLine("Something went wrong, try again.");
            }

        }


        static void Problem2()
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            string L1 = "";


            Console.WriteLine("Enter a sentance");


            L1 = Console.ReadLine();


            foreach (char Ex in L1)
            {
                if (Ex == ' ')
                {

                }
                else if (count.ContainsKey(Char.ToLower(Ex)))
                {
                    count[Char.ToLower(Ex)] += 1;
                }
                else
                {
                    count.Add(Char.ToLower(Ex), 1);
                }
            }


            foreach (KeyValuePair<char, int> Cp in count)
            {
                Console.WriteLine(Cp.Key + " | " + Cp.Value);
            }


        }
    }
}