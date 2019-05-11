using SecondPage;
using SecondPage.Droids;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(GradientColorStack), typeof(GradientColorStackRenderer))]
namespace SecondPage.Droids
{
    public class GradientColorStackRenderer : VisualElementRenderer<StackLayout> 
    {
        private Color StartColor
        {
            get;
            set;
        }
        private Color EndColor
        {
            get;
            set;
        }
        protected override void DispatchDraw(global::Android.Graphics.Canvas canvas)
        {
            #region
            var gradient = new Android.Graphics.LinearGradient(0, 0, 0, Height, this.StartColor.ToAndroid(),EndColor.ToAndroid(), Android.Graphics.Shader.TileMode.Mirror);
            #endregion
            var paint = new Android.Graphics.Paint()
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }
        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            try
            {
                var stack = e.NewElement as GradientColorStack;
                this.StartColor = stack.StartColor;
                this.EndColor = stack.EndColor;
            }
            catch (Exception ex)
            {
                //Syatem.Diagnostics.Debug.WriteLine("ERROR:", ex.Message);
            }
        }
    }
}