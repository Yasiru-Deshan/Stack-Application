using System;

namespace Stack_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Stack _stack = new Stack();

            for(i=1; i<=5; i++)
            {
                _stack.Push(i);
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(_stack.Pop());
            }

            _stack.Clear();

        }
    }
}
