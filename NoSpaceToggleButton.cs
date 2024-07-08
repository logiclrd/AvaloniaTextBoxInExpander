using System;
using System.Diagnostics;

using Avalonia.Controls.Primitives;
using Avalonia.Input;

namespace TestTextBoxInExpander;

public class NoSpaceToggleButton : ToggleButton
{
	protected override Type StyleKeyOverride => typeof(ToggleButton);

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e.Key != Key.Space)
			base.OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		if (e.Key != Key.Space)
			base.OnKeyUp(e);
	}
}
