using ParciC1;
using System;
using System.Windows.Forms;

namespace ParciC1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Abre el MenuForm al iniciar
            Application.Run(new MenuForm());
        }
    }
}