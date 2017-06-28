using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;

namespace CodeReader
{
    [Activity(Label = "Code Reader", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {            
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            //Toolbar will now take on default actionbar characteristics
            SetActionBar(toolbar);

            ActionBar.Title = "Code Reader";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var intent = new Intent(this, typeof(ServerConfiguration));
            StartActivity(intent);


            return base.OnOptionsItemSelected(item);
        }
    }
}

