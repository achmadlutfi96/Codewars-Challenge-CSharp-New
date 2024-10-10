using System;

public partial class Node
{
  public int Data;
  public Node Next;
  
  public Node(int data)
  {
    this.Data = data;
    this.Next = null;
  }
  
  public static Node GetNth(Node node, int index)
  {
    // throw new NotImplementedException();
    return node == null ? throw new ArgumentException() : index == 0 ? node : GetNth(node.Next, index - 1);
  }
}