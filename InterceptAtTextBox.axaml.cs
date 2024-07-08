using Avalonia.Controls;
using Avalonia.Input;

namespace TestTextBoxInExpander;

public partial class InterceptAtTextBox : Window
{
	public InterceptAtTextBox()
	{
		InitializeComponent();
	}

	void txtInsideHeader_KeyDown(object? sender, KeyEventArgs e)
	{
		if (e.Key == Key.Space)
		{
			e.Handled = true;
			txtInsideHeader.SelectedText = " ";
		}
	}

	void txtInsideHeader_KeyUp(object? sender, KeyEventArgs e)
	{
		if (e.Key == Key.Space)
			e.Handled = true;
	}
}