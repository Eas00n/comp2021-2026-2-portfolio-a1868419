using System;
using System.Collections.Generic;

//Create the graph
Graph graph = new Graph();
//Create the nodes
Node Start = new Node("Start");
Node A = new Node("A");
Node B = new Node("B(BEES)");
Node C = new Node("C");
Node D = new Node("D(BEES)");
Node E = new Node("E(BEES)");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I(BEES)");
Node J = new Node("J(BEES)");
Node K = new Node("K");
Node L = new Node("L");
Node M = new Node("M");
Node N = new Node("N");
Node End = new Node("End");
//Add edges
graph.AddEdge(Start, A, 1);
graph.AddEdge(Start, B, 5);
graph.AddEdge(Start, D, 5);
graph.AddEdge(A, C, 1);
graph.AddEdge(B, E, 5);
graph.AddEdge(D, C, 5);
graph.AddEdge(D, E, 5);
graph.AddEdge(D, G, 5);

graph.AddEdge(E, H, 5);
graph.AddEdge(C, F, 1);

graph.AddEdge(G, F, 1);
graph.AddEdge(G, H, 1);
graph.AddEdge(G, J, 1);

graph.AddEdge(F, I, 5);
graph.AddEdge(H, K, 1);

graph.AddEdge(J, I, 5);
graph.AddEdge(J, K, 5);
graph.AddEdge(J, M, 5);

graph.AddEdge(I, L, 5);
graph.AddEdge(K, N, 1);

graph.AddEdge(M, L, 1);
graph.AddEdge(M, N, 1);

graph.AddEdge(L, End, 1);

//Set the Target
Node Target = End;
//Store the shortest path
Dictionary<Node, int> DistancesList = new Dictionary<Node, int>();
//Set all distances to infinity
foreach (Node node in graph.Nodes)
{
    DistancesList.Add(node, int.MaxValue);
}
//Start has a distance of 0
DistancesList[Start] = 0;
//Create the priority queue
PriorityQueue<Node, int> PriorityQueue = new PriorityQueue<Node, int>();
//Store the parents of each node
Dictionary<Node, Node?> Parents = new Dictionary<Node, Node?>();
//Start has no parent
Parents[Start] = null;
//Add Start to the priority queue
PriorityQueue.Enqueue(Start, 0);

//Run Dijkstra's algorithm
while (PriorityQueue.Count > 0)
{
    Node Current = PriorityQueue.Dequeue();
    //Stop if it reach the target
    if (Current == Target)
    {
        break;
    }
    //Check all nodes
    foreach (KeyValuePair<Node, int> neighbour in Current.Edges)
    {
        Node nextNode = neighbour.Key;
        int weight = neighbour.Value;
        //Calculate the new distance
        int newDistance = DistancesList[Current] + weight;
        //Check if the new distance is shorter
        if (newDistance >= DistancesList[nextNode])
        {
            continue;
        }
        //Update the distance
        DistancesList[nextNode] = newDistance;
        //Update the parent
        Parents[nextNode] = Current;
        //Add the next node to the priority queue
        PriorityQueue.Enqueue(nextNode, newDistance);
    }
}

//Create final path
List<string> Path = new List<string>();
Node CurrentNode = Target;
while (CurrentNode != null)
{
    Path.Add(CurrentNode.Data);
    if(CurrentNode == Start)
    {
        break;
    }
    CurrentNode = Parents[CurrentNode];
}
//Reverse the path
Path.Reverse();
//Print the path
Console.WriteLine("Shortest path from Start to Target:");
foreach (string node in Path)
{
    Console.Write(node);
    if (node != Path[Path.Count - 1])
    {
        Console.Write(" -> ");
    }
}
Console.WriteLine();
Console.WriteLine("Total distance: " + DistancesList[Target]);