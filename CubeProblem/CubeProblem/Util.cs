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
        public static bool isFree(char cube)
        {
            return Program.free.Contains(cube);
        }

        private static void RemoveCube(char cube)
        {
            if (isFree(cube))
            {
                foreach (List<char> chars in Program.on)
                {
                    if (chars.Contains(cube))
                        chars.Remove(cube);
                    if (chars.Count == 1)
                    {
                        Program.free.Add(chars[0]);
                        chars.Clear();
                    }
                }
                Program.onTable.Remove(cube);
            }
        }

        public static void MoveCube(char cube, char destination)
        {
            if (isFree(cube))
                RemoveCube(cube);

            bool wasPlaced = false;
            if (destination.Equals(null))
            {
                wasPlaced = true;
                Program.onTable.Add(cube);
            }
            else
            if (isFree(destination))
            {
                foreach (List<char> chars in Program.on)
                {
                    if (chars.Contains(destination))
                    {
                        wasPlaced = true;
                        chars.Add(cube);
                    }
                }
                if (!wasPlaced && isFree(destination))
                {
                    wasPlaced = true;
                    List<char> pair = new List<char>();
                    pair.Add(destination);
                    pair.Add(cube);
                    Program.on.Add(pair);
                }
                if (wasPlaced)
                {
                    Program.free.Remove(destination);
                }
                else { Console.WriteLine("Could not be placed"); }
            }
            else
            {
                Console.WriteLine("Could not be picked up");
            }
        }

        public static void MoveCube(char cube)
        {
            if (isFree(cube))
                RemoveCube(cube);

            //Place
            Program.onTable.Add(cube);
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
