using Android.Content;
using Android.Graphics;
using CustomRenderer.Controlls;
using CustomRenderer.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//これらはうまく行かない.


//[assembly:ExportRenderer(typeof(GradientButton),typeof(GradientButtonRenderer))]
//namespace CustomRenderer.Droid.Renderers
//{
//    public class GradientButtonRenderer : Xamarin.Forms.Platform.Android.FastRenderers.ButtonRenderer
//    {
//        public GradientButtonRenderer(Context context) : base(context)
//        {
//        }

//        //protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
//        //{
//        //    base.OnElementChanged(e);

//        //    var btn = Control as Android.Widget.Button;
//        //    btn?.SetBackgroundResource(Resource.Drawable.gradient_button_style);
//        //}

//        protected override void DispatchDraw(Canvas canvas)
//        {
//            //X軸始点
//            //Y軸始点
//            //X軸終点
//            //Y軸終点
//            //開始色
//            //終了色
//            //範囲外の描画方法
//            LinearGradient gradient = new LinearGradient
//                (
//                    x0: 0,
//                    y0: 0,
//                    x1: Width,
//                    y1: 0,
//                    color0: ((GradientButton)Element).StartColor.ToAndroid(),
//                    color1: ((GradientButton)Element).EndColor.ToAndroid(),
//                    tile: Shader.TileMode.Clamp
//                );

//            Paint paint = new Paint
//            {
//                Dither = true,
//            };
//            paint.SetShader(gradient);
//            canvas.DrawPaint(paint);

//            base.DispatchDraw(canvas);
//        }
//    }
//}


[assembly: ExportRenderer(typeof(GradientButton), typeof(GradientButtonRenderer))]
namespace CustomRenderer.Droid.Renderers
{
    public class GradientButtonRenderer : ButtonRenderer
    {
        public GradientButtonRenderer(Context context) : base(context)
        {
        }

        protected override void DispatchDraw(Canvas canvas)
        {
            LinearGradient gradient = null;

            gradient = new Android.Graphics.LinearGradient(
                0,
                0,
                Width,
                0,
                ((GradientButton)Element).StartColor.ToAndroid(),
                ((GradientButton)Element).EndColor.ToAndroid(),
                Android.Graphics.Shader.TileMode.Mirror);

            var paint = new Android.Graphics.Paint()
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }

    }

}