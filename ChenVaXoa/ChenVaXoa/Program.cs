using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChenVaXoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test1();
            test2();
           
        }
        static void test1()
        {
            IntArray n = new IntArray();
            n.Nhap();
            n.Xuat();
            n.Xoa();
            n.Xuat();
        }
        static void test2()
        {
            IntArray n = new IntArray();
            n.Nhap();
            n.Xuat();
            n.chen();
            n.Xuat();
        }
    }
}
