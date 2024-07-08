using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TestTextBoxInExpander;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	void cmdExpanderTemplate_Click(object? sender, RoutedEventArgs e)
	{
		new ExpanderTemplate().Show();
	}

	void cmdInterceptAtTextBox_Click(object? sender, RoutedEventArgs e)
	{
		new InterceptAtTextBox().Show();
	}

	void cmdInterceptAtTextBoxWithBehaviour_Click(object? sender, RoutedEventArgs e)
	{
		new InterceptAtTextBoxWithBehaviour().Show();
	}
}
