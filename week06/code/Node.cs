public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return; // Value already exists in the tree; do nothing
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            // Check left
            if (Left is not null && Left.Contains(value))
                {
                    return true;
                }
        }
        else
        {
            // Check right
            if (Right is not null && Right.Contains(value))
                {
                    return true;
                }
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        // The scenario for an empty node is already handled in the BinarySearchTree class
        // Return 1 if no leaves
        if (Left == null && Right == null)
        {
            return 1;
        }

        // if left or right, recursively call GetHeigh, otherwise -1
        int leftHeight = Left?.GetHeight() ?? -1;
        int rightHeight = Right?.GetHeight() ?? -1;

        
        return Math.Max(leftHeight, rightHeight) + 1;

    }
}