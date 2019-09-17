using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList MyList;
            MyList = new System.Collections.ArrayList();

            MyList.Add("aaa");
            MyList.Add("Hello");
            MyList.Add("bbbb");
            MyList.Add("Kalle Anka");
            MyList.Add("cc");
            MyList.Add("Arne Anka");

            Console.WriteLine("Det finns {0} värden i listan", MyList.Count);
            PrintArrayListValues(MyList);

            Console.WriteLine("===REVERSE ORDER===");
            MyList.Reverse();
            PrintArrayListValues(MyList);

            Console.WriteLine("===SORTING===");
            MyList.Sort();
            PrintArrayListValues(MyList);

        }

        //DRY - Dont Repeat Yourself
        //Vi extraherar kod till en metod istället
        //så vi kan anropa och återanvända koden
        private static void PrintArrayListValues(System.Collections.ArrayList MyList)
        {
            foreach (string s in MyList)
            {
                Console.WriteLine("[{2}] Value: {0} ({1})", s,
                                                            s.Length,
                                                            MyList.IndexOf(s));
            }
        }
    }
}
