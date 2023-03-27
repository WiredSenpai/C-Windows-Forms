using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac2_Windows_Forms_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Usinf labels to Dispay data, as you would in the Console


            label3.Text = "";
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
            label2.Text = "My Student Number is: ";
            label4.Text = "My Surname is: ";
            label6.Text = "My Name is";
            label8.Text = "I study: ";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //This button collects data from the user and displays it on the Screen

            // 1. Getting the Data from Each TextBox
           string idNumber = txtNumber.Text;
            string stName = txtName.Text;
            string stSurname = txtSurname.Text;
            string stCourse = txtStudy.Text;

            //2. Displaying the data by asigning it to The labels

            label3.Text = idNumber;
            label5.Text = stSurname;
            label7.Text = stName;
            label9.Text = stCourse;

        }

       
    }
}
