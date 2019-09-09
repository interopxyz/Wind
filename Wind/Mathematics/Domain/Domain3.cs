using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Mathematics
{
    public class Domain3
    {
        #region members

        private double u0 = 0.0;
        private double u1 = 1.0;
        private double v0 = 0.0;
        private double v1 = 1.0;
        private double w0 = 0.0;
        private double w1 = 1.0;

        #endregion

        #region constructors

        public Domain3()
        {

        }

        public Domain3(double u0, double u1, double v0, double v1, double w0, double w1)
        {
            this.U0 = u0;
            this.U1 = u1;
            this.V0 = v0;
            this.V1 = v1;
            this.W0 = w0;
            this.W1 = w1;
        }

        public Domain3(Domain u, Domain v, Domain w)
        {
            this.U0 = u.T0;
            this.U1 = u.T1;
            this.V0 = v.T0;
            this.V1 = v.T1;
            this.W0 = w.T0;
            this.W1 = w.T1;
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

        public virtual double W0
        {
            get { return w0; }
            set { w0 = value; }
        }

        public virtual double W1
        {
            get { return w1; }
            set { w1 = value; }
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

        public virtual Domain DomainW
        {
            get { return new Domain(w0, w1); }
            set
            {
                w0 = value.T0;
                w1 = value.T1;
            }
        }

        public virtual Domain2 DomainUV
        {
            get { return new Domain2(u0, u1, v0, v1); }
            set
            {
                u0 = value.U0;
                u1 = value.U1;
                v0 = value.V0;
                v1 = value.V1;
            }
        }

        public virtual Domain2 DomainUW
        {
            get { return new Domain2(u0, u1, w0, w1); }
            set
            {
                u0 = value.U0;
                u1 = value.U1;
                w0 = value.V0;
                w1 = value.V1;
            }
        }

        public virtual Domain2 DomainVW
        {
            get { return new Domain2(v0, v1, w0, w1); }
            set
            {
                v0 = value.U0;
                v1 = value.U1;
                w0 = value.V0;
                w1 = value.V1;
            }
        }

        #endregion

        #region methods

        public double Volume()
        {
            return this.DomainU.Length() * this.DomainV.Length() * this.DomainW.Length();
        }

        #endregion

    }
}