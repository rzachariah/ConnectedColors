namespace ConnectedColors
{
    public static class Examples
    {
        public static Color[,] TechLeadExample()
        {
            const int M = 3;
            const int N = 4;
            var mat = new Color[M, N];

            mat[0, 0] = Color.Green;
            mat[1, 0] = Color.Green;
            mat[0, 1] = Color.Green;

            mat[2, 0] = Color.Red;
            mat[1, 2] = Color.Red;
            mat[0, 3] = Color.Red;

            // everything else is black

            return mat;
        }

        public static Color[,] AnotherExampleWithMaxOf5()
        {
            const int M = 3;
            const int N = 4;
            var mat = new Color[M, N];
            for (var i = 0; i < M; i++)
            {
                mat[i, 0] = Color.Red;
            }
            for (var j = 1; j < N; j++)
            {
                mat[2, j] = Color.Blue;
            }
            mat[1, 1] = Color.Blue;
            mat[1, 3] = Color.Blue;
            return mat;
        }
    }
}
