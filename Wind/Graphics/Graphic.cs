using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Graphics
{
    public class Graphic
    {

        #region members

        protected string id = string.Empty;

        protected Fill fill = new Fill();
        protected Stroke stroke = new Stroke();
        protected Effects effects = new Effects();

        #endregion

        #region constructors

        public Graphic()
        {
            id = Guid.NewGuid().ToString();

        }

        public Graphic(Graphic graphic)
        {
            id = Guid.NewGuid().ToString();
            this.Fill = new Fill(graphic.Fill);
            this.Stroke = new Stroke(graphic.Stroke);
        }

        public Graphic(Fill fill)
        {
            id = Guid.NewGuid().ToString();
            this.fill = fill;
        }

        public Graphic(Stroke stroke)
        {
            id = Guid.NewGuid().ToString();
            this.stroke = stroke;
        }

        public Graphic(Stroke stroke, Fill fill)
        {
            id = Guid.NewGuid().ToString();
            this.stroke = stroke;
            this.fill = fill;
        }

        public Graphic(Color fillColor)
        {
            id = Guid.NewGuid().ToString();
            this.fill.Background = fillColor;
        }

        public Graphic(Color strokeColor, double weight)
        {
            id = Guid.NewGuid().ToString();
            this.stroke.Color = strokeColor;
            this.stroke.Weight = weight;
        }

        public Graphic(Color strokeColor, double weight, Color fillColor)
        {
            id = Guid.NewGuid().ToString();
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
