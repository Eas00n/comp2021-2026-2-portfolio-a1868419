//Create a graph
Graph graph = new Graph();

//Create nodes
Node A = new Node("A");
Node B = new Node("B");
Node C = new Node("C");
Node D = new Node("D");
Node E = new Node("E");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I");

//Add edges between nodes
graph.AddEdge(A, B);
graph.AddEdge(A, C);

graph.AddEdge(B, D);
graph.AddEdge(B, E);

graph.AddEdge(C, F);

graph.AddEdge(D, G);
graph.AddEdge(E, H);
graph.AddEdge(F, I);

//Test the original graph
Console.WriteLine("=== Original Graph: BFS ===");
graph.BFS(A, I);

Console.WriteLine();
Console.WriteLine("=== Original Graph: DFS ===");
graph.DFS(A, I);

//Create a separate graph for the adjusted version
Graph adjustedGraph = new Graph();

Node a = new Node("A");
Node b = new Node("B");
Node c = new Node("C");
Node d = new Node("D");
Node e = new Node("E");
Node f = new Node("F");
Node g = new Node("G");
Node h = new Node("H");
Node i = new Node("I");

//Add the original edges
adjustedGraph.AddEdge(a, b);
adjustedGraph.AddEdge(a, c);
adjustedGraph.AddEdge(b, d);
adjustedGraph.AddEdge(b, e);
adjustedGraph.AddEdge(c, f);
adjustedGraph.AddEdge(d, g);
adjustedGraph.AddEdge(e, h);
adjustedGraph.AddEdge(f, i);

//Add the extra edges shown in the adjusted diagram
adjustedGraph.AddEdge(d, e);
adjustedGraph.AddEdge(e, f);
adjustedGraph.AddEdge(f, h);
adjustedGraph.AddEdge(g, h);
adjustedGraph.AddEdge(h, i);

//Test the adjusted graph
Console.WriteLine();
Console.WriteLine("=== Adjusted Graph: BFS ===");
adjustedGraph.BFS(a, i);

Console.WriteLine();
Console.WriteLine("=== Adjusted Graph: DFS ===");
adjustedGraph.DFS(a, i);