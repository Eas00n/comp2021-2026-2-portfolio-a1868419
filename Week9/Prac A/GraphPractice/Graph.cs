using System.Collections.Generic;
using System.Text;

public class Graph
{
    public List<Node> Nodes { get; set; }
    public Graph()
    {
        Nodes = new List<Node>();
    }
    public void AddEdge(Node fromNode, Node toNode)
    {
        if (!Nodes.Contains(fromNode))
        {
            Nodes.Add(fromNode);
        }

        if (!Nodes.Contains(toNode))
        {
            Nodes.Add(toNode);
        }

        if (!fromNode.Edges.Contains(toNode))
        {
            fromNode.Edges.Add(toNode);
        }

        if (!toNode.Edges.Contains(fromNode))
        {
            toNode.Edges.Add(fromNode);
        }
    }

//Task2
    public void BFS(Node startNode, Node targetNode)
    {
        
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        foreach (Node node in Nodes)
        {
            result.Append(node.Data);
            result.Append(": ");

            foreach (Node edge in node.Edges)
            {
                result.Append(edge.Data);
                result.Append(" ");
            }

            result.AppendLine();
        }

        return result.ToString();
    }
}