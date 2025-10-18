using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basics
{
    public class DataStructure
    {
        public static void Main()
        {
            //arrays 
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var array2 = new int[array.Length]; //creating dynamic array like c++ 

            //stackes
            var stack = new Stack<int>();
            
            //queue
            var queue = new Queue<int>();

            //linked list 
            var linked_list = new List<int>();

            //Binary Search tree -> self palancing red black tree
            SortedDictionary<int, string> like_json = new SortedDictionary<int, string>(); 
            
            //Parallel array act as tree
            SortedList<int, string> json = new SortedList<int, string>();

            //graph in C#
            Dictionary<int, List<string>> graph = new Dictionary<int, List<string>>();

            //hash table -> hash set in C#
            HashSet<int> hash_set = new HashSet<int>();

            //sorted set -> self palancing binary tree implementation
            SortedSet<int> ints = new SortedSet<int>();
        }
    }
}
