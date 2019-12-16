using System;

namespace Aviary.Wind.Graphics
{
    public class Color
    {
        #region members

        private int a = 255;
        private int r = 0;
        private int g = 0;
        private int b = 0;

        #endregion

        #region constructors

        public Color()
        {

        }

        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.A = alpha;
            this.R = red;
            this.G = green;
            this.B = blue;
        }

        public Color(Color color)
        {
            this.A = color.a;
            this.R = color.r;
            this.G = color.g;
            this.B = color.b;
        }

        #endregion

        #region properties

        public virtual int A
        {
            get { return a; }
            set { a = Math.Abs(value)%256; }
        }

        public virtual int R
        {
            get { return r; }
            set { r = Math.Abs(value) % 256; }
        }

        public virtual int G
        {
            get { return g; }
            set { g = Math.Abs(value) % 256; }
        }

        public virtual int B
        {
            get { return b; }
            set { b = Math.Abs(value) % 256; }
        }

        #endregion

        #region methods

        public double GetUnitA()
        {
            return a / 255.0;
        }

        public double GetUnitR()
        {
            return r / 255.0;
        }

        public double GetUnitG()
        {
            return g / 255.0;
        }

        public double GetUnitB()
        {
            return b / 255.0;
        }
        
        public string ToHex()
        {
            string red = r.ToString("X2");
            string green = g.ToString("X2");
            string blue = b.ToString("X2");

            return '#' + red + green + blue;
        }

        #endregion

    }
}
