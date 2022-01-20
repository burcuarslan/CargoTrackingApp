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
    public partial class CargoUpdate : Form
    {
        CargoTrackingManager manager;
        List<Tracking> _tracking;
        public CargoUpdate(List<Tracking> tracking)
        {
            _tracking = tracking;
            InitializeComponent();
           
        }

        private void CargoUpdate_Load(object sender, EventArgs e)
        {

            foreach (var cargo in _tracking)
            {
                SenderName.Text = cargo.SenderName;
                SenderSurname.Text = cargo.SenderSurName;
                SenderEmail.Text = cargo.SenderEmail;
                SenderPhoneNumber.Text = cargo.SenderPhoneNumber;
                SenderAddress.Text = cargo.SenderAddress;
                ReceiverName.Text = cargo.ReceiverName;
                ReceiverSurname.Text=cargo.ReceiverSurname;
                ReceiverPhoneNumber.Text=cargo.ReceiverPhoneNumber;
                ReceiverAddress.Text=cargo.ReceiverAddress;
                CargoTrackingId.Text = Convert.ToString(cargo.CargoTrackingId);
                CargoStatus.Text = cargo.CargoStatus;
                CargoWeight.Text = Convert.ToString(cargo.CargoWeight);
                CargoCost.Text = Convert.ToString(cargo.CargoCost);

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SenderName.Text == "" && SenderSurname.Text == "" && SenderPhoneNumber.Text == "" && SenderEmail.Text == "" && SenderAddress.Text == "" && ReceiverName.Text == "" && ReceiverSurname.Text == "" && ReceiverPhoneNumber.Text == "" && ReceiverAddress.Text == "" && CargoTrackingId.Text == "" && CargoStatus.Text == "" && CargoWeight.Text == "" && CargoCost.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
            else
            {
                manager = new CargoTrackingManager(new CargoTrackingDal());
                Tracking newCargo = new Tracking(SenderName.Text, SenderSurname.Text, SenderPhoneNumber.Text, SenderEmail.Text, SenderAddress.Text,
                    ReceiverName.Text, ReceiverSurname.Text, ReceiverPhoneNumber.Text, ReceiverAddress.Text, Convert.ToInt32(CargoTrackingId.Text),
                    CargoStatus.Text, Convert.ToInt32(CargoWeight.Text), Convert.ToInt32(CargoCost.Text));
                manager.Update(newCargo);
                MessageBox.Show("Başarıyla güncellendi");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
