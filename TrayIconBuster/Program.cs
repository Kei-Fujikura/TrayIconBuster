using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace TrayIconBuster {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			string mutexName = "TrayIconBuster";
			bool createdNew = false;
			var mutex = new Mutex(true, mutexName, out createdNew);
			if (createdNew)
			{
				try
				{
					if (createdNew) Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new Form1());
				}
				finally
				{
					mutex.ReleaseMutex();
					mutex.Close();
				}
			}
		}
	}
}