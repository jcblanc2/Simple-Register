using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Cours: C#
/// Name: John Clayton Blanc
/// Date: 30 sep 2022
/// Universite Espoir
/// </summary>

namespace Etudiants
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEtudiants());
        }
    }
}
