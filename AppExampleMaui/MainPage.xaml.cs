using Com.Useinsider.Insider;
namespace AppExampleMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		try
		{
			InitializeComponent();
			/*
			// initialize sdk insider in MAUI framework
			Insider.Instance.Init((Android.App.Application?)Android.App.Application.Context.ApplicationContext, "caaqui");

			// check SDK insider is Initialized
			if (Insider.Instance.IsSDKInitialized)
			{
				Insider.Instance.SetPushToken("test push token");
			}
			else
			{
				CounterBtn.Text = $"SDK Insider SDK not started.";
			}
			*/
		} catch (Exception ex) {
            CounterBtn.Text = ex.Message;
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


