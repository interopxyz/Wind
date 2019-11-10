using Dr = System.Drawing;

using Wg = Aviary.Wind.Graphics;

namespace Aviary.Wind
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
