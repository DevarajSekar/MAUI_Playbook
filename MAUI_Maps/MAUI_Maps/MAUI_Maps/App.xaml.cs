namespace MAUI_Maps;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();// new AppShell();
	}
}
