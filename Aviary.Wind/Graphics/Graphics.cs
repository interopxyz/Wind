using System;

namespace Aviary.Wind.Graphics
{
    public static class Graphics
    {
        public static Graphic Transparent = new Graphic(Strokes.Transparent, Fills.Transparent);

        public static Graphic FillBlack = new Graphic(Strokes.Transparent,Fills.Black);
        public static Graphic StrokeBlack = new Graphic(Strokes.Black, Fills.Transparent);

        public static Graphic FillWhite = new Graphic(Strokes.Transparent, Fills.White);
        public static Graphic StrokeWhite = new Graphic(Strokes.White, Fills.Transparent);
    }
}