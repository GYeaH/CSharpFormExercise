using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a5_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        ArrayList infoList = new ArrayList();


        public Form()
        {
            InitializeComponent();
        }

        //return to form when click summary label
        private void summaryLabel_Click(object sender, EventArgs e)
        {
            summaryLabel.Hide();
        }

        private string FlightInfoString(string id, string origin, string destination, string date, string time)
        {
            string info;

            info = "Flight ID: " + id + Environment.NewLine
                + "Origin: " + origin + Environment.NewLine
                + "Destination: " + destination + Environment.NewLine
                + "Date: " + date + Environment.NewLine
                + "Time: " + time + Environment.NewLine
                + "-------------------------------------------" + Environment.NewLine;

            return info;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            summaryLabel.SetBounds(0,0,this.Width,this.Height);

            summaryLabel.Show();
            summaryLabel.Text = "";

            //get all input infomation
            string id = this.idTextBox.Text;
            string origin = this.originTextBox.Text;
            string destination = this.destinationTextBox.Text;
            string date = this.dateTextBox.Text;
            string time = this.timeTextBox.Text;

            
            //add user input information to arraylist
            infoList.Add(FlightInfoString(id, origin, destination, date, time));

            //load all informations to summary label
            foreach (string info in infoList)
                summaryLabel.Text += info;

        }

        private void Form_Load(object sender, EventArgs e)
        {
            summaryLabel.BackColor = Color.AliceBlue;
            summaryLabel.Hide();
        }
    }
}
