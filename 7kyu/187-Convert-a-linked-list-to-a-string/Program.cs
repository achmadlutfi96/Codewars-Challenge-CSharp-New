public class Kata
{
  public static string Stringify(Node list)
  {
    // Write your code here
    string str = "";
    Node temp = list;
    while(temp != null){
        str += $"{temp.Data} -> ";
        temp = temp.Next;
    }

    return str + "null";

    // Alternative 
    // return list == null ? "null" : list.Data + " -> " + Stringify(list.Next);
  }

  public static void Main(){
    Console.WriteLine(Stringify(new Node(1, new Node(2, new Node(3)))));
  }
}

public class Node {
  public int Data { get; private set; }
  public Node Next { get; private set; }

  public Node(int data, Node next = null) {
    Data = data;
    Next = next;
  }
}