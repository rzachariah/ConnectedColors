namespace ConnectedColors
{
    public class Node
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public Color Color { get; set; }
        public bool Processed { get; set; }

        public static Node Create(int i, int j, Color color)
        {
            return new Node { Row = i, Col = j, Color = color, Processed = false };
        }
    }

    public enum Color
    {
        Black,
        Red,
        Green,
        Blue
    }
}
