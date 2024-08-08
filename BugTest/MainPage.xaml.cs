
using Syncfusion.Maui.Inputs;

namespace BugTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void txtLog_TextChanged(object? sender, EventArgs e)
	{
		this.txtLog.CursorPosition = this.txtLog.Text.Length;
	}

	private void btnTest_Clicked(object? sender, EventArgs e)
	{
		this.txtLog.Text += "btnTest_Clicked()" + Environment.NewLine;
		this.txtLog.Text += "numTest1 Value: " + this.numTest1.Value + Environment.NewLine;
		this.txtLog.Text += "numTest2 Value: " + this.numTest2.Value + Environment.NewLine;
	}

	private void btnTest_Focused(object? sender, FocusEventArgs e)
	{
		this.txtLog.Text += "btnTest_Focused()" + Environment.NewLine;
	}

	private void btnTest_Unfocused(object? sender, EventArgs e)
	{
		this.txtLog.Text += "btnTest_Unfocused()" + Environment.NewLine;
	}

	private void numTest1_Focused(object? sender, FocusEventArgs e)
	{
		this.txtLog.Text += "numTest1_Focused()" + Environment.NewLine;
	}

	private void numTest1_Unfocused(object? sender, EventArgs e)
	{
		this.txtLog.Text += "numTest1_Unfocused()" + Environment.NewLine;
	}

	private void numTest1_ValueChanged(object? sender, NumericEntryValueChangedEventArgs e)
	{
		this.txtLog.Text += "numTest1_ValueChanged() - Value: " + e.NewValue + Environment.NewLine;
	}

	private void numTest2_Focused(object? sender, FocusEventArgs e)
	{
		this.txtLog.Text += "numTest2_Focused()" + Environment.NewLine;
	}

	private void numTest2_Unfocused(object? sender, EventArgs e)
	{
		this.txtLog.Text += "numTest2_Unfocused()" + Environment.NewLine;
	}

	private void numTest2_ValueChanged(object? sender, NumericEntryValueChangedEventArgs e)
	{
		this.txtLog.Text += "numTest2_ValueChanged() - Value: " + e.NewValue + Environment.NewLine;
	}
}
