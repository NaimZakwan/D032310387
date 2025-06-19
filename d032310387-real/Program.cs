using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // 👈 This is required for Windows Forms

namespace d032310387_real
{
    internal class Program
    {
        [STAThread]  // 👈 This is also required for WinForms
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthor());  // 👈 Your main form
        }
    }
}
