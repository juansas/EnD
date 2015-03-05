using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
	

		int valor1, valor2;


		valor1 = Convert.ToInt32(entryNum1.Text);
		valor2 = Convert.ToInt32(entry2.Text);

	
		label1.Text = (valor1 + valor2).ToString();
	}
}
