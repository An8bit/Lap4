using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaithuatchenxoa
{
    internal class IntNode
    {
        private int data;
        private IntNode next    ;
        public int Data
        {
            get => data;
            set => data = value;
        }
        public IntNode Next
        {
            get => next;   
            set => next = value;
        }
        public IntNode (int x)
        {
            data = x;
            next = null;
        }
        
    }
}
