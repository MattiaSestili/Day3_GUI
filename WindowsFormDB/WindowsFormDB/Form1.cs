using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormDB
{
    public partial class Form1 : Form
    {
        List<Customer> listCustomers = new List<Customer>();
        int customerListIndex = 0;
        
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ClientEntities myEntities = new ClientEntities())
            {
                var customers = from c in myEntities.Customers
                                select c;
                listCustomers = customers.ToList();
            }
            DisplayCustomer(customerListIndex);

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void DisplayCustomer(int customerId)
        {
            if (listCustomers[customerId] != null)
            {
                textBoxName.Text = listCustomers[customerId].Name;
                textBoxAddress.Text = listCustomers[customerId].Address;
                textBoxCity.Text = listCustomers[customerId].City;
                textBoxPostCode.Text = listCustomers[customerId].PostCode;
                textBoxPhone.Text = listCustomers[customerId].PhoneNumber;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerListIndex++;

            if(customerListIndex >= listCustomers.Count)
            {
                customerListIndex = 0;
            }
            DisplayCustomer(customerListIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //previous record button
            //decrement customer id
            customerListIndex--;
            //if you have reached the beginning of the list
            //go to the end
            if (customerListIndex < 0)
            {
                customerListIndex = listCustomers.Count -1;
            }
            DisplayCustomer(customerListIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (ClientEntities myEntities = new ClientEntities())
            {
                Customer addCustomer = new Customer();

                addCustomer.Name = textBoxName.Text;
                addCustomer.Address = textBoxAddress.Text;
                addCustomer.City = textBoxCity.Text;
                addCustomer.PostCode = textBoxPostCode.Text;
                addCustomer.PhoneNumber = textBoxPhone.Text;
                                               
                myEntities.Customers.Add(addCustomer);
                myEntities.SaveChanges();
                listCustomers.Add(addCustomer);
            }
        }
    }
}
