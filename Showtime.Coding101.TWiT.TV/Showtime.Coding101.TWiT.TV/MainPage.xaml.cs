namespace Showtime.Coding101.TWiT.TV
{
	using Windows.UI.Xaml.Controls;
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			DataContext = new MainViewModel();
			episodeStack.ItemsSource = ((MainViewModel)DataContext).Episodes; //Setting the Context for the main page and pointing it to the ViewModel
        }
    }
}
