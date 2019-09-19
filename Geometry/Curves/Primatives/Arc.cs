using System;

namespace Aviary.Wind.Geometry
{
    public class Arc : Curve
    {
        #region members

        private Plane frame = new Plane();

        #endregion

        #region constructors


        public Arc() : base(new Point(0, 1, 0), new Point(Math.Sin(Math.PI / 4), Math.Cos(Math.PI / 4), 0), new Point(1, 0, 0))
        {

        }

        public Arc(Point start, Point OnCurve, Point End) : base(start, OnCurve, End)
        {

        }

        public Arc(Plane plane, double radius, double angle) : base(plane.Origin, plane.Evaluate(new Point(0, radius, 0)), plane.Evaluate(new Point(radius * Math.Sin(angle / 2), radius * Math.Cos(angle / 2), 0)), plane.Evaluate(new Point(radius * Math.Sin(angle / 2), radius * Math.Cos(angle / 2), 0)))
        {
            this.frame = plane;
        }

        public Arc(Plane origin, double radius, double startAngle, double endAngle) : base()
        {

        }



        #endregion

        #region properties

        public virtual Point Start
        {
            get { return this.points[0]; }
            set { this.points[0] = value; }
        }

        public virtual Point End
        {
            get { return this.points[2]; }
            set { this.points[2] = value; }
        }
        
        public virtual Point Center
        {
            get { return GetCenter(Start, this.points[1], End); }
        }

        #endregion

        #region methods

        // Find a circle through the three points.
        private Point GetCenter(Point pointA, Point pointB, Point pointC)
        {
            Plane plane = new Plane(pointA, pointB, pointC);
            Point a = new Point();
            Point b = plane.ParameterAt(pointB);
            Point c = plane.ParameterAt(pointC);

            double ay = b.Y - a.Y;
            double ax = b.X - a.X;
            double by = c.Y - b.Y;

            double bx = c.X - b.X;

            double ca = ay / ax;
            double cb = by / bx;
            double x = (ca * cb * (a.Y - c.Y) + cb * (a.X + b.X) - ca * (b.X + c.X)) / (2 * (cb - ca));
            double y = -1 * (x - (a.X + b.X) / 2) / ca + (a.Y + b.Y) / 2;
            
            return plane.Evaluate(new Point(x, y, 0));
        }

        #endregion

    }
}
