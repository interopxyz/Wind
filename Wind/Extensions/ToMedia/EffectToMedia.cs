using Sw = System.Windows;
using Sm = System.Windows.Media;
using Se = System.Windows.Media.Effects;
using System.Linq;
using Wg = Wind.Graphics;

namespace Wind
{
    public static class EffectToMedia
    {

        #region Shape
        
        public static Se.BitmapEffectGroup ToMediaBitmapEffect(this Wg.Effects input)
        {
            Se.BitmapEffectGroup output = new Se.BitmapEffectGroup();
            if (input.HasBlurEffect) output.Children.Add(input.Blur.ToMediaBitmapEffect());
            if (input.HasShadowEffect) output.Children.Add(input.Shadow.ToMediaBitmapEffect());
            return output;
        }

        #endregion

        #region Media Effect

        public static Se.BlurEffect ToMediaEffect(this Wg.BlurEffect input)
        {
            Se.BlurEffect output = new Se.BlurEffect();
            output.Radius = input.Radius;
            return output;
        }

        public static Se.DropShadowEffect ToMediaEffect(this Wg.ShadowEffect input)
        {
            Se.DropShadowEffect output = new Se.DropShadowEffect();
            output.BlurRadius = input.Radius;
            output.Direction = input.Angle+90;
            output.ShadowDepth = input.Distance;

            return output;
        }

        #endregion

        #region Media Bitmap Effect


        public static Se.BlurBitmapEffect ToMediaBitmapEffect(this Wg.BlurEffect input)
        {
            Se.BlurBitmapEffect output = new Se.BlurBitmapEffect();
            output.Radius = input.Radius;
            return output;
        }
        
        public static Se.DropShadowBitmapEffect ToMediaBitmapEffect(this Wg.ShadowEffect input)
        {
            Se.DropShadowBitmapEffect output = new Se.DropShadowBitmapEffect();
            output.Color = input.Color.ToMediaColor();
            output.Opacity = input.Color.A/255.0;
            output.Softness = input.Radius;
            output.Direction = input.Angle;
            output.ShadowDepth = input.Distance;

            return output;
        }


        #endregion

    }
}
