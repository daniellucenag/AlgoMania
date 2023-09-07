public class Node
{
    public Node(string value)
    {
        Next = null;
        Value = value;
    }
    public Node Next { get; set; }
    public string Value { get; set; }
}

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
        Node current = this.Head;
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


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}



