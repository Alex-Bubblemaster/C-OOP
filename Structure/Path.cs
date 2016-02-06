namespace Structure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    //Create a class Path to hold a sequence of points in the 3D space.
    public class Path : IEnumerable<Point3D>
    {
        private List<Point3D> points;
              
        public List<Point3D> Points
        {
            get { return points; }
            set { points = value; }
        }
        public Path()
        {
            this.points = new List<Point3D>();
        }
        public void AddPoint(Point3D point)
        {
            points.Add(point);
         }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var point in points)
            {
                builder.AppendFormat("{0} ", point.ToString());
            }
            return builder.ToString();
        }


        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var point in this.Points)
            {
                yield return point;
            }
        }
    }
}
