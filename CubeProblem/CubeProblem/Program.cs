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
            StateChanger stateChanger = new StateChanger();
            stateChanger.MoveCube('C', 'A');
            Util.ShowStates();
            Console.ReadLine();
        }
    }
}
