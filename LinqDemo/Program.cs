using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "hello", "World", "Ajay", "Atos", "anythingelse" };
            // linq query syntax
            var query = from word in words
                        where word.Length <= 5
                       // orderby word.Length
                        select word;
                         
            foreach (string w in query)
            {
                Console.Write(w.ToString() + " ");
            }
            Console.WriteLine();

            //linq lambda syntax
            var lambda = words.Where(word => word.Length <= 5);
            foreach (string w in lambda)
            {
                Console.Write(w.ToString() + " ");
            }
            Console.ReadLine();
        }
    }
}
