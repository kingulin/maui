namespace slider;

public partial class MainPage : ContentPage
{
    int count = 0;
    List<string> list = new List<string>();
    public MainPage()
    {
        InitializeComponent();
        list.Add("Dzien dobry");
        list.Add("Good Morning");
        list.Add("Guten morgen");
    }

    private void sliderChange(object sender, EventArgs e)
    {
        toChnage.FontSize = slider.Value;
        sizer.Text = "Rozmier: " + (int)slider.Value;
    }

    private void listNames(object sender, EventArgs e)
    {
        count++;

        if (count == list.Count())
        {
            count = 0;

        }

        toChnage.Text = list[count];
    }
}

