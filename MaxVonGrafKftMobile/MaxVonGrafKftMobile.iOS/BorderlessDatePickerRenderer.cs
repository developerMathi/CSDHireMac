using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using MaxVonGrafKftMobile.iOS;
using MaxVonGrafKftMobile.Renders;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessDatePicker), typeof(BorderlessDatePickerRenderer))]

namespace MaxVonGrafKftMobile.iOS
{
    public class BorderlessDatePickerRenderer : DatePickerRenderer
    {
        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs <DatePicker> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                 Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;

            var element = e.NewElement as BorderlessDatePicker;
            if (!string.IsNullOrWhiteSpace(element.Placeholder))
            {
                Control.Text = element.Placeholder;
            }

            Control.ShouldEndEditing += (textField) => {
                var seletedDate = (UITextField)textField;
                var text = seletedDate.Text;
                if (text == element.Placeholder)
                {
                    Control.Text = DateTime.Now.ToString("dd/MM/yyyy");
                }
                return true;
            };

            }
           
        }
    }
}