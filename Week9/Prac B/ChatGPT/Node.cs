using System.Collections.Generic;

public sealed class Node
{
    public string Name { get; }
    public Dictionary<Node, int> Neighbours { get; } = new();

    public Node(string name)
    {
        Name = name;
    }

    public override string ToString() => Name;
}
