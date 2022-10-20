using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaithuatchenxoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestInput();
           

        }
        static void TestInput()
        {
            MyList list = new MyList();
            list.Input();
            Console.WriteLine("DSLK so nguyen:");
            list.ShowList();
            list.RemoveFirst();
            list.ShowList();
        }
    }
}
