/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Class: App
 * Date: 2013-12-05
 * Version: 1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale
{
    static class App
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }
    }
}
