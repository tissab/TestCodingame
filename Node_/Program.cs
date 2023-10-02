// See https://aka.ms/new-console-template for more information


public class Node
{
    public Node left, right;

    public int value;

    public Node Find(int v)
    {
        Node c = this; 

        while (c != null)
        {
            if (v == c.value)
            {
                return c;
            }
            else if (v < c.value) c = c.left;
            else c = c.right;
            
        }
        return null;
    }
}