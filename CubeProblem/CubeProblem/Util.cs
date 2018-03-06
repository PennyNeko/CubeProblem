using System;
using System.Collections.Generic;

namespace CubeProblem
{
    static class Util
    {
        public static void InitializeValues()
        {
            List<char> pairs = new List<char>();
            pairs.Add('A');
            pairs.Add('B');
            Program.on.Add(pairs);

            Program.onTable.Add('A');
            Program.onTable.Add('C');

            Program.free.Add('B');
            Program.free.Add('C');
        }
        
        public static void ShowStates()
        {
            Console.WriteLine("In on:");
            foreach (var chars in Program.on)
            {
                foreach (var chara in chars)
                    Console.WriteLine(chara);
            }
            Console.WriteLine("In onTable:");
            foreach (var chara in Program.onTable)
                Console.WriteLine(chara);
            Console.WriteLine("In free:");
            foreach (var chara in Program.free)
                Console.WriteLine(chara);
        }
    }
}
