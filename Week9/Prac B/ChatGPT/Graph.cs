using System;
using System.Collections.Generic;

public sealed class Graph
{
    private readonly List<Node> _nodes = new();

    public IReadOnlyList<Node> Nodes => _nodes;

    public void AddEdge(Node first, Node second, int weight)
    {
        if (weight < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(weight), "Dijkstra's algorithm requires non-negative edge weights.");
        }

        if (!_nodes.Contains(first))
        {
            _nodes.Add(first);
        }

        if (!_nodes.Contains(second))
        {
            _nodes.Add(second);
        }

        first.Neighbours[second] = weight;
        second.Neighbours[first] = weight;
    }

    public (List<Node> Path, int Distance) FindShortestPath(Node start, Node target)
    {
        var distances = new Dictionary<Node, int>();
        var previous = new Dictionary<Node, Node?>();
        var queue = new PriorityQueue<Node, int>();

        foreach (Node node in _nodes)
        {
            distances[node] = int.MaxValue;
        }

        if (!_nodes.Contains(start) || !_nodes.Contains(target))
        {
            return (new List<Node>(), int.MaxValue);
        }

        distances[start] = 0;
        previous[start] = null;
        queue.Enqueue(start, 0);

        while (queue.Count > 0)
        {
            queue.TryDequeue(out Node? current, out int currentPriority);

            if (current is null)
            {
                continue;
            }

            if (currentPriority != distances[current])
            {
                continue;
            }

            if (current == target)
            {
                break;
            }

            foreach (KeyValuePair<Node, int> edge in current.Neighbours)
            {
                int candidateDistance = distances[current] + edge.Value;

                if (candidateDistance >= distances[edge.Key])
                {
                    continue;
                }

                distances[edge.Key] = candidateDistance;
                previous[edge.Key] = current;
                queue.Enqueue(edge.Key, candidateDistance);
            }
        }

        if (distances[target] == int.MaxValue)
        {
            return (new List<Node>(), int.MaxValue);
        }

        var path = new List<Node>();
        Node? step = target;

        while (step is not null)
        {
            path.Add(step);
            previous.TryGetValue(step, out step);
        }

        path.Reverse();
        return (path, distances[target]);
    }
}
