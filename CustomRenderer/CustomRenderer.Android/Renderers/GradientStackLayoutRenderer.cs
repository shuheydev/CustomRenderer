using Android.Content;
using Android.Graphics;
using CustomRenderer.Controlls;
using CustomRenderer.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.FastRenderers;

[assembly: ExportRenderer(typeof(GradientStackLayout), typeof(GradientStackLayoutRenderer))]
namespace CustomRenderer.Droid.Renderers
{
    public class GradientStackLayoutRenderer : VisualElementRenderer<GradientStackLayout>
    {
        public GradientStackLayoutRenderer(Context context) : base(context)
        {
        }

        protected override void DispatchDraw(Canvas canvas)
        {
            //X軸始点
            //Y軸始点
            //X軸終点
            //Y軸終点
            //開始色
            //終了色
            //範囲外の描画方法
            LinearGradient gradient = new LinearGradient
                (
                    x0: 0,
                    y0: 0,
                    x1: 0,
                    y1: Height*Element.GradientRatio,
                    color0: Element.StartColor.ToAndroid(),
                    color1: Element.EndColor.ToAndroid(),
                    tile: Shader.TileMode.Clamp
                );

            Paint paint = new Paint
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);

            base.DispatchDraw(canvas);
        }
    }
}