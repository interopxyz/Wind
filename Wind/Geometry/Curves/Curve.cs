using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Geometry.Curves
{
    public abstract class Curve
    {
        #region members

        public enum CurveTypes { None = 0, Line = 1, Circle = 2, Ellipse = 3, Arc = 4, };
        CurveTypes type = CurveTypes.None;

        protected List<Point> points = new List<Point>();

        #endregion

        #region constructors

        public Curve()
        {

        }

        public Curve(List<Point> points)
        {
            this.points = points;
        }

        public Curve(params Point[] points)
        {
            this.points = points.ToList();
        }

        #endregion

        #region properties

        public virtual CurveTypes CurveType
        {
            get { return type; }
        }

        #endregion

        #region methods



        #endregion
    }
}
