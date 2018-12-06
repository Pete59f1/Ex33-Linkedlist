using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
    public class MyLinkedList
    {
        private int count;
        private LinkedListNode head;

        private LinkedListNode Head
        {
            get
            {
                return head;
            }
            set
            {
                head = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public void Insert(object obj, int index)
        {
            LinkedListNode n = new LinkedListNode(obj);

            switch (index)
            {
                case 0:
                    n.Next = Head;
                    Head = n;
                    Count++;
                    break;
                default:
                    if (index >= Count)
                    {
                        LinkedListNode temp = Head;
                        for (int i = 0; i < index; i++)
                        {
                            temp = temp.Next;
                        }
                        temp.Next = n;
                        Count++;
                    }
                    else
                    {
                        LinkedListNode temp = Head;
                        for (int i = 0; i < index - 1; i++)
                        {
                            temp = temp.Next;
                        }
                        n = temp.Next;
                        temp.Next = n;
                        Count++;
                    }
                    break;
            }
        }
        public void Insert(object obj)
        {
            Insert(obj, 0);
        }
        public void Delete(int index)
        {
            switch (index)
            {
                case 0:
                    LinkedListNode tempe = Head;
                    Head = Head.Next;
                    tempe.Next = null;
                    Count--;
                    break;
                default:
                    if (index >= Count)
                    {
                        LinkedListNode temp = Head;
                        for (int i = 0; i < index - 2; i++)
                        {
                            temp = temp.Next;
                        }
                        temp.Next = null;
                        Count--;
                    }
                    else
                    {
                        LinkedListNode temp = Head;
                        for (int i = 0; i < index - 1; i++)
                        {
                            temp = temp.Next;
                        }
                        LinkedListNode temp2 = temp.Next;
                        temp.Next = temp2.Next;
                        temp2.Next = null;
                        Count--;
                    }
                    break;
            }

        }
        public void Delete()
        {
            Delete(0);
        }
        public object ItemAt(int index)
        {
            LinkedListNode n = Head;
            for (int i = 0; i < index; i++)
            {
                n = n.Next;
            }
            return n.Data;
        }
        public override string ToString()
        {
            string ret = "";

            for (int i = 0; i < Count; i++)
            {
                ret += ItemAt(i).ToString() + "\n";
            }
            return ret;
        }
    }
}
