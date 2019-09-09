using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Mathematics
{
    public class Domain
    {
        #region members

        private double t0 = 0.0;
        private double t1 = 1.0;

        #endregion

        #region constructors

        public Domain()
        {

        }

        public Domain(double t0, double t1)
        {
            this.T0 = t0;
            this.T1 = t1;
        }

        public Domain(Domain domain)
        {
            this.T0 = domain.T0;
            this.T1 = domain.T1;
        }

        #endregion

        #region properties

        public virtual double T0
        {
            get { return t0; }
            set { t0 = value; }
        }

        public virtual double T1
        {
            get { return t1; }
            set { t1 = value; }
        }

        #endregion
        
        #region methods

        public double Length()
        {
            return T1-T0;
        }

        public double Evaluate(double t)
        {
            return T0+t*(T1 - T0);
        }

        #endregion

    }
}