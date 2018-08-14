/*Zachary Miller
 * 12/20/2017
 * assignment 7.2
 * The purpose of this program is display message boxes asking if you want internet or not and if you want unlimited or limited internet and then displays your final price
 * InternetAccess.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7._2
{
    static class InternetAccess
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MessageBox());
        }
    }
}
