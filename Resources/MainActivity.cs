﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "Sierra Kilo Lima", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
           
        



            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
           
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

