namespace MauiApp7;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
	{
		if (e.Data.Properties.Count == 0)
		{
            e.Data.Properties.Add("qwe", (sender as DragGestureRecognizer).Parent);
        }
	}

	private void DragGestureRecognizer_DropCompleted(object sender, DropCompletedEventArgs e)
	{

	}

	private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
	{

		BoxView c= e.Data.Properties["qwe"] as BoxView;
		(c.Parent as VerticalStackLayout).Clear();
		((sender as DropGestureRecognizer).Parent as VerticalStackLayout).Add(c);

    }

	private void DropGestureRecognizer_DragOver(object sender, DragEventArgs e)
	{

	}

	private void DropGestureRecognizer_DragLeave(object sender, DragEventArgs e)
	{

	}
}

