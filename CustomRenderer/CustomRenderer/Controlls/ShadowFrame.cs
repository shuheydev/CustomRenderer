using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderer.Controlls
{
    public class ShadowFrame:Frame
    {

        public float Elevation
        {
            get { return (float)GetValue(ElevationProperty); }
            set { SetValue(ElevationProperty, value); }
        }
        public static readonly BindableProperty ElevationProperty = BindableProperty.Create(
               propertyName: nameof(Elevation),
               returnType: typeof(float),
               declaringType: typeof(ShadowFrame),
               defaultValue: 4.0f,
               defaultBindingMode: BindingMode.OneWay,
               propertyChanged: ElevationPropertyChanged
            );
        private static void ElevationPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
        }
    }
}
