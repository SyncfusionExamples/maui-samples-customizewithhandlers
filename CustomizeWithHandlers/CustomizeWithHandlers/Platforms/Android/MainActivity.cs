using Android.App;
using Android.Content.PM;
using Microsoft.Maui;

namespace CustomizeWithHandlers
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
	public class MainActivity : MauiAppCompatActivity
	{
		public MainActivity()
        {
            Microsoft.Maui.Handlers.ButtonHandler.ButtonMapper[nameof(IView.Background)] = (h, v) =>
            {
                (h.NativeView as Android.Views.View).SetBackgroundColor(Microsoft.Maui.Graphics.Colors.Blue.ToNative());
            };
        }
	}
}