using System;
using System.Collections.Generic;

namespace Aviary.Wind.Graphics
{
    public abstract class Gradient:Fill
    {

        #region members

        public enum InteropolationMode { Linear, Smooth };

        protected InteropolationMode mode = InteropolationMode.Linear;

        protected List<double> stops = new List<double>();
        protected List<Color> colors = new List<Color>();

        #endregion

        #region contructors

        public Gradient() : base(FillTypes.LinearGradient)
        {
            colors = new List<Color> { Wind.Graphics.Colors.Black, Wind.Graphics.Colors.White };
            stops = new List<double> { 0, 1 };
        }

        public Gradient(FillTypes fillTypes) : base(FillTypes.LinearGradient)
        {
            colors = new List<Color> { Wind.Graphics.Colors.Black, Wind.Graphics.Colors.White };
            stops = new List<double> { 0, 1 };
        }

        public Gradient(Gradient gradient) : base(gradient)
        {
            this.mode = gradient.mode;
            this.colors = gradient.colors;
            this.stops = gradient.stops;
        }

        public Gradient(List<Color> colors, FillTypes type) : base(type)
        {
            this.colors = colors;
            int count = colors.Count;
            for (int i = 0; i < count; i++)
            {
                stops.Add(i / count);
            }
        }

        public Gradient(List<Color> colors, List<double> stops, FillTypes type) : base(type)
        {
            this.colors = colors;
            this.stops = stops;

            int countA = colors.Count;
            int countB = stops.Count;
            double start = stops[stops.Count - 1];
            double step = (1 - start) / (countA - countB);
            for (int i = countB; i < countA; i++)
            {
                stops.Add(start + i * step);
            }
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
