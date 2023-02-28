using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SegmentList
{
    public partial class SegmentForm : Form
    {
        private int _countLine = 50;

        private LineSegmentDatabase _lineSegmentDatabase;
        public SegmentForm()
        {
            InitializeComponent();
            _lineSegmentDatabase = new LineSegmentDatabase();
            _lineSegmentDatabase.Initialize(_countLine);

            SegmentDataGrid.DataSource = _lineSegmentDatabase.LineSegments.ToList();
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

            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SegmentDataGrid.DataSource = _lineSegmentDatabase.LineSegments.ToList();
            sortComboBox.Text = "Сортировка";
            followComboBox.Text = "Направление";
            NumberQuarter.Text = "Четверть";
            FullQuarter.Checked = false;
            numberSearch.Text = "Number";
            operationSearch.Text = "Func";
            letterSearch.Text = "Letter";
        }

        private void sortTable()
        {
            List<LineSegment> _sortLineSegments;
            switch (followComboBox.SelectedIndex)
            {
                case 0:
                    _sortLineSegments = _lineSegmentDatabase.LineSegments.OrderBy(x => getNumber(sortComboBox.SelectedIndex, x)).ToList();
                    break;
                case 1:
                    _sortLineSegments = _lineSegmentDatabase.LineSegments.OrderByDescending(x => getNumber(sortComboBox.SelectedIndex, x)).ToList();
                    break;
                default:
                    _sortLineSegments = null;
                    break;
            }
            SegmentDataGrid.DataSource = (sortComboBox.SelectedIndex != -1) ? _sortLineSegments : _lineSegmentDatabase.LineSegments.ToList();
        }

        private double getNumber(int index, LineSegment lineSegment)
        {
            switch (index)
            {
                case 0: 
                    return lineSegment.Point1.CoordX;
                case 1:
                    return lineSegment.Point1.CoordY;
                case 2:
                    return lineSegment.Point2.CoordX;
                case 3: 
                    return lineSegment.Point2.CoordY;
                default:
                    return -1;
            }
        }



        private void searchNumber()
        {
            List<LineSegment> _sortLineSegments;
            getFunc fun = getFunction();
            double _numberSearch;
            try
            {
                _numberSearch = double.Parse(numberSearch.Text);
            }
            catch
            {
                return;
            } 
            
            switch (letterSearch.SelectedIndex)
            {
                case 0:
                    _sortLineSegments = _lineSegmentDatabase.LineSegments.Where(x => 
                        fun(x.Point1.CoordX, _numberSearch) &&
                        fun(x.Point2.CoordX, _numberSearch)).ToList();
                    break;
                case 1:
                    _sortLineSegments = _lineSegmentDatabase.LineSegments.Where(x =>
                        fun(x.Point1.CoordY, _numberSearch) &&
                        fun(x.Point2.CoordY, _numberSearch)).ToList();
                    break;
                case 2:
                    _sortLineSegments = _lineSegmentDatabase.LineSegments.Where(x =>
                        fun(x.Point1.CoordX, _numberSearch) &&
                        fun(x.Point2.CoordX, _numberSearch) &&
                        fun(x.Point1.CoordY, _numberSearch) &&
                        fun(x.Point2.CoordY, _numberSearch)).ToList();
                    break;
                default:
                    _sortLineSegments = _lineSegmentDatabase.LineSegments.ToList();
                    break;

            }
            SegmentDataGrid.DataSource = _sortLineSegments;
        }
        delegate bool getFunc(double n, double m);

        private getFunc getFunction()
        {
            switch (operationSearch.SelectedIndex)
            {
                case 0:
                    return (double n, double m) => n > m;
                case 1:
                    return (double n, double m) => n >= m;
                case 2:
                    return (double n, double m) => n == m;
                case 3:
                    return (double n, double m) => n <= m;
                case 4:
                    return (double n, double m) => n < m;
                default:
                    return (double n, double m) => true;
            }
        }







        private void NumberQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsistOfQuarter();
        }

        private void FullQuarter_CheckedChanged(object sender, EventArgs e)
        {
            ConsistOfQuarter();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortTable();
        }

        private void followComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortTable();
        }

        private void letterSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchNumber();
        }

        private void operationSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchNumber();
        }

        private void numberSearch_TextChanged(object sender, EventArgs e)
        {
            searchNumber();
        }
    }
}
