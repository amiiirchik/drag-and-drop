namespace MauiApp5;

public partial class MainPage : ContentPage
{ 
	Dictionary<string, VerticalStackLayout> _data = new Dictionary<string, VerticalStackLayout>();
	public MainPage()
	{
		InitializeComponent();
		_data.Add("firstVSL", FirstVSL);
		_data.Add("secondVSL", SecondVSL);
		_data.Add("thirdVSL", ThirdVSL);
	}

	private void DragStarting(object sender, DragStartingEventArgs e)
	{
		var frame = (sender as DragGestureRecognizer).Parent as Frame;
		e.Data.Properties.Add("frame", frame);
    }

    private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
    {
        Frame data = e.Data.Properties["frame"] as Frame;
        (data.Parent as VerticalStackLayout).Remove(data);
        ((sender as DropGestureRecognizer).Parent as VerticalStackLayout).Add(data);
	}
}

