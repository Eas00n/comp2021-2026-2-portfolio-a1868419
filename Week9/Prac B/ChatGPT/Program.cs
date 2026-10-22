using System;
using System.Collections.Generic;

var graph = new Graph();

var start = new Node("Start");
var a = new Node("A");
var b = new Node("B (BEES)");
var c = new Node("C");
var d = new Node("D (BEES)");
var e = new Node("E (BEES)");
var f = new Node("F");
var g = new Node("G");
var h = new Node("H");
var i = new Node("I (BEES)");
var j = new Node("J (BEES)");
var k = new Node("K");
var l = new Node("L");
var m = new Node("M");
var n = new Node("N");
var end = new Node("End");

graph.AddEdge(start, a, 1);
graph.AddEdge(start, b, 5);
graph.AddEdge(start, d, 5);
graph.AddEdge(a, c, 1);
graph.AddEdge(b, e, 5);
graph.AddEdge(d, c, 5);
graph.AddEdge(d, e, 5);
graph.AddEdge(d, g, 5);
graph.AddEdge(e, h, 5);
graph.AddEdge(c, f, 1);
graph.AddEdge(g, f, 1);
graph.AddEdge(g, h, 1);
graph.AddEdge(g, j, 1);
graph.AddEdge(f, i, 5);
graph.AddEdge(h, k, 1);
graph.AddEdge(j, i, 5);
graph.AddEdge(j, k, 5);
graph.AddEdge(j, m, 5);
graph.AddEdge(i, l, 5);
graph.AddEdge(k, n, 1);
graph.AddEdge(m, l, 1);
graph.AddEdge(m, n, 1);
graph.AddEdge(l, end, 1);

(List<Node> path, int distance) = graph.FindShortestPath(start, end);

if (path.Count == 0)
{
    Console.WriteLine("No path was found from Start to End.");
}
else
{
    Console.WriteLine("Dijkstra's shortest path:");
    Console.WriteLine(string.Join(" -> ", path));
    Console.WriteLine($"Total distance: {distance}");
}
