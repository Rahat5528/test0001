using System;
using System.Runtime.InteropServices;

public class Envіrоnmеnt
{
	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

	public static void Exit(int n)
	{
		MessageBox(IntPtr.Zero, "Test " + n.ToString(), "Title", 0);
	}
}
