using System;
namespace ViDu2
{
    public class IntNode
    {
        int data;
        IntNode next;
        public IntNode(int x=0)
        {
            data = x;
            next = null;
        }

        public IntNode Next { get => next; set => next = value; }
        public int Data { get => data; set => data = value; }
    }
}
