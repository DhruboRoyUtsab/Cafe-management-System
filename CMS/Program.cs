using CMS.Admin;
using CMS.Assets;
using CMS.Cashier;
using CMS.Waiter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AdminSignIn());
            Application.Run(new Payment());
            //Application.Run(new Waiter());
            //Application.Run(new Chef());
            //Application.Run(new Homepage());
            Application.Run(new Order());


            //Application.Run(new WaiterSignIn());
        }
    }
}
