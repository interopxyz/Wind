using System;

namespace Aviary.Wind.Graphics
{
    public abstract class GraphicBase
    {

        #region members

        protected string id = string.Empty;

        #endregion

        #region contructors

        public GraphicBase()
        {
            id = Guid.NewGuid().ToString();
        }

        public GraphicBase(GraphicBase graphicBase)
        {
            id = Guid.NewGuid().ToString();
        }

        #endregion

        #region properties

        public virtual string ID
        {
            get { return id; }
        }

        #endregion

        #region methods



        #endregion

    }
}
