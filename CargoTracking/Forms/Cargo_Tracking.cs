
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager = new CargoTrackingManager(new CargoTrackingDal());
            int _id = Convert.ToInt32(textBox1.Text);
            
            if (manager.GetById(_id)==null)
            {
                MessageBox.Show("Takip numarası yanlış");
            }
            else
            {
                foreach (var cargo in manager.GetById(_id))
                {
                    MessageBox.Show("Gönderen: " + cargo.SenderName + " " + cargo.SenderSurName + '\n' + "Gönderen Adres: "
                        + cargo.SenderAddress + '\n' + "Alıcı: " + cargo.ReceiverName + " " + cargo.ReceiverSurname + '\n' + "Alıcı Adres: "
                        + cargo.ReceiverAddress + '\n' + "Cargo Durum: " + cargo.CargoStatus);
                }
            }
            
        }

        private void employee_Click(object sender, EventArgs e)
        {
            (new Login()).Show();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
