using System;

using System.Collections.Generic;

using System.Text;

using System.Windows.Forms;

using System.Drawing;

namespace ConsoleWindowsForm

{

    class Program

    {

        //Here we define a derived class of Windows Form

        class MyForm : System.Windows.Forms.Form

        {

            //Here we declare an object of type Label
            Label infoLabel;

            //This is the default constructor
            public MyForm()

            {

                this.Text = "Windows Form";

                //set the size, location and background color of main window
                this.Size = new Size(500, 300);
                this.Location = new Point(0, 0);
                this.BackColor = Color.Aqua;


                //Here we specify that the event handler for cases in which the form is clicked
                //is Form_Click() method
                this.Click += new System.EventHandler(this.Form_Click);

                this.MouseDoubleClick += new MouseEventHandler(this.Form_MouseDoubleClick);


                //Here we initialize infoLabel component by defining its size, location and text.
                infoLabel = new Label();

                //Here we specify that the size of the label is automathic and should
                //change according to its content.
                this.infoLabel.AutoSize = true;

                this.infoLabel.Location = new System.Drawing.Point(20, 20);
                this.infoLabel.Size = new System.Drawing.Size(35, 13);
                this.infoLabel.Text = "";

                //Here we add the label to the form.
                this.Controls.Add(infoLabel);
            }

            //Here we define Form_Click event handler
            private void Form_Click(object sender, EventArgs e)
            {

                //In the following we check the background color of the form
                //and change it accordingly. 
                if (this.BackColor == Color.Aqua)
                {
                    this.BackColor = Color.SteelBlue;
                    //Here we call DisplayData() method to display the data.
                    DisplayData();
                }
                else
                {
                    //Here we change the background color of the form.
                    this.BackColor = Color.Aqua;

                    //Here we delete the text of the label by initializing the text value to empty.
                    infoLabel.Text = "";

                }
            }


            //This method sets the text content of the lable
            public void DisplayData()
            {

                //Here we set the text color of the label.
                infoLabel.ForeColor = Color.Violet;

                //In the following rows we update the text content of the label.
                infoLabel.Text += "CommonAppDataPath: " + Environment.NewLine + Application.CommonAppDataPath + Environment.NewLine;
                infoLabel.Text += "--------------------" + Environment.NewLine;

                infoLabel.Text += "ExecutablePath: " + Environment.NewLine + Application.ExecutablePath + Environment.NewLine;
                infoLabel.Text += "--------------------" + Environment.NewLine;

                infoLabel.Text += "LocalUserAppDataPath: " + Environment.NewLine + Application.LocalUserAppDataPath + Environment.NewLine;
                infoLabel.Text += "--------------------" + Environment.NewLine;

                infoLabel.Text += "StartupPath:" + Environment.NewLine + Application.StartupPath + Environment.NewLine; ;
                infoLabel.Text += "--------------------" + Environment.NewLine;
            }


            void Form_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                infoLabel.Text += "Double clicked position: " + Environment.NewLine;
                infoLabel.Text += "X: " + e.X + " Y: " + e.Y;
            }

        }


        [STAThread]
        static void Main(string[] args)
        {
            //Here we run the application by creating and loading an object of myForm.
            Application.Run(new MyForm());

        }

    }

}