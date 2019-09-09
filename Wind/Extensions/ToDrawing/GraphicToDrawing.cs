using Sw = System.Windows;
using System.Linq;
using Wg = Wind.Graphics;
using Dr = System.Drawing;

namespace Wind
{
    public static class GraphicToDrawing
    {

        #region Graphics

        public static Dr.Color ToDrawingColor(this Wg.Color input)
        {
            return Dr.Color.FromArgb(input.A, input.R,input.G,input.B);
        }
        
        #endregion

    }
}
