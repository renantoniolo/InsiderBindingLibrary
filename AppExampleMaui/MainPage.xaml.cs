using Com.Useinsider.Insider;
namespace AppExampleMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		
		InitializeComponent();
        //Insider.Instance.Init((Android.App.Application?)Android.App.Application.Context.ApplicationContext, "caaqui");

		if (Insider.Instance.IsSDKInitialized)
		{
			Insider.Instance.SetPushToken("teste");
        }
		else
		{
            CounterBtn.Text = $"SDK Insider não iniciou.";
        }
		
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


