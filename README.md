# Коллекции

Задача. Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.

Решение:
> Program.cs
```
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

```
