using System;

namespace Aviary.Wind.Graphics
{
    public class Fill : GraphicBase
    {
        #region members

        public enum FillTypes { Solid, Pattern, LinearGradient, RadialGradient, Bitmap};

        protected FillTypes type = FillTypes.Solid;

        protected Color background = Colors.Black;

        public bool IsCompound = false;

        #endregion

        #region contructors

        public Fill():base()
        {

        }

        public Fill(Fill fill) : base()
        {
            this.type = fill.type;
            this.background = new Color(fill.background);
        }

        protected Fill(FillTypes type) : base()
        {
            this.type = type;
        }

        public Fill(Color background) : base()
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
