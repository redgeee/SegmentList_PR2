using System;
using System.Collections.Generic;

namespace SegmentList
{
    internal class LineSegmentDatabase
    {
        private Random _random = new Random();
        private int RandomInt
        {
            get => _random.Next(-50, 50);
        }

        internal List<LineSegment> LineSegments { get; private set; }

        public void Initialize(int CountLineSegments)
        {
            LineSegments = new List<LineSegment>();
            for (int i = 0; i < CountLineSegments; i++)
            {
                Point point1 = new Point(RandomInt, RandomInt);
                Point point2 = new Point(RandomInt, RandomInt);

                LineSegment lineSegment =  new LineSegment(point1, point2);

                LineSegments.Add(lineSegment);
            }
        }
    }
}
