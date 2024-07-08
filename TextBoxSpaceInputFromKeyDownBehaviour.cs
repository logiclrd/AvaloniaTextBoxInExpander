using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Xaml.Interactivity;

namespace TestTextBoxInExpander;

public class TextBoxSpaceInputFromKeyDownBehaviour : Behavior<TextBox>
{
	protected override void OnAttachedToVisualTree()
	{
		AssociatedObject?.AddHandler(TextBox.KeyDownEvent, AssociatedObject_KeyDown, RoutingStrategies.Bubble);
		AssociatedObject?.AddHandler(TextBox.KeyUpEvent, AssociatedObject_KeyUp, RoutingStrategies.Bubble);
	}

	protected override void OnDetachedFromVisualTree()
	{
		AssociatedObject?.RemoveHandler(TextBox.KeyDownEvent, AssociatedObject_KeyDown);
		AssociatedObject?.RemoveHandler(TextBox.KeyUpEvent, AssociatedObject_KeyUp);
	}

	void AssociatedObject_KeyDown(object? sender, KeyEventArgs e)
	{
		if (e.Key == Key.Space)
		{
			e.Handled = true;
			AssociatedObject!.SelectedText = " ";
		}
	}

	void AssociatedObject_KeyUp(object? sender, KeyEventArgs e)
	{
		if (e.Key == Key.Space)
			e.Handled = true;
	}
}
