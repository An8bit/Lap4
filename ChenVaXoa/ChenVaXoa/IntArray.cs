using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChenVaXoa
{
    internal class IntArray
    {
        public int [] a;
        public int length;

        public int Lenght
        {
            get => length;
            set => length = value;
        }

        public IntArray()
        {
            Console.WriteLine("*Nhap chieu dai mang");
            length = int.Parse(Console.ReadLine());
            a = new int[length];
        }


        public void Nhap()
        {
           
           Random r = new Random();
           for(int i = 0; i < a.Length-1 ; i++)
            {
               // a[i]=int.Parse(Console.ReadLine());
                a[i] = r.Next(1,100);
            }
            
        }
        public void Xuat()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "   ");

            }
            Console.WriteLine();
        }
       
        public void chen() 
        {
            
            Console.WriteLine("vi tri");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("phan tu");
            int x = int.Parse(Console.ReadLine());
            for (int i = a.Length-1; i > k; i--)
            {
                a[i] = a[i - 1];
            }
            a[k] = x;
        }
        public void Xoa()
        {
            Console.WriteLine("vi tri");
            int k = int.Parse(Console.ReadLine());
            for(int i = k; i < a.Length-1; i++)
            {
                a[i]=a[i + 1];
            }
            
        }
    }
}
