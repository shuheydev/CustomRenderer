using Xamarin.Forms;

namespace CustomRenderer.Controlls
{
    public class GradientStackLayout : StackLayout
    {
        public Color StartColor
        {
            get { return (Color)GetValue(StartColorProperty); }
            set { SetValue(StartColorProperty, value); }
        }
        public static readonly BindableProperty StartColorProperty = BindableProperty.Create(
               propertyName: nameof(StartColor),
               returnType: typeof(Color),
               declaringType: typeof(GradientStackLayout),
               defaultValue: Color.Transparent,
               defaultBindingMode: BindingMode.OneWay,
               propertyChanged: StartColorPropertyChanged
            );
        private static void StartColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }

        public Color EndColor
        {
            get { return (Color)GetValue(EndColorProperty); }
            set { SetValue(EndColorProperty, value); }
        }
        public static readonly BindableProperty EndColorProperty = BindableProperty.Create(
                propertyName: nameof(EndColor),
                returnType: typeof(Color),
                declaringType: typeof(GradientStackLayout),
                defaultValue: Color.Transparent,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: EndColorPropertyChanged
            );
        private static void EndColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }

        public float GradientRatio
        {
            get { return (float)GetValue(GradientRatioProperty); }
            set { SetValue(GradientRatioProperty, value); }
        }
        public static readonly BindableProperty GradientRatioProperty = BindableProperty.Create
            (
                propertyName: nameof(GradientRatio),
                returnType: typeof(float),
                declaringType: typeof(GradientStackLayout),
                defaultValue: 1.0f,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: GradientRatioPropertyChanged
            );
        private static void GradientRatioPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }


        public GradientHorizontalDirection GradientHorizontalDirection
        {
            get { return (GradientHorizontalDirection)GetValue(GradientHorizontalDirectionProperty); }
            set { SetValue(GradientHorizontalDirectionProperty, value); }
        }
        public static readonly BindableProperty GradientHorizontalDirectionProperty = BindableProperty.Create(
               propertyName: nameof(GradientHorizontalDirection),
               returnType: typeof(GradientHorizontalDirection),
               declaringType: typeof(GradientStackLayout),
               defaultValue: GradientHorizontalDirection.Nothing,
               defaultBindingMode: BindingMode.OneWay,
               propertyChanged: GradientHorizontalDirectionPropertyChanged
            );
        private static void GradientHorizontalDirectionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }

        public GradientVerticalDirection GradientVerticalDirection
        {
            get { return (GradientVerticalDirection)GetValue(GradientVerticalDirectionProperty); }
            set { SetValue(GradientVerticalDirectionProperty, value); }
        }
        public static readonly BindableProperty GradientVerticalDirectionProperty = BindableProperty.Create(
               propertyName: nameof(GradientVerticalDirection),
               returnType: typeof(GradientVerticalDirection),
               declaringType: typeof(GradientStackLayout),
               defaultValue: GradientVerticalDirection.Nothing,
               defaultBindingMode: BindingMode.OneWay,
               propertyChanged: GradientVerticalDirectionPropertyChanged
            );
        private static void GradientVerticalDirectionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }
    }

    public enum GradientHorizontalDirection
    {   
        LeftToRight,
        RightToLeft,
        Nothing,
    }

    public enum GradientVerticalDirection
    {
        TopToBottom,
        BottomToTop,
        Nothing,
    }
}
