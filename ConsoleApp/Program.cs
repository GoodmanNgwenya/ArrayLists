using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
            Console.WriteLine("-----Common elements in both lists-----");

            //IEnumerable<int> bothList = list1.Intersect(list2);
            //foreach(int list3 in bothList)

            List<int> list3 = (from l1 in list1
                               join l2 in list2 on l1 equals l2 into t
                               from od in t.DefaultIfEmpty()
                               where od != 0
                               select od).ToList<int>();

            Console.WriteLine(string.Join(" ", list3));

            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"
            Console.WriteLine("-----Elements from list 1, but is not found in list2-----");

            List<int> list4 = (from l1 in list1
                               join l2 in list2 on l1 equals l2 into t
                               from od in t.DefaultIfEmpty()
                               where od == 0
                               select l1).ToList<int>();  
            Console.WriteLine(string.Join(" ", list4));

            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"
            Console.WriteLine("-----Elements from list 2, but is not found in list1-----");

            List<int> list5 = (from l2 in list2
                               join l1 in list1 on l2 equals l1 into t
                               from od in t.DefaultIfEmpty()
                               where od == 0
                               select l2).ToList<int>();

            Console.WriteLine(string.Join(" ", list5));
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }

    }
}
