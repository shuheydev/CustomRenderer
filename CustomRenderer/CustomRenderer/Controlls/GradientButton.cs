using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderer.Controlls
{
    public class GradientButton:Button
    {
        public Color StartColor
        {
            get { return (Color)GetValue(StartColorProperty); }
            set { SetValue(StartColorProperty, value); }
        }
        public static readonly BindableProperty StartColorProperty = BindableProperty.Create(
               propertyName: nameof(StartColor),
               returnType: typeof(Color),
               declaringType: typeof(GradientButton),
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
               declaringType: typeof(GradientButton),
               defaultValue: Color.Transparent,
               defaultBindingMode: BindingMode.OneWay,
               propertyChanged: EndColorPropertyChanged
            );
        private static void EndColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {

        }
    }
}
