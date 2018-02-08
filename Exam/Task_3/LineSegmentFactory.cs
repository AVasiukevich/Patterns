using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task_3
{
    public class LineSegmentFactory
    {
        private readonly Dictionary<double[] , Line> _lines = new Dictionary<double[], Line>();

        public Line GetLine(double[] points)
        {
            if (_lines.Keys.FirstOrDefault(c => c.SequenceEqual(points)) == null)
                    _lines.Add(points, new Line() { X1 = points[0], X2 = points[1], Y1 = points[2], Y2 = points[3],
                        Stroke = Brushes.Black, StrokeThickness = 2});

            return _lines[points];
        }
    }
}
