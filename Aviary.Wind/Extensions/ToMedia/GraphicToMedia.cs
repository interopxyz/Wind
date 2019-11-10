using Sm = System.Windows.Media;
using System;
using System.Windows;

using Wg = Aviary.Wind.Graphics;

namespace Aviary.Wind
{
    public static class GraphicToMedia
    {

        #region graphics

        public static Sm.Color ToMediaColor(this Wg.Color input)
        {
            return Sm.Color.FromArgb((byte)input.A, (byte)input.R, (byte)input.G, (byte)input.B);
        }

        #endregion

        #region stroke

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

        #region fill

        public static Sm.Brush ToMediaBrush(this Wg.Fill input)
        {
            Sm.Brush brush = null;
            switch (input.FillType)
            {
                default:
                    brush = new Sm.SolidColorBrush(input.Background.ToMediaColor());
                    break;
                case Wg.Fill.FillTypes.LinearGradient:
                    brush = ((Wg.GradientLinear)input).ToMediaBrush();
                    break;
                case Wg.Fill.FillTypes.RadialGradient:
                    brush = ((Wg.GradientRadial)input).ToMediaBrush();
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

        public static Sm.LinearGradientBrush ToMediaBrush(this Wg.GradientLinear input)
        {
            Sm.LinearGradientBrush brush = new Sm.LinearGradientBrush();
            int i = 0;
            foreach (Wg.Color color in input.Colors)
            {
                brush.GradientStops.Add(new Sm.GradientStop(color.ToMediaColor(), input.Stops[i]));
                i++;
            }

            brush.SpreadMethod = Sm.GradientSpreadMethod.Pad;
            brush.MappingMode = Sm.BrushMappingMode.RelativeToBoundingBox;

            double radians = input.Angle / 180 * Math.PI;
            double XA = (0.5 + Math.Sin(radians) * 0.5);
            double YA = (0.5 + Math.Cos(radians) * 0.5);
            double XB = (0.5 + Math.Sin(radians + Math.PI) * 0.5);
            double YB = (0.5 + Math.Cos(radians + Math.PI) * 0.5);

            brush.StartPoint = new Point(XA, YA);
            brush.EndPoint = new Point(XB, YB);

            return brush;
        }

        public static Sm.RadialGradientBrush ToMediaBrush(this Wg.GradientRadial input)
        {
            Sm.RadialGradientBrush brush = new Sm.RadialGradientBrush();
            int i = 0;
            foreach (Wg.Color color in input.Colors)
            {
                brush.GradientStops.Add(new Sm.GradientStop(color.ToMediaColor(), input.Stops[i]));
                i++;
            }

            brush.SpreadMethod = Sm.GradientSpreadMethod.Pad;
            brush.MappingMode = Sm.BrushMappingMode.RelativeToBoundingBox;
            
            brush.Center = new Point(input.Center.X, input.Center.Y);
            brush.GradientOrigin = new Point(input.Focus.X, input.Focus.Y);
            brush.RadiusX = input.RadiusX;
            brush.RadiusY = input.RadiusY;

            return brush;
        }



        #endregion

    }
}
