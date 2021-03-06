using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrayIconBuster {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			try {
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			} catch(Exception exc) {
				MessageBox.Show(exc.ToString(), "Fatal Error in LP#TrayIconBuster");
			}
		}
	}
}