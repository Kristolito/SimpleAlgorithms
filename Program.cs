using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 });


            //call the functions with the appropriate parameters to test the functions

            // Console.WriteLine(AlgoA1("test"));

            //Console.WriteLine(AlgoA2(mylist));


            //Console.WriteLine(AlgoA3("python"));
        }      






        public static string AlgoA1(string input)
        {

            //Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.If the given string length is less than 2 return the original string.

            if (input.Trim().Length > 2)
            {
                return input.Substring(0, 2) + input.Substring(0, 2) + input.Substring(0, 2) + input.Substring(0, 2);
            }
            else
            {
                return input;
            }
        }


        public static List<int> AlgoA2(List<int> nums)
        {
            //Write a C# Sharp program to create a new list from a given list of integers removing those values which are less than 4
            List<int> mylist =new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 });
           
            return mylist.Where(n => n < 4).ToList();
        }


        public static string AlgoA3(string s1)
        {
            // Write a C# Sharp program to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y"
            if (s1.Length >= 2)
            {
                if (String.Compare(s1.Substring(1, 1), "y") != 0)
                {
                    s1 = s1.Remove(1, 1);
                }

                if (String.Compare(s1.Substring(0, 1), "p") != 0)
                {
                    s1 = s1.Remove(0, 1);
                }
            }
            else if (s1.Length > 0 && String.Compare(s1.Substring(0, 1), "p") != 0)
            {
                s1 = s1.Remove(0, 1);
            }

            return s1;
        }
    }

}

  
}
