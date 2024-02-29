using System.Collections.ObjectModel;

namespace lista;

public partial class MainPage : ContentPage
{
	int count = 0;
	//List<string> list = new List<string>();
	ObservableCollection<string> obCollection = new ObservableCollection<string>();
	public MainPage()
	{
		InitializeComponent();
        obCollection.Add("zjesc");
        obCollection.Add("grac");
        //	list.Add("spac");
        	obCollection.Add("spac");
        listView.ItemsSource = obCollection;
	}

	private void AddToList(object sender, EventArgs e)
    {
        obCollection.Add(new_entry.Text);
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
	}
}

