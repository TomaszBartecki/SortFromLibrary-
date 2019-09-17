using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFromLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 4, 3, 2, 1, -1, 0};
            numbers.Sort(); 
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
