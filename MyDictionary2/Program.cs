using System;
using System.Collections.Generic;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();
            sehirler1.Add("Kastamonu");
            Console.WriteLine(sehirler1.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            sehirler2.Add("Bayburt");
            Console.WriteLine(sehirler2.Count);

        }
    }
}
