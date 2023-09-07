namespace AlgoMania.ClassLibrary.LinkedLists
{

    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            Head = new Node("");
        }

        public void InsertNodeToHead(Node node)
        {
            if (Head.Next != null)
            {
                Node tmp = Head.Next;
                node.Next = tmp;
                Head.Next = node;
            }
            Head.Next = node;
        }


        public void InsertNodeToTail(Node node)
        {
            GetTail().Next = node;
        }

        public Node GetTail()
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        public Node GetHead()
        {
            return Head.Next;
        }

        public bool IsEmpty()
        {
            return Head.Next == null;
        }
    }
}