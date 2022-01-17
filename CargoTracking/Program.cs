using CargoTrackingApp.Business.Abstract;
using CargoTrackingApp.Business.Concrete;
using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoTrackingApp
{
    static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
