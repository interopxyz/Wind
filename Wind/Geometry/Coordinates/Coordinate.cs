using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Geometry
{
    public abstract class Coordinate
    {
        #region members

        double x = 0;
        double y = 0;
        double z = 0;

        #endregion

        #region constructors

        public Coordinate()
        {

        }

        public Coordinate(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Coordinate(Coordinate coordinate)
        {
            this.X = coordinate.X;
            this.Y = coordinate.Y;
            this.Z = coordinate.Z;
        }

        #endregion

        #region properties

        public virtual double X
        {
            get { return x; }
            set { x = value; }
        }

        public virtual double Y
        {
            get { return y; }
            set { y = value; }
        }

        public virtual double Z
        {
            get { return z; }
            set { z = value; }
        }

        #endregion

        #region methods

        public virtual double DistanceTo(Coordinate target)
        {
            return Math.Sqrt(Math.Pow(target.X - X, 2) + Math.Pow(target.Y - Y, 2) + Math.Pow(target.Z - Z, 2));
        }

        #endregion
    }
}
