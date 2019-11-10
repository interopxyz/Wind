using System;

namespace Aviary.Wind.Graphics
{
    public class ShadowEffect
    {
        #region members

        public Color Color = Colors.Black;
        public double Radius = 1.0;
        public double Angle = 0.0;
        public double Distance = 0.0;

        #endregion

        #region contructors

        public ShadowEffect()
        {

        }

        public ShadowEffect(ShadowEffect shadowEffect)
        {
            this.Color = shadowEffect.Color;
            this.Radius = shadowEffect.Radius;
            this.Angle = shadowEffect.Angle;
            this.Distance = shadowEffect.Distance;
        }

        public ShadowEffect(Color color, double radius = 1.0, double angle = 0.0, double distance = 0.0)
        {
            this.Color = color;
            this.Radius = radius;
            this.Angle = angle;
            this.Distance = distance;
        }

        #endregion

        #region properties



        #endregion

        #region methods



        #endregion

    }
}