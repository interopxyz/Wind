using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Graphics
{
    public class BlurEffect
    {
        #region members
        
        public double Radius = 1.0;

        #endregion

        #region contructors

        public BlurEffect()
        {

        }

        public BlurEffect(BlurEffect blurEffect)
        {
            this.Radius = blurEffect.Radius;
        }

        public BlurEffect(double radius)
        {
            this.Radius = radius;
        }

        #endregion

        #region properties
        


        #endregion

        #region methods



        #endregion

    }
}
