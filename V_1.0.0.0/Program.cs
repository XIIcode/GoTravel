using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        // Events_Planning
        //Go_travelDashboard
        //final_menu
        //jungle_birdfrm
        //media_playerfrm
        //medical_frm
        //settings
        //location_finderfrm
        //Login_form
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_form());
        }
    }
}
