using System.Collections.ObjectModel;

namespace BugTest;

public partial class MainPage : ContentPage
{
	ObservableCollection<string> _list1;
	ObservableCollection<string> _list2;

	public MainPage()
	{
		InitializeComponent();

		this._list1 = [
			"Item 1",
			"Item 2",
			"Item 3",
			"Item 4",
			"Item 5"
		];

		this._list2 = [
			"Item 1",
			"Item 2",
			"Item 3",
			"Item 4",
			"Item 5"
		];

		this.cboList1.ItemsSource = this._list1;
		this.cboList2.ItemsSource = this._list2;
	}

	private void txtLog_TextChanged(object? sender, EventArgs e)
	{
		// Task.Delay(500).ContinueWith((task) =>
		// {
		// 	MainThread.InvokeOnMainThreadAsync(() =>
		// 	{
		// 		this.txtLog.CursorPosition = this.txtLog.Text.Length;

		// 	});
		// });
	}

	private void btnTest_Clicked(object? sender, EventArgs e)
	{
		this.txtLog.Text += "btnTest_Clicked()" + Environment.NewLine;
	}

	private void btnTest_Focused(object? sender, FocusEventArgs e)
	{
		this.txtLog.Text += "btnTest_Focused()" + Environment.NewLine;
	}

	private void btnTest_Unfocused(object? sender, EventArgs e)
	{
		this.txtLog.Text += "btnTest_Unfocused()" + Environment.NewLine;
	}

	private void cboList1_Focused(object? sender, FocusEventArgs e)
	{
		this.txtLog.Text += "cboList1_Focused()" + Environment.NewLine;
	}

	private void cboList1_Unfocused(object? sender, EventArgs e)
	{
		this.txtLog.Text += "cboList1_Unfocused()" + Environment.NewLine;
	}

	private void cboList1_DropDownClosing(object? sender, EventArgs e)
	{
		this.txtLog.Text += "cboList1_DropdownClosing()" + Environment.NewLine;
	}

	private void cboList1_DropDownClosed(object? sender, EventArgs e)
	{
		this.txtLog.Text += "cboList1_DropdownClosed()" + Environment.NewLine;
	}

	private void cboList2_Focused(object? sender, FocusEventArgs e)
	{
		this.txtLog.Text += "cboList2_Focused()" + Environment.NewLine;
	}

	private void cboList2_Unfocused(object? sender, EventArgs e)
	{
		this.txtLog.Text += "cboList2_Unfocused()" + Environment.NewLine;
	}

	private void cboList2_DropDownClosing(object? sender, EventArgs e)
	{
		this.txtLog.Text += "cboList2_DropdownClosing()" + Environment.NewLine;
	}

	private void cboList2_DropDownClosed(object? sender, EventArgs e)
	{
		this.txtLog.Text += "cboList2_DropdownClosed()" + Environment.NewLine;
	}
}

