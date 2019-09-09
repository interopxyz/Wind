using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Graphics
{
    public class Fill
    {
        #region members

        public enum FillTypes { Solid, Pattern, Gradient, Bitmap};

        protected FillTypes type = FillTypes.Solid;

        protected Color background = Colors.Black;

        #endregion

        #region contructors

        public Fill()
        {

        }

        public Fill(Fill fill)
        {
            this.type = fill.type;
            this.background = fill.background;
        }

        protected Fill(FillTypes type)
        {
            this.type = type;
        }

        public Fill(Color background)
        {
            this.background = background;
        }

        #endregion

        #region properties

        public virtual Color Background
        {
            get { return background; }
            set { background = value; }
        }

        public virtual FillTypes FillType
        {
            get { return type; }
        }

        #endregion

        #region methods



        #endregion

    }
}
