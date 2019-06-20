using System;
using System.Collections.Generic;
using System.Text;

namespace Hinded
{
    class Program2
    {
        public static void Main(string[] arg) {
            Hinded[] Hinneted = new Hinded[3];
            Hinneted[0] = new Hinded(5, 3, 2);
            Hinneted[1] = new Hinded(3, 5, 5);
            foreach(Hinded hinne in Hinneted){
                Console.WriteLine(hinne);
            }
            List<Hinded> hoidla = new List<Hinded>();
            hoidla.Add(Hinne[0]);
            hoidla.Add(new Hinded(3, 5, 4));
            foreach (Hinded hinne in hoidla)
            {
                Console.WriteLine(hinne);
            }
        }
    }
}
