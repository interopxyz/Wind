using Dr = System.Drawing;

using Wg = Aviary.Wind.Graphics;

namespace Aviary.Wind
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
