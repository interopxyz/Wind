using System;
using System.Collections.Generic;

using Aviary.Wind.Geometry;

namespace Aviary.Wind.Graphics
{
    public class GradientRadial : Gradient
    {
        #region members
        
        public Point Center = new Point();
        public Point Focus = new Point();
        public double RadiusX = 1.0;
        public double RadiusY = 1.0;

        #endregion

        #region contructors
        
        public GradientRadial() : base(FillTypes.RadialGradient)
        {
        }

        public GradientRadial(GradientRadial gradient) : base(gradient)
        {
        }

        public GradientRadial(List<Color> colors) : base(colors, FillTypes.RadialGradient)
        {
        }

        public GradientRadial(List<Color> colors, List<double> stops) : base(colors, stops, FillTypes.RadialGradient)
        {
        }

        #endregion

        #region properties



        #endregion

        #region methods



        #endregion

    }
}
