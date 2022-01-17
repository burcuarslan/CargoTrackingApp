using CargoTrackingApp.Business.Concrete;
using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoTracking
{
    public partial class EmployeeForm : Form
    {
        //CargoTrackingManager manager;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //manager = new CargoTrackingManager(new InMemoryCargoTracking());
            (new AddCargo()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new DeleteCargo()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new CheckCargo()).Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
