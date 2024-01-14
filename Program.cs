using System;
using System.Windows.Forms;

namespace Hello_World
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show(@"Hello World !", @"by amn...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}