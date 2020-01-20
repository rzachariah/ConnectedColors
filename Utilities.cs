using System.Collections.Generic;

namespace ConnectedColors
{
    public static class Utilities
    {
        public static IEnumerable<Node> GetNeighbors(Node node, Node[,] mat)
        {
            var neighbors = new List<Node>();
            TryAdd(-1, 0);
            TryAdd(0, 1);
            TryAdd(0, -1);
            TryAdd(1, 0);

            return neighbors;

            void TryAdd(int rowStep, int colStep)
            {
                var candidate = GetNeighbor(node, mat, rowStep, colStep);
                if (candidate != null)
                {
                    neighbors.Add(candidate);
                }
            }
        }

        public static Node GetNeighbor(Node node, Node[,] mat, int rowStep, int colStep)
        {
            var nextRow = node.Row + rowStep;
            var nextCol = node.Col + colStep;
            if (IsInBounds(mat, nextRow, nextCol))
            {
                var nextNode = mat[nextRow, nextCol];
                return nextNode;
            }
            return null;
        }

        public static bool IsInBounds(Node[,] mat, int i, int j)
        {
            if (i < 0 || j < 0) return false;

            var M = mat.GetLength(0);
            var N = mat.GetLength(1);

            if (i >= M || j >= N) return false;

            return true;
        }

        public static Node[,] ToNodeGrid(Color[,] grid)
        {
            var M = grid.GetLength(0);
            var N = grid.GetLength(1);
            var clone = new Node[M, N];
            for (var i = 0; i < M; i++)
            {
                for (var j = 0; j < N; j++)
                {
                    clone[i, j] = Node.Create(i, j, grid[i, j]);
                }
            }
            return clone;
        }
    }
}
