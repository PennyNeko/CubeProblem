using System;
using System.Collections.Generic;

namespace CubeProblem
{

    class Program
    {
        public static List<List<char>> on = new List<List<char>>();
        public static List<char> onTable = new List<char>();
        public static List<char> free = new List<char>();
        static void Main(string[] args)
        {
            Util.InitializeValues();
            Util.ShowStates();
            Util.MoveCube('B', 'C');
            Util.ShowStates();
            Console.ReadLine();
        }
    }
}
