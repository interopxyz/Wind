using System;

namespace Aviary.Wind.Graphics
{
    public class Graphic:GraphicBase
    {

        #region members

        protected Fill fill = new Fill();
        protected Stroke stroke = new Stroke();
        protected Effects effects = new Effects();

        #endregion

        #region constructors

        public Graphic():base()
        {

        }

        public Graphic(Graphic graphic) : base()
        {
            this.Fill = new Fill(graphic.Fill);
            this.Stroke = new Stroke(graphic.Stroke);
        }

        public Graphic(Fill fill) : base()
        {
            this.fill = fill;
        }

        public Graphic(Stroke stroke) : base()
        {
            this.stroke = stroke;
        }

        public Graphic(Stroke stroke, Fill fill) : base()
        {
            this.stroke = stroke;
            this.fill = fill;
        }

        public Graphic(Color fillColor) : base()
        {
            this.fill.Background = fillColor;
        }

        public Graphic(Color strokeColor, double weight) : base()
        {
            this.stroke.Color = strokeColor;
            this.stroke.Weight = weight;
        }

        public Graphic(Color strokeColor, double weight, Color fillColor) : base()
        {
            this.stroke.Color = strokeColor;
            this.stroke.Weight = weight;
            this.fill.Background = fillColor;
        }

        #endregion

        #region properties

        public virtual Stroke Stroke
        {
            get { return stroke; }
            set { stroke = value; }
        }

        public virtual Fill Fill
        {
            get { return fill; }
            set { fill = value; }
        }

        public virtual Effects Effects
        {
            get { return effects; }
            set { effects = value; }
        }

        public virtual string ID
        {
            get { return this.id; }
        }

        #endregion

    }
}
