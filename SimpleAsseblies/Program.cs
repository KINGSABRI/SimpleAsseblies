using System;
using System.Windows.Forms;

namespace TheMessageBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Just a title";
            string message = "Just a message";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("You said YES!");
            }
            else
            {
                Console.WriteLine("You said No :(");
            }

        }
    }
}
