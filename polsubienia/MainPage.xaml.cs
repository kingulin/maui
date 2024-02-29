namespace test;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void DeleteF(object sender, EventArgs e)
	{

		if (count == 0)
			likeText.Text = $" {count} polubien";
		else
			count--;
            likeText.Text = $" {count} polubien";

	}
    private void LIkeF(object sender, EventArgs e)
    {
		count++;
        likeText.Text = $" {count} polubien";

    }
   
}

