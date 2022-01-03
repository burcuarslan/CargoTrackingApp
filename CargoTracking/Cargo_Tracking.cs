
using CargoTrackingApp.Business.Abstract;
using CargoTrackingApp.Business.Concrete;
using CargoTrackingApp.DataAccess.Abstract;
using CargoTrackingApp.DataAccess.Concrete;
using CargoTrackingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CargoTracking;

namespace CargoTrackingApp
{
    public partial class Form1 : Form
    {
        CargoTrackingManager manager;
       // ICargoTrackingService _trackingService;


        public Form1()
        {
            InitializeComponent();
           // _trackingService = trackingService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager = new CargoTrackingManager(new InMemoryCargoTracking());
            int _id = Convert.ToInt32(textBox1.Text);
            foreach (var cargo in manager.GetById(_id))
            {
                MessageBox.Show(cargo.CargoStatus);
            }
            InMemoryCargoTracking inMemory = new InMemoryCargoTracking();

            foreach (var item in inMemory.jsonParts)
            {
                MessageBox.Show(item);
            }
            

        }

        private void employee_Click(object sender, EventArgs e)
        {
            (new Employee()).Show();
            
        }
    }
}
