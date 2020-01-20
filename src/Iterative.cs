using System.Collections.Generic;
using System.Linq;

namespace ConnectedColors
{
    public static class Iterative
    {
        public static int FindMaxConnectedColors(Color[,] mat)
        {
            var nodeGrid = Utilities.ToNodeGrid(mat);
            return FindMaxConnectedColors(nodeGrid);
        }

        public static int FindMaxConnectedColors(Node[,] mat)
        {
            var longest = 0;
            var M = mat.GetLength(0);
            var N = mat.GetLength(1);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    var currentNode = mat[i, j];
                    var currentLength = CountConnected(mat, currentNode);
                    if (currentLength > longest) longest = currentLength;
                }
            }
            return longest;
        }

        public static int CountConnected(Node[,] mat, Node start)
        {
            var target = start.Color;
            var count = 0;
            var queue = new Queue<Node>();
            queue.Enqueue(start);
            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current.Processed) continue;
                var validNeighbors = Utilities.GetNeighbors(current, mat)
                    .Where(x => x.Color == target)
                    .Where(x => !x.Processed);
                foreach (var neighbor in validNeighbors)
                {
                    queue.Enqueue(neighbor);
                }
                count += 1;
                current.Processed = true;
            }
            return count;
        }
    }
}
