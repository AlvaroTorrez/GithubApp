using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GithubMobileApp.Componets.Controls;
using GithubMobileApp.Droid.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]
namespace GithubMobileApp.Droid.CustomRenderer
{
    public class MyLabelRenderer : LabelRenderer
    {
        public MyLabelRenderer(Context context) : base(context) {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}