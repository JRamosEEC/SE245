using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week4_BookClassinWindows;

namespace Ramos_BookClassWinInterace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book temp = new Book();
            temp.Feedback = "";

            temp.Title = txtTitle.Text;

            double tPrice = 0;
            if (double.TryParse(txtPrice.Text, out tPrice) == true)
            {
                temp.Price = tPrice;
            }
            else
            {
                temp.Feedback += "ERROR: Price is not properly formatted. EX: 5.98";
            }

            temp.DatePublished = dtpDatePublished.Value;
       
            if(temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = "Book Added: " + temp.Title + "($ " + temp.Price.ToString() + ") - Published: " + temp.DatePublished.ToString();
            }
        }
    }
}
