using Sw = System.Windows;
using Sm = System.Windows.Media;
using Se = System.Windows.Media.Effects;
using System.Linq;
using Wg = Wind.Graphics;

namespace Wind
{
    public static class GraphicToMedia
    {

        #region Graphics

        public static Sm.Color ToMediaColor(this Wg.Color input)
        {
            return Sm.Color.FromArgb((byte)input.A, (byte)input.R, (byte)input.G, (byte)input.B);
        }

        public static Sm.PenLineCap ToMediaCap(this Wg.Stroke.StrokeCaps input)
        {
            Sm.PenLineCap cap = Sm.PenLineCap.Flat;
            switch (input)
            {
                case Wg.Stroke.StrokeCaps.Round:
                    cap = Sm.PenLineCap.Round;
                    break;
                case Wg.Stroke.StrokeCaps.Square:
                    cap = Sm.PenLineCap.Square;
                    break;
                case Wg.Stroke.StrokeCaps.Triangle:
                    cap = Sm.PenLineCap.Triangle;
                    break;
            }
            return cap;
        }

        public static Sm.PenLineJoin ToMediaJoin(this Wg.Stroke.StrokeCorners input)
        {
            Sm.PenLineJoin corner = Sm.PenLineJoin.Round;
            switch (input)
            {
                case Wg.Stroke.StrokeCorners.Bevel:
                    corner = Sm.PenLineJoin.Bevel;
                    break;
                case Wg.Stroke.StrokeCorners.Miter:
                    corner = Sm.PenLineJoin.Miter;
                    break;
            }
            return corner;
        }

        public static Sm.Brush ToMediaBrush(this Wg.Fill input)
        {
            Sm.Brush brush = null;
            switch (input.FillType)
            {
                default:
                    brush = new Sm.SolidColorBrush(input.Background.ToMediaColor());
                    break;
                case Wg.Fill.FillTypes.Gradient:
                    brush = new Sm.SolidColorBrush(input.Background.ToMediaColor());
                    break;
                case Wg.Fill.FillTypes.Pattern:
                    brush = new Sm.SolidColorBrush(input.Background.ToMediaColor());
                    break;
                case Wg.Fill.FillTypes.Bitmap:
                    brush = new Sm.SolidColorBrush(input.Background.ToMediaColor());
                    break;
            }

            return brush;
        }

        public static Sm.Pen ToMediaPen(this Wg.Stroke input)
        {
            Sm.Pen pen = new Sm.Pen(new Sm.SolidColorBrush(input.Color.ToMediaColor()), input.Weight);
            pen.StartLineCap = input.Cap.ToMediaCap();
            pen.EndLineCap = input.Cap.ToMediaCap();
            pen.DashCap = input.Cap.ToMediaCap();

            if (input.HasPattern) pen.DashStyle = new Sm.DashStyle(input.Pattern, input.Offset);

            pen.LineJoin = input.Corner.ToMediaJoin();
            pen.MiterLimit = input.MiterLimit;

            return pen;
        }

        #endregion

    }
}
