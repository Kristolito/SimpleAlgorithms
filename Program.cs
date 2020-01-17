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
            int[] item = new[] { 1, 5, 7 };

            int[] item2 = new[] { 1, 5, 7, 9, 10, 12 };


            //call the functions with the appropriate parameters to test the functions

            // Console.WriteLine(AlgoA1("test"));

            //Console.WriteLine(AlgoA2(mylist));


            //Console.WriteLine(AlgoA3("python"));

            //Console.WriteLine(AlgoA4(item));

            //Console.WriteLine(AlgoA5(item2));
        }






        public static string AlgoA1(string input)
        {

            //Write a C# Sharp function to create a new string which is 4 copies of the 2 front characters of a given string.If the given string length is less than 2 return the original string.

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
            //Write a C# Sharp function to create a new list from a given list of integers removing those values which are less than 4
            List<int> mylist =new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 });
           
            return mylist.Where(n => n < 4).ToList();
        }


        public static string AlgoA3(string s1)
        {
            // Write a C# Sharp function to create a new string from a given string without the first two characters. Keep the first character if it is "p" and keep the second character if it is "y"
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


        public static int[] AlgoA4(int[] numbers)
        {
            // Write a C# Sharp function to check a given array of integers, length 3 and create a new array. If there is a 5 in the given array immediately followed by a 7 then set 7 to 1
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && numbers[i + 1].Equals(7))
                    numbers[i + 1] = 1;
            }
            return numbers;
        }




       public static int AlgoA5(int[] nums)
        {
            // Write a C# Sharp function to check the dif between the largest and smallest values in a list of integers
            int small_num = 0, biggest_num = 0;

            if (nums.Length > 0) small_num = biggest_num = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                small_num = Math.Min(small_num, nums[i]);
                biggest_num = Math.Max(biggest_num, nums[i]);
            }

            return biggest_num - small_num;
        }


    }
}



  

