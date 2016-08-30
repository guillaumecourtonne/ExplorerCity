using Xamarin.Forms;

namespace ExplorerCity
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var navPage =
					new NavigationPage(
						new CitiesPage()
						{

							Title = "Liste des villes",
							BindingContext = new CitiesViewModel()
						})
					{
						BarBackgroundColor = Color.FromHex("43547f"),
						BarTextColor = Color.White
					};

			MainPage = navPage;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

