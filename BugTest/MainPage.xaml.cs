using System.Collections.ObjectModel;
using System.Diagnostics;
using Syncfusion.Maui.ListView;

namespace BugTest;

public partial class MainPage : ContentPage
{
	private readonly ObservableCollection<ListItem> _listItems = [];

	private int _logCount = 0;

	public MainPage()
	{
		InitializeComponent();

		this.lstBugTest.ItemsSource = this._listItems;

		this._listItems.Add(new ListItem("Item 1"));
		this._listItems.Add(new ListItem("Item 2"));
		this._listItems.Add(new ListItem("Item 3"));
		this._listItems.Add(new ListItem("Item 4"));
		this._listItems.Add(new ListItem("Item 5"));
	}

	private void lstBugTest_SelectionChanged(object? sender, ItemSelectionChangedEventArgs e)
	{
		Debug.WriteLine("lstBugTest_SelectionChanged()");

		this._logCount++;

		this.txtBugTest.Text
			= this._logCount + ": lstBugTest_SelectionChanged()" + Environment.NewLine
			+ this.txtBugTest.Text;
	}

	private void lstBugTest_SelectionChanging(object? sender, ItemSelectionChangingEventArgs e)
	{
		Debug.WriteLine("lstBugTest_SelectionChanging()");

		this._logCount++;

		this.txtBugTest.Text
			= this._logCount + ": lstBugTest_SelectionChanging()" + Environment.NewLine
			+ this.txtBugTest.Text;
	}
}

