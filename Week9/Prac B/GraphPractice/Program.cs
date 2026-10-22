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
graph.AddNode(Start, A, 1);
graph.AddNode(Start, B, 5);
graph.AddNode(Start, D, 5);
graph.AddNode(A, C, 1);
graph.AddNode(B, E, 5);
graph.AddNode(D, C, 5);
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