using System.Linq;

namespace ConnectedColors
{
    public static class Recursive
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
            if (start.Processed) return 0;
            var pathLength = 1;
            start.Processed = true;
            var candidates = Utilities.GetNeighbors(start, mat)
                .Where(x => x.Color == target)
                .Where(x => !x.Processed);
            foreach (var neighbor in candidates)
            {
                pathLength += CountConnected(mat, neighbor);
            }
            return pathLength;
        }
    }
}
