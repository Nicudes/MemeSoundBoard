using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MemeSounds.controls
{
    
        public class AdMobView : View
        {
            public static readonly BindableProperty AdUnitProperty = BindableProperty.Create(
                nameof(AdUnitId),
                typeof(string),
                typeof(AdMobView),
                string.Empty);

            public string AdUnitId
            {
                get => (string)GetValue(AdUnitProperty);
                set => SetValue(AdUnitProperty, value);
            }


        }
    
}
