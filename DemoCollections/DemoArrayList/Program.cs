using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jag vill mata in värden som sparas i en ArrayList
            //så jag kan använda metoderna
            System.Collections.ArrayList UserInputList = new System.Collections.ArrayList();

            //jag vill skriva in ord och trycka enter
            //så länge jag trycker ord och enter, fortsätt
            //avsluta när jag skriver in EXIT

            string key = "";

            do
            {
                key = Console.ReadLine();
                if (key != "EXIT")
                {
                    UserInputList.Add(key);
                }

            } while (key != "EXIT");

            Console.WriteLine("Tack, du matade in {0} ord", UserInputList.Count);

            foreach (string s in UserInputList)
            {
                Console.WriteLine("[{0}] {1}", UserInputList.IndexOf(s), s);
            }

        }
    }
}
