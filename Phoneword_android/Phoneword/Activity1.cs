using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using System.Threading.Tasks;

namespace Phoneword
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        Task _timer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout1);

            TextView text1 = FindViewById<TextView>(Resource.Id.time);
            _timer = new Task(async () =>
            {                                   // ⑤
                while (true) // ⑥
                {
                    RunOnUiThread(() =>
                    {                           // ⑦
                        text1.Text = DateTime.Now.ToString("HH:mm:ss"); // ⑧
                    });
                    await Task.Delay(1000);     // ⑨
                }
            });
            _timer.Start();
        }
    }
}