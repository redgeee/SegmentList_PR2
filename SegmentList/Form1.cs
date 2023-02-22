using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SegmentList
{
    public partial class SegmentForm : Form
    {
        private LineSegmentDatabase _lineSegmentDatabase;
        public SegmentForm()
        {
            InitializeComponent();
            _lineSegmentDatabase = new LineSegmentDatabase();
            _lineSegmentDatabase.Initialize(20);

            SegmentDataGrid.DataSource = _lineSegmentDatabase.LineSegments.ToList();
        }

        private void NumberQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsistOfQuarter();
        }

        private void FullQuarter_CheckedChanged(object sender, EventArgs e)
        {
            ConsistOfQuarter();
        }

        private void ConsistOfQuarter()
        {
            List<LineSegment> _sortLineSegments = 
            _lineSegmentDatabase.LineSegments.Where(x => ConditionForSegment(x)).ToList();
            SegmentDataGrid.DataSource = (NumberQuarter.SelectedIndex != 4) ? _sortLineSegments : _lineSegmentDatabase.LineSegments.ToList();
        }

        private bool ConditionForSegment(LineSegment lineSegment)
        {
            int quarterPoint1 = lineSegment.Point1.GetQuarter();
            int quarterPoint2 = lineSegment.Point2.GetQuarter();
            int quarterSelect = NumberQuarter.SelectedIndex;

            if (FullQuarter.Checked)
                return quarterPoint1 == quarterSelect && quarterPoint2 == quarterSelect;
            else
                return quarterPoint1 == quarterSelect || quarterPoint2 == quarterSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _lineSegmentDatabase = new LineSegmentDatabase();
            _lineSegmentDatabase.Initialize(20);

            SegmentDataGrid.DataSource = _lineSegmentDatabase.LineSegments.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SegmentDataGrid.DataSource = _lineSegmentDatabase.LineSegments.ToList();
        }
    }
}
