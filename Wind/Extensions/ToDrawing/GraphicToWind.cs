using Sw = System.Windows;
using System.Linq;
using Wg = Wind.Graphics;
using Dr = System.Drawing;

namespace Wind
{
    public static class GraphicToWind
    {

        #region Graphics
        public static Wg.Color ToWindColor(this Dr.Color input)
        {
            return new Wg.Color(input.R,input.G,input.B,input.A);
        }

        #endregion

    }
}
