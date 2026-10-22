using System.Collections.Generic;
using System.Text;

public class Graph
{
    public List<Node> Nodes { get; set; }
    public Graph()
    {
        Nodes = new List<Node>();
    }
    public void AddNode(Node fromNode, Node toNode, int weight)
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
}