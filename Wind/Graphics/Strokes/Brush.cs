using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Graphics
{
    public class Brush: Stroke
    {

        #region members
        
        protected List<double> weights = new List<double> { 1.0};

        #endregion

        #region contructors

        public Brush() : base(StrokeTypes.Brush)
        {
            this.weight = 1.0;
        }

        public Brush(Color color):base(StrokeTypes.Brush)
        {
            this.color = color;
            this.weight = 1.0;
        }

        public Brush(Color color, List<double> weights) : base(StrokeTypes.Brush)
        {
            this.color = color;
            this.weight = weights[0];
            this.weights = weights;
        }

        public Brush(Color color, List<double> pattern, List<double> weights) : base(StrokeTypes.Brush)
        {
            this.color = color;
            this.weight = weights[0];
            this.weights = weights;
            this.pattern = pattern;
        }

        #endregion

        #region properties

        public virtual List<double> Weights
        {
            get { return weights; }
            set { weights = value; }
        }

        #endregion

        #region methods



        #endregion

    }
}
