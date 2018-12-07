namespace Adt
{
    internal class LinkedListNode
    {
        private object data;
        private LinkedListNode next;
        private LinkedListNode prev;

        public LinkedListNode Prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }

        public LinkedListNode Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public object Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public LinkedListNode(object obj)
        {
            Data = obj;
        }
    }
}