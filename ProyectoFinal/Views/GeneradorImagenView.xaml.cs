using System.Diagnostics;

namespace ProyectoFinal.Views;

public partial class GeneradorImagenView : ContentPage
{
    Stopwatch watch = new Stopwatch();

	public GeneradorImagenView()
	{
		InitializeComponent();
	}


    protected override async void OnAppearing()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        watch.Start();

        var cts = new CancellationTokenSource();

        using (var timer = new PeriodicTimer(TimeSpan.FromSeconds(1)))
        {
            try
            {
                var counter = 0;
                while (await timer.WaitForNextTickAsync(cts.Token))
                {
                    if(counter == 5)
                        cts.Cancel();

                    var seconds = watch.Elapsed.TotalSeconds;

                    lblTimer.Text = seconds.ToString();
                    counter++;
                }
            }
            catch(TaskCanceledException)
            {
                await StopGeneration();
            }
        }
    }

    private async Task StopGeneration()
	{
        watch.Stop();
		await Task.Delay(2000);

		lottie.IsAnimationEnabled = false;
		lottie.IsVisible = false;
        imageBorder.IsVisible = true;
        imageAnimation.IsVisible = true;


        imageBorder.IsVisible = true;

		await Task.WhenAny(
            imageAnimation.ScaleTo(1.1, 1000),
            imageAnimation.FadeTo(0, 1000),
            borderTime.ScaleTo(1.1, 1000),
            borderTime.FadeTo(1, 1000)
            );

        await borderTime.FadeTo(0, 300);
        await btnFinish.ScaleTo(1, 300);
    }

    private async void btnFinish_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardView());
    }
}