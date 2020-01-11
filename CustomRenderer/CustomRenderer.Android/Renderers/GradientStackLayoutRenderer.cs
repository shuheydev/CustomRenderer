using Android.Content;
using Android.Graphics;
using CustomRenderer.Controlls;
using CustomRenderer.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

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
            var hd = Element.GradientHorizontalDirection;
            var vd = Element.GradientVerticalDirection;
            float width = Width * Element.GradientRatio;
            float height = Height * Element.GradientRatio;
            var color0 = Element.StartColor.ToAndroid();
            var color1 = Element.EndColor.ToAndroid();

            LinearGradient gradient = ComposeGradient(hd,
                                                      vd,
                                                      width,
                                                      height,
                                                      color0,
                                                      color1);

            Paint paint = new Paint
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);

            base.DispatchDraw(canvas);
        }

        private LinearGradient ComposeGradient(GradientHorizontalDirection hd,
                                               GradientVerticalDirection vd,
                                               float width,
                                               float height,
                                               Android.Graphics.Color color0,
                                               Android.Graphics.Color color1)
        {
            #region グラデーションの方向

            //Switch式便利!
            (float x0, float x1) = hd switch
            {
                GradientHorizontalDirection.LeftToRight => (0f, width),
                GradientHorizontalDirection.RightToLeft => (width, 0f),
                _ => (0f, 0f)
            };
            (float y0, float y1) = vd switch
            {
                GradientVerticalDirection.TopToBottom => (0f, height),
                GradientVerticalDirection.BottomToTop => (height, 0f),
                _ => (0f, 0f)
            };
            #endregion

            //縦横双方がNothingだった場合は,StartColor一色で塗りつぶすようにする
            if (hd == GradientHorizontalDirection.Nothing && vd == GradientVerticalDirection.Nothing)
            {
                color1 = color0;
            }

            //X軸始点
            //Y軸始点
            //X軸終点
            //Y軸終点
            //開始色
            //終了色
            //範囲外の描画方法
            LinearGradient gradient = new LinearGradient(
                        x0: x0,
                        y0: y0,
                        x1: x1,
                        y1: y1,
                        color0: color0,
                        color1: color1,
                        tile: Shader.TileMode.Clamp
                );

            return gradient;
        }
    }
}