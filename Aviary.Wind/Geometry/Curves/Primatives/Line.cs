using System;

namespace Aviary.Wind.Geometry
{
    public class Line:Curve
    {
        #region members



        #endregion

        #region constructors


        public Line():base(new Point(),new Point())
        {

        }

        public Line(Point start, Point end):base(start,end)
        {

        }

        public Line(Point start, Vector direction) : base(start, (start+direction))
        {
        }

        public Line(Point start, Vector direction, double length) : base(start,(start+ direction))
        {
            direction.Length = length;
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
            get { return this.points[1]; }
            set { this.points[1] = value; }
        }

        public virtual double Length
        {
            get { return Start.DistanceTo(End); }
        }

        #endregion

        #region methods



        #endregion

    }
}
