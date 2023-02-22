namespace SegmentList
{
    internal class Point
    {
        public Point(double coordX, double coordY)
        {
            this.coordX = coordX;
            this.coordY = coordY;
        }

        protected double coordX;
        protected double coordY;

        public double CoordX { get { return coordX; } set { coordX = value; } }
        public double CoordY { get { return coordY; } set { coordY = value; } }

        public void SetPoint(double coordX, double coordY)
        {
            this.coordX = coordX;
            this.coordY = coordY;
        }

        public int GetQuarter()
        {
            if (coordX >= 0)
                if (coordY >= 0)
                    return 0;
                else
                    return 3;
            else if (coordX < 0)
                if (coordY >= 0)
                    return 1;
                else
                    return 2;
            else
                return -1;
        }

        public override string ToString() => GetCoord();
        public string GetCoord() => $"({coordX}, {coordY})";
    }
}
