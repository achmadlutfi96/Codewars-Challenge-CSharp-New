using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }

    public static Node Push(Node head, int data)
    {
        // throw new NotImplementedException();
        Node res = new Node(data);
        res.Next = head;
        return res;

    }

    public static Node BuildOneTwoThree()
    {
        // throw new NotImplementedException();
        Node chained = null;
        chained = Node.Push(chained, 3);
        chained = Node.Push(chained, 2);
        chained = Node.Push(chained, 1);
        return chained;
    }
}