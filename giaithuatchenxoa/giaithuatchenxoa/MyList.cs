using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaithuatchenxoa
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        public IntNode Frist
        {
            get => first;
            set => first = value;
        }
        public IntNode Last
        {
            get => last;
            set => last = value;
        }
        public MyList()
        {
            first = null;
            last = null;
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");

        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }

            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        

        public bool RemoveFirst()
            {
                if (IsEmpty())
                    return false;
                IntNode del = first;
                first = first.Next;
                del = null;
                return true;
            }

        
        public void InsertX()
        {

        }
    }
    }



