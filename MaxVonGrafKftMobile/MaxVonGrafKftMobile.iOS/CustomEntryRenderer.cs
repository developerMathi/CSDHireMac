using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using MaxVonGrafKftMobile.Renders;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(EntryRenderer))]

namespace MaxVonGrafKftMobile.iOS
{
    public class MyEntryRenderer : EntryRenderer
    {
        private CALayer _line;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            _line = null;
            if (Control != null)
            {

                Control.BorderStyle = UITextBorderStyle.None;
                Control.Layer.CornerRadius = 10;
                Control.Layer.BorderWidth = 0;
                //Control.TextColor = UIColor.White;

                _line = new CALayer
                {
                    BorderColor = UIColor.FromRGB(255, 135, 183).CGColor,
                    BackgroundColor = UIColor.FromRGB(174, 174, 174).CGColor,
                    Frame = new CGRect(0, Frame.Height / 2, Frame.Width * 2, 1f)
                };

                Control.Layer.AddSublayer(_line);
            }
        }
    }
}