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
        //Store the nodes that have been checked
        List<Node> Checked = new List<Node>();
        //Store the nodes waiting to be visited
        Queue<Node> Queued = new Queue<Node>();
        //Store the parent of each discovered node and remember the path to the target node
        Dictionary<Node, Node> Parents = new Dictionary<Node, Node>();
        List<Node> Discovered = new List<Node>();
        //Add the starting node to the queue.
        Queued.Enqueue(startNode);
        Discovered.Add(startNode);

        Node Current = startNode;
        bool found = false;
        //Continue while there are nodes to visit
        while (Queued.Count > 0)
        {
            Current = Queued.Dequeue();
            if (Current == targetNode)
            {
                found = true;
                break;
            }
            Checked.Add(Current);   
            foreach (Node edge in Current.Edges)
            {
                if (Discovered.Contains(edge))
                {
                    continue;
                }

                Queued.Enqueue(edge);
                Discovered.Add(edge);
                Parents.Add(edge, Current);
            }
        }
        //Print the checked nodes
        Console.WriteLine("Checked nodes:");

        foreach (Node node in Checked)
        {
            Console.Write(node.Data + " ");
        }

        Console.WriteLine();
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