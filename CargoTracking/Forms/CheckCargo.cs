using CargoTrackingApp.Business.Concrete;
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

namespace CargoTracking
{
    public partial class CheckCargo : Form
    {
        CargoTrackingManager manager;
        public CheckCargo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==null)
            {
                MessageBox.Show("lütfen tüm alanları doldurun!");
            }
            else
            {
                manager = new CargoTrackingManager(new CargoTrackingDal());
                int _id = Convert.ToInt32(textBox1.Text);
                List<Tracking> tracking = manager.GetById(_id);
                (new CargoUpdate(tracking)).Show();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
