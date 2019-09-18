using System;
using System.Collections.Generic;

namespace Aviary.Wind.Graphics
{
    public class Stroke : GraphicBase
    {

        #region members

        public enum StrokeTypes { Flat, Brush};

        public enum StrokeCaps { Flat, Round, Square, Triangle };
        public enum StrokeCorners { Bevel, Miter, Round };

        protected StrokeTypes type = StrokeTypes.Flat;

        protected Color color = Colors.Black;
        protected double weight = 1.0;

        protected List<double> pattern { get; set; } = new List<double> { 0 };
        protected double dashoffset { get; set; } = 0;

        protected StrokeCaps cap = StrokeCaps.Round;
        protected StrokeCorners corner = StrokeCorners.Round;
        protected double miterLimit { get; set; } = 0;

        #endregion

        #region contructors

        public Stroke():base()
        {

        }

        protected Stroke(StrokeTypes type) : base()
        {
            this.type = type;
        }

        public Stroke(Color color, double weight = 1.0) : base()
        {
            this.color = color;
            this.weight = weight;
        }

        public Stroke(Color color, List<double> pattern, double weight = 1.0) : base()
        {
            this.color = color;
            this.weight = weight;
            this.pattern = pattern;
        }

        public Stroke(Stroke stroke) : base()
        {
            this.type = stroke.type;
            this.color = stroke.color;
            this.weight = stroke.weight;
            this.pattern = stroke.pattern;
            this.dashoffset = stroke.dashoffset;
            this.cap = stroke.cap;
            this.corner = stroke.corner;
            this.miterLimit = stroke.miterLimit;
        }

        #endregion

        #region properties

        public virtual StrokeTypes StrokeType
        {
            get { return type; }
        }

        public virtual Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public virtual StrokeCaps Cap
        {
            get { return cap; }
            set { cap = value; }
        }

        public virtual StrokeCorners Corner
        {
            get { return corner; }
            set { corner = value; }
        }

        public virtual double MiterLimit
        {
            get { return miterLimit; }
            set { miterLimit = value; }
        }

        public virtual List<double> Pattern
        {
            get { return pattern; }
            set { pattern = value; }
        }

        public virtual double Offset
        {
            get { return dashoffset; }
            set { dashoffset = value; }
        }
        
        public virtual bool HasPattern
        {
            get { return ((Pattern.Count > 1) && (pattern[0] == 0)); }
        }
        #endregion

        #region methods



        #endregion

    }
}
