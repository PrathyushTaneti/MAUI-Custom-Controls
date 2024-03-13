namespace CustomControls
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                string username = this.Username.Text;
                string password = this.Password.Text;
                string displayText = "Logging In";
                SemanticScreenReader.Default.Announce(displayText);
                string result = await DisplayPromptAsync("Question 1", "What's your name?");
                await DisplayAlert($"{username}", $"{password}", "Okay");
                string resultUtil = (result.Length > 0) ? result : "Empty Input";
                await DisplayAlert($"{resultUtil}", $"{resultUtil}", "Okay");
            }
            catch (Exception ex)
            {
                await DisplayAlert($"{ex.Message}", $"{ex.StackTrace}", "Okay");
            }
        }
    }

}
