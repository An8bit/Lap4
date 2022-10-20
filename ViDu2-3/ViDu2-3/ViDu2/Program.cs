using System;

namespace ViDu2
{
    class Program
    {
        static void TestDemSL()
        {
            IntList list = new IntList();
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            Console.WriteLine("\nSo luong node = " + list.DemSL());
        }
        static void TestTimX()
        {
            IntList list = new IntList();
            int x;
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            Console.Write("\nNhap gia tri can tim = ");
            x = int.Parse(Console.ReadLine());
            IntNode pX = list.TimX(x);
            if (pX == null)
                Console.WriteLine("Khong ton tai " + x);
            else
                Console.WriteLine("Ton tai " + x);
        }
        static void TestTimMax()
        {
            IntList list = new IntList();
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            Console.WriteLine("\nGia tri max = " + list.TimMax().Data);
        }
        static void TestXuatChan()
        {
            IntList list = new IntList();
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            Console.WriteLine("\nGia tri chan:");
            list.XuatChan();
        }
        static void TestTBLe()
        {
            IntList list = new IntList();
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            double tb = list.TBLe();
            Console.WriteLine("\nGia tri trung binh le = "+tb);
        }
        static void TestChenXSauMin()
        {
            int x;
            IntList list = new IntList();
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            Console.Write("\nNhap gia tri can chen = ");
            x = int.Parse(Console.ReadLine());
            list.ChenXSauMin(x);
            Console.WriteLine("\nDS sau khi chen {0} sau min:", x);
            list.Xuat();
        }
        static void TestChenXTruocMin()
        {
            int x;
            IntList list = new IntList();
            list.Nhap();
            Console.WriteLine("Gia tri cua danh sach:");
            list.Xuat();
            Console.Write("\nNhap gia tri can chen = ");
            x = int.Parse(Console.ReadLine());
            list.ChenXTruocMin(x);
            Console.WriteLine("\nDS sau khi chen {0} truoc min:", x);
            list.Xuat();
        }
        static void Main(string[] args)
        {
            //TestDemSL();
            //TestTimX();
            //TestTimMax();
            //TestXuatChan();
            //TestTBLe();
            //TestChenXSauMin();
            TestChenXTruocMin();
        }
    }
}
