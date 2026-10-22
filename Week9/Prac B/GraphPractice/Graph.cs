using System.Collections.Generic;
using System.Text;

public class Graph
{
    public List<Node> Nodes { get; set; }
    public Graph()
    {
        Nodes = new List<Node>();
    }
    public void AddEdge(Node fromNode, Node toNode, int weight)
    {
        if (!Nodes.Contains(fromNode))
        {
            Nodes.Add(fromNode);
        }
        if (!Nodes.Contains(toNode))
        {
            Nodes.Add(toNode);
        }
        if (!fromNode.Edges.ContainsKey(toNode))
        {
            fromNode.Edges.Add(toNode, weight);
        }
        if (!toNode.Edges.ContainsKey(fromNode))
        {
            toNode.Edges.Add(fromNode, weight);
        }
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        foreach (Node node in Nodes)
        {
            result.Append(node.Data);
            result.Append(": ");
            foreach (KeyValuePair<Node, int> edge in node.Edges)
            {
                result.Append(edge.Key.Data);
                result.Append(" (");
                result.Append(edge.Value);
                result.Append("), ");
            }
            result.AppendLine();
        }
        return result.ToString();
    }
}