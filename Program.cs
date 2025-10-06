using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(Check(userInput));
            Console.ReadKey();
        }

        static bool Check(string userInput)
        {
            Stack<char> userSymbols = new Stack<char>();
            Dictionary<char, char> bracket = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            foreach (char c in userInput)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    userSymbols.Push(bracket[c]);
                }

                else if (c == ')' || c == ']' || c == '}')
                {
                    if (userSymbols.Count == 0 || userSymbols.Pop() != c)
                    {
                        return false;
                    }
                }
            }

            if (userSymbols.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
