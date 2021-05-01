using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_BookClassinWindows
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void txtAuthorFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.AddressLine1 = txtAddLine1.Text;
            temp.AddressLine2 = txtAddLine2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.ZipCode = txtZip.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            
            if(temp.ValidResponse == false)
            {
                txtFName.Text = temp.FName;
                txtMName.Text = temp.MName;
                txtLName.Text = temp.LName;
                txtAddLine1.Text = temp.AddressLine1;
                txtAddLine2.Text = temp.AddressLine2;
                txtCity.Text = temp.City;
                txtState.Text = temp.State;
                txtZip.Text = temp.ZipCode;
                txtPhone.Text = temp.Phone;
                txtEmail.Text = temp.Email;
            }
            
            else
            {
                lblResults.Text = $"{temp.FName}! Let's just double check that this information is correct.\n\nFirst Name: {temp.FName}\nMiddle Name: {temp.MName}\nLast Name: {temp.LName}\nAddress Line 1: {temp.AddressLine1}\nAddress Line 2: {temp.AddressLine2}\nCity: {temp.City}\nState: {temp.State}\nZip Code: {temp.ZipCode}\nPhone: {temp.Phone}\nEmail: {temp.Email}";
            }
        }

        private void btnClrScrn_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            txtAddLine1.Text = "";
            txtAddLine2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            lblResults.Text = "N/A";
        }
    }
}
