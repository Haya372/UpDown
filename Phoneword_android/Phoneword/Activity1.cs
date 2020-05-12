using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;

namespace Phoneword
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        TextView text1;
        Task _timer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);

            text1 = FindViewById<EditText>(Resource.Id.textView1);
        }
    }
}