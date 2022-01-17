using CargoTracking.Business.Concrete;
using CargoTracking.DataAccess.Concrete;
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
    public partial class Login : Form
    {
        EmployeeManager manager;
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==null&&textBox2.Text==null)
            {
                MessageBox.Show("lütfen tüm alanları doldurun!");
            }
            else
            {
                manager = new EmployeeManager(new EmployeeDal());

                if (manager.CheckEmployee(textBox1.Text, textBox2.Text))
                {
                    (new EmployeeForm()).Show();
                }
                else
                {
                    MessageBox.Show("giriş bilgileri yanlış");
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
