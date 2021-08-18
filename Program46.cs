using System;
using System.Collections;
namespace ConApp01
{
    class Program46
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            items.Add(100);
            items.Add(20);
            items.Add(80);
            items.Add(60);
            items.Add(30);

            items.Sort();
            items.Reverse();

            for (int i = 0; i < items.Count; i++)
                Console.WriteLine(items[i]);
        }
    }
}
