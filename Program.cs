using System;

namespace Hinded
{
    class Program
    {
        static void Main(string[] args)
        {
            Hinded hinne1 = new Hinded(5, 3, 4);
            Hinded hinne2 = new Hinded(3, 3, 4);
            Console.WriteLine(hinne2.Keskmine());
            Console.WriteLine(hinne2);
        }
    }
}
