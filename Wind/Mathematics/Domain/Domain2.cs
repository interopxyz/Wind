using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Mathematics
{
    public class Domain2
    {
        #region members

        private double u0 = 0.0;
        private double u1 = 1.0;
        private double v0 = 0.0;
        private double v1 = 1.0;

        #endregion

        #region constructors

        public Domain2()
        {

        }

        public Domain2(double u0, double u1, double v0, double v1)
        {
            this.U0 = u0;
            this.U1 = u1;
            this.V0 = v0;
            this.V1 = v1;
        }

        public Domain2(Domain u, Domain v)
        {
            this.U0 = u.T0;
            this.U1 = u.T1;
            this.V0 = v.T0;
            this.V1 = v.T1;
        }

        public Domain2(Domain2 domain2)
        {
            this.U0 = domain2.U0;
            this.U1 = domain2.U1;
            this.V0 = domain2.V0;
            this.V1 = domain2.V1;
        }

        #endregion

        #region properties

        public virtual double U0
        {
            get { return u0; }
            set { u0 = value; }
        }

        public virtual double U1
        {
            get { return u1; }
            set { u1 = value; }
        }

        public virtual double V0
        {
            get { return v0; }
            set { v0 = value; }
        }

        public virtual double V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        public virtual Domain DomainU
        {
            get { return new Domain(u0, u1); }
            set
            {
                u0 = value.T0;
                u1 = value.T1;
            }
        }

        public virtual Domain DomainV
        {
            get { return new Domain(v0, v1); }
            set
            {
                v0 = value.T0;
                v1 = value.T1;
            }
        }

        #endregion

        #region methods

        public double Area()
        {
            return this.DomainU.Length() * this.DomainV.Length();
        }

        #endregion

    }
}