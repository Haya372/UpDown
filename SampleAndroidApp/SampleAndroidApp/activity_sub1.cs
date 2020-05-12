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

//移動先のページ
//時間を表示(hh:mm:ss)
namespace SampleAndroidApp
{
    [Activity(Label = "activity_sub1")]
    public class activity_sub1 : Activity
    {
        Task _timer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout_sub1);

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

            Button translateButton = FindViewById<Button>(Resource.Id.button1);
            translateButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}