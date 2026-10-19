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

//Test BFS on the original graph
Console.WriteLine("=== Original Graph ===");
graph.BFS(A, I);

//Add the extra edges
graph.AddEdge(G, H);
graph.AddEdge(H, I);

//Test BFS on the adjusted graph
Console.WriteLine();
Console.WriteLine("=== Adjusted Graph ===");
graph.BFS(A, I);