namespace MediaElementFileSystemIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(VM vm)
	{
		InitializeComponent();

        BindingContext = vm;

        mediaElement.MediaFailed += MediaElement_MediaFailed;
	}

    private void MediaElement_MediaFailed(object sender, CommunityToolkit.Maui.Core.Primitives.MediaFailedEventArgs e)
    {
        //throws SourceNotSupported using MVVM binding
    }
}

