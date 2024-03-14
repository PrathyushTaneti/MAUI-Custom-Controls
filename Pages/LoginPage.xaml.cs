namespace CustomControls.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await AppShell.Current.GoToAsync("//MainPage");
    }
}