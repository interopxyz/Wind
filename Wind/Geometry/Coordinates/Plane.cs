using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Geometry
{
    public class Plane
    {

        #region members

        private Point origin = new Point();
        private Vector axisX = new Vector().AxisX;
        private Vector axisY = new Vector().AxisY;

        #endregion

        #region constructors

        public Plane()
        {

        }

        /// <summary>
        /// Construct an Default XY Plane at an origin point
        /// </summary>
        /// <param name="origin">The Origin point of the new plane</param>
        /// <returns></returns>
        public Plane(Point origin)
        {
            this.origin = origin;
        }

        public Plane(Point origin, Vector axisX, Vector axisY)
        {
            this.origin = origin;
            this.axisX = axisX.GetUnitVector();
            this.axisY = MakeOrtho(axisY, axisX);
        }

        public Plane(Point origin, Point pointX, Point pointY)
        {
            Vector Xaxis = new Vector(origin, pointX);
            Vector Yaxis = new Vector(origin, pointY);

            this.origin = origin;
            this.axisX = Xaxis.GetUnitVector();
            this.axisY = MakeOrtho(Yaxis, Xaxis);
        }

        #endregion

        #region properties

        public virtual Point Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public virtual Vector AxisX
        {
            get { return axisX.GetUnitVector(); }
            set
            {
                axisX = value.GetUnitVector();
                axisY = MakeOrtho(axisY, axisX);
            }
        }

        public virtual Vector AxisY
        {
            get { return axisY.GetUnitVector(); }
            set
            {
                axisY = value.GetUnitVector();
                axisX = MakeOrtho(axisX, axisY);
            }
        }

        public virtual Vector AxisZ
        {
            get { return axisX.GetCrossProduct(axisY).GetUnitVector(); }
        }

        #endregion

        #region methods

        private Vector MakeOrtho(Vector vectorA, Vector vectorB)
        {
            Vector vecA = vectorA.GetUnitVector();
            Vector vecB = vectorB.GetUnitVector();
            Vector vector = vecA.GetCrossProduct(vecB).GetUnitVector();
            
            return vecB.GetCrossProduct(vector).GetUnitVector();
        }

        public Point Evaluate(Point parameter)
        {
            Vector vecX = AxisX.GetUnitVector() * parameter.X;
            Vector vecY = AxisY.GetUnitVector() * parameter.Y;
            Vector vecZ = AxisZ.GetUnitVector() * parameter.Z;

            return Origin + vecX + vecY + vecZ;
        }

        public Point Project(Point point, Vector direction = null)
        {
            if (direction == null) direction = this.AxisZ;
            Vector dir = new Vector(direction);

            Vector v = new Vector(this.origin, point);
            double dist = v.X * dir.X + v.Y * dir.Y + v.Z * dir.Z;

            Point projection = point - dir * dist;

            return projection;
        }

        public double DistanceTo(Point point, Vector direction = null)
        {
            if (direction == null) direction = this.AxisZ;
            Vector dir = direction.GetUnitVector();

            double a = -dir.GetDotProduct(new Vector(this.Origin, point));
            double b = dir.GetDotProduct(dir);

            return a / b;
        }

        public Point ParameterAt(Point point)
        {
            Point param = new Point();

            Vector X = this.AxisX*(-1.0);
            Vector Y = this.AxisY * (-1.0);
            Vector Z = this.AxisZ;

            param.Z = DistanceTo(point, Z);
            Z.Length = param.Z;
            point = point + Z;

            param.Y = DistanceTo(point, Y);
            Y.Length = param.Y;
            point = point + Y;

            param.X = DistanceTo(point, X);

            return param;
        }


        #endregion

        #region operator overrides

        #endregion

    }
}
