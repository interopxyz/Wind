using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Geometry
{
    public class Point:Coordinate
    {
        #region members



        #endregion

        #region constructors

        public Point()
        {

        }

        public Point(double x, double y, double z = 0):base(x,y,z)
        {

        }

        public Point(Coordinate coordinate) : base(coordinate)
        {

        }

        #endregion

        #region properties

        #endregion

        #region methods

        public static Point operator -(Point A, Coordinate B)
        {
            return new Point(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        public static Point operator +(Point A, Coordinate B)
        {
            return new Point(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        public static Point operator *(Point A, double B)
        {
            return new Point(A.X * B, A.Y * B, A.Z * B);
        }

        public static Point operator /(Point A, double B)
        {
            return new Point(A.X / B, A.Y / B, A.Z / B);
        }

        #endregion
    }
}
