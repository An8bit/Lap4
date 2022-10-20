using System;
namespace ViDu2
{
    public class IntList
    {
        IntNode first=null;
        IntNode last=null;
        public IntList()
        {
            first = last = null;
        }
        public void InsertFirst(IntNode newNode)
        {
            if (first == null)
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void InsertLast(IntNode newNode)
        {
            if (first == null)
                first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public void Nhap()
        {
            int n, x;
            Console.Write("So luong node = ");
            n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                Console.Write("Nhap gia tri = ");
                x = int.Parse(Console.ReadLine());
                IntNode newNode = new IntNode(x);
                InsertLast(newNode);
            }
        }
        public void Xuat()
        {
            for (IntNode p = first; p != null; p = p.Next)
                Console.Write("{0}->", p.Data);
        }
        public int DemSL()
        {
            int d = 0;
            for (IntNode p = first; p != null; p = p.Next)
                d++;
            return d;
        }
        public IntNode TimX(int x)
        {
            for (IntNode p = first; p != null; p = p.Next)
                if (p.Data == x)
                    return p;
            return null;
        }
        public IntNode TimMax()
        {
            IntNode pMax = first;
            for (IntNode p = first.Next; p != null; p = p.Next)
                if (p.Data > pMax.Data)
                    pMax=p;
            return pMax;
        }
        public IntNode TimMin()
        {
            IntNode pMin = first;
            for (IntNode p = first.Next; p != null; p = p.Next)
                if (p.Data < pMin.Data)
                    pMin = p;
            return pMin;
        }
        public void XuatChan()
        {
            for (IntNode p = first; p != null; p = p.Next)
                if (p.Data % 2 == 0)
                    Console.Write("{0}->", p.Data);
        }
        public double TBLe()
        {
            int s = 0, d = 0;
            for (IntNode p = first; p != null; p = p.Next)
                if(p.Data%2!=0)
                {
                    s += p.Data;
                    d++;
                }
            if (d == 0)
                return 0;
            return (double)s / d;
        }
        public void InsertAfterP(IntNode p, IntNode newNode)
        {
            if (p == last)
                InsertLast(newNode);
            else
            {
                newNode.Next = p.Next;
                p.Next = newNode;
            }
        }
        public void HoanVi(IntNode a, IntNode b)
        {
            int tam = a.Data;
            a.Data = b.Data;
            b.Data = tam;
        }
        public void InsertBeforeP(IntNode p, IntNode newNode)
        {
            InsertAfterP(p, newNode);
            HoanVi(p, newNode);
        }
        public void ChenXSauMin(int x)
        {
            IntNode p = TimMin();
            IntNode newNode = new IntNode(x);
            InsertAfterP(p, newNode);
        }
        public void ChenXTruocMin(int x)
        {
            IntNode p = TimMin();
            IntNode newNode = new IntNode(x);
            InsertBeforeP(p, newNode);
        }
    }
}
