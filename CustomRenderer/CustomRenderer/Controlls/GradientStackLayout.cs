using System;
using System.Collections.Generic;
using System.Text;
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
            //Do something if you need.
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
            //Do something if you need.
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
    }
}
