using System;

namespace Aviary.Wind.Geometry
{
    public class Vector : Coordinate
    {
        #region members

        #endregion

        #region constructors

        public Vector()
        {

        }

        public Vector(double x, double y, double z = 0) : base(x, y, z)
        {

        }

        public Vector(Coordinate coordinate) : base(coordinate)
        {

        }

        public Vector(Point origin, Point target) : base(target.X - origin.X, target.Y - origin.Y, target.Z - origin.Z)
        {

        }

        #endregion

        #region properties

        public virtual double Length
        {
            get { return Math.Sqrt(Math.Pow(X, 2.0) + Math.Pow(Y, 2.0) + Math.Pow(Z, 2.0)); }
            set
            {
                this.Unitize();
                this.X = this.X * value;
                this.Y = this.Y * value;
                this.Z = this.Z * value;
            }
        }

        public virtual Vector AxisX
        {
            get { return new Vector(1, 0, 0); }
        }

        public virtual Vector AxisY
        {
            get { return new Vector(0, 1, 0); }
        }

        public virtual Vector AxisZ
        {
            get { return new Vector(0, 0, 1); }
        }

        #endregion

        #region methods

        public void Unitize()
        {
            double length = this.Length;
            this.X /= length ;
            this.Y /= length ;
            this.Z /= length;
        }

        public void Reverse()
        {
            this.X *= -1.0;
            this.Y *= -1.0;
            this.Z *= -1.0;
        }

        public Vector GetUnitVector()
        {
            Vector output = new Vector(this);
            output.Unitize();
            return output;
        }

        public Vector GetCrossProduct(Vector vector)
        {
            return new Vector(this.Y * vector.Z - this.Z * vector.Y, (this.X * vector.Z - this.Z * vector.X) * (-1), (this.X * vector.Y - this.Y * vector.X));
        }

        public double GetDotProduct(Vector vector)
        {
            return ((this.X * vector.X) + (this.Y * vector.Y) + (this.Z * vector.Z));
        }

        public double VectorAngle(Vector vector)
        {
            return Math.Atan2(GetCrossProduct(vector).Z, GetDotProduct(vector));
        }

        public double GetAngle(Vector vector)
        {
            return Math.Atan2(GetCrossProduct(vector).Z, GetDotProduct(vector));
        }

        #endregion

        #region operators

        public static Vector operator -(Vector A, Coordinate B)
        {
            return new Vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        public static Vector operator +(Vector A, Coordinate B)
        {
            return new Vector(A.X + B.X, A.Y + B.Y, A.Z + B.Z);
        }

        public static Vector operator *(Vector A, double B)
        {
            return new Vector(A.X * B, A.Y * B, A.Z * B);
        }

        public static Vector operator /(Vector A, double B)
        {
            return new Vector(A.X / B, A.Y / B, A.Z / B);
        }

        #endregion
    }
}
