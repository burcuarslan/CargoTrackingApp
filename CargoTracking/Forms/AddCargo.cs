using CargoTrackingApp;
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
    public partial class AddCargo :Form
    {
        CargoTrackingManager manager;
        public AddCargo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager = new CargoTrackingManager(new CargoTrackingDal());
            if (SenderName.Text == "" && SenderSurname.Text == "" && SenderPhoneNumber.Text == "" && SenderEmail.Text == "" && SenderAddress.Text == "" && ReceiverName.Text == "" && ReceiverSurname.Text == "" && ReceiverPhoneNumber.Text == "" && ReceiverAddress.Text == "" && CargoTrackingId.Text == "" && CargoStatus.Text == "" && CargoWeight.Text == "" && CargoCost.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                Tracking newCargo = new Tracking(SenderName.Text, SenderSurname.Text, SenderPhoneNumber.Text, SenderEmail.Text, SenderAddress.Text, ReceiverName.Text, ReceiverSurname.Text, ReceiverPhoneNumber.Text, ReceiverAddress.Text, Convert.ToInt32(CargoTrackingId.Text), CargoStatus.Text, Convert.ToInt32(CargoWeight.Text), Convert.ToInt32(CargoCost.Text));

                manager.Add(newCargo);
                MessageBox.Show("Kargo başarıyla eklendi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
