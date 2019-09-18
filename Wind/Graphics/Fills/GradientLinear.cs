using System;
using System.Collections.Generic;

namespace Aviary.Wind.Graphics
{
    public class GradientLinear : Gradient
    {
        #region members
        
        public double Angle = 0;

        #endregion

        #region contructors

        public GradientLinear() : base(FillTypes.LinearGradient)
        {
        }

        public GradientLinear(GradientLinear gradient) : base(gradient)
        {
            this.Angle = gradient.Angle;
        }

        public GradientLinear(List<Color> colors, double angle = 0) : base(colors, FillTypes.LinearGradient)
        {
            this.Angle = angle;
        }

        public GradientLinear(List<Color> colors, List<double> stops, double angle = 0) : base(colors, stops, FillTypes.LinearGradient)
        {
            this.Angle = angle;
        }

        #endregion

        #region properties

        public virtual List<Color> Colors
        {
            get { return colors; }
        }

        public virtual List<double> Stops
        {
            get { return stops; }
        }

        #endregion

        #region methods



        #endregion

    }
}
