using System;
using System.Windows.Forms;

namespace MessageBoxWithArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("MessageBoxWithArgs.exe <TITLE> <MESSAGE> <CMDEXEC>");
                return;
            }

            if (args.Length >= 3)
            {
                string command = args[2];
                System.Diagnostics.Process.Start(command);
            } 

            string title   = args[0];
            string message = args[1];
            DialogResult result = MessageBox.Show(message, title);

        }
    }
}
