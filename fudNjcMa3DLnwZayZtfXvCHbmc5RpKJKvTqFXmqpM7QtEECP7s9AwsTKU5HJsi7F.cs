using System;
using System.Runtime.InteropServices;

public class Envlronment
{
	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

	public static void Exit(int n)
	{
		var args = Environment.GetCommandLineArgs();
		MessageBox(IntPtr.Zero, "ARGS:\n- " + string.Join("\n- ", args), "TEST", 0);
	}
}
