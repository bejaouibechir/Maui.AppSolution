using System.Collections.Generic;
namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> ints = new Stack<int>();
            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);
            ints.Push(5);
            ints.Push(6);
            ints.Push(7);
            ints.Push(8);
            ints.Push(9);
            ints.Push(10);

            int valeur = ints.Pop();


        }
    }
}
