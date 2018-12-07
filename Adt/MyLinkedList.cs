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
        private LinkedListNode tail;

        private LinkedListNode Tail
        {
            get
            {
                return tail;
            }
            set
            {
                tail = value;
            }
        }

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

            if (index > Count) index = Count;
            if (index <= 0) Insert(obj);

            else
            {
                LinkedListNode temp = Head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                n.Next = temp.Next;
                temp.Next = n;
                Count++;
            }
            //Min egen kode
            //switch (index)
            //{
            //    case 0:
            //        n.Next = Head;
            //        Head = n;
            //        Count++;
            //        break;
            //    default:
            //        if (index >= Count)
            //        {
            //            LinkedListNode temp = Head;
            //            for (int i = 0; i < index - 1; i++)
            //            {
            //                temp = temp.Next;
            //            }
            //            temp.Next = n;
            //            Count++;
            //        }
            //        else
            //        {
            //            LinkedListNode temp = Head;
            //            for (int i = 0; i < index - 1; i++)
            //            {
            //                temp = temp.Next;
            //            }
            //            n = temp.Next;
            //            temp.Next = n;
            //            Count++;
            //        }
            //        break;
            //}
        }
        public void Insert(object obj)
        {
            Insert(obj, Count);
        }
        public void Delete(int index)
        {
            if (index > Count) index = Count;
            if (index <= 0) Delete();

            else
            {
                LinkedListNode temp = Head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                temp.Next = temp.Next.Next;
                Count--;
            }

            //Min Egen kode
            //switch (index)
            //{
            //    case 0:
            //        LinkedListNode tempe = Head;
            //        Head = Head.Next;
            //        tempe.Next = null;
            //        Count--;
            //        break;
            //    default:
            //        if (index >= Count)
            //        {
            //            LinkedListNode temp = Head;
            //            for (int i = 0; i < index - 2; i++)
            //            {
            //                temp = temp.Next;
            //            }
            //            temp.Next = null;
            //            Count--;
            //        }
            //        else
            //        {
            //            LinkedListNode temp = Head;
            //            for (int i = 0; i < index - 1; i++)
            //            {
            //                temp = temp.Next;
            //            }
            //            LinkedListNode temp2 = temp.Next;
            //            temp.Next = temp2.Next;
            //            temp2.Next = null;
            //            Count--;
            //        }
            //        break;
            //}

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

        public void Revers()
        {
            //MyLinkedList nylist = new MyLinkedList();
            //LinkedListNode prev = list.Tail;

            //for (int i = 0; i < Count; i++)
            //{
            //    prev = prev.Prev;
            //    nylist.Insert(prev, i);
            //}
            //list = nylist;

            LinkedListNode nyHead;
            LinkedListNode nyTail;

            nyHead = Head;
            nyTail = Head;

            for (int i = 0; i < Count; i++)
            {

            }
        }

        public void Swap(int index)
        {
            if (index >= Count)
            {
                Console.WriteLine("Ingen at swappe med");
            }
            else
            {
                LinkedListNode temp = Head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                LinkedListNode temp2 = temp.Next;
                
            }

        }

        public string FremTilbage()
        {
            return "hej";
        }
    }
}
