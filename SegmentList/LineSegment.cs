namespace SegmentList
{
    internal class LineSegment
    {
        public LineSegment(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public LineSegment(double x1, double y1, double x2, double y2)
        {
            this.point1 = new Point(x1, y1);
            this.point2 = new Point(x2, y2);
        }

        protected Point point1;
        protected Point point2;

        public virtual Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }
        public virtual Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }

        public override string ToString() =>
            "point1: " + point1.ToString() + " point2: " + point2.ToString();
    }
}


