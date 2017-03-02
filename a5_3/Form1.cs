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

namespace a5_3
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        //This is a global variable.
        internal static int formCounter;

        // This BindingSource binds the list to the DataGridView control.
        private BindingSource textboxBindingSource = new BindingSource();

        ArrayList buttonList = new ArrayList();
        ArrayList textboxList = new ArrayList();

        int buttonCounter = 1;
        int textboxCounter = 1;

        Button globalButton = new Button();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //formCounter = 1;

            /*
            textBox.Left = (this.Width - textBox.Width) / 2;
            changeButton.Left = (this.Width - changeButton.Width) / 2;
            */

            this.Text = "Form " + formCounter;

            buttonList.Add(changeButton);
            textboxList.Add(textBox);

            
            foreach (Button b in buttonList)
            {


            }

            foreach (TextBox t in textboxList)
            {
                t.Text = textBoxString(this.Top, this.Left, this.BackColor);
            }

            globalButton.ContextMenuStrip = buttonContextMenuStrip;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCounter--;
        }

        /*================================= button ===============================*/

        private void changeButton_Click(object sender, EventArgs e)
        {
            myClickHandler(sender, e);            
        }


        /*================================= textbox ===============================*/
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            /*
            Size size = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            textBox.Width = size.Width;
            textBox.Height = size.Height;

            textBox.Left = (this.Width - textBox.Width) / 2;
            */
        }


        /*================================= button tool strip menu ===============================*/
        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {

            globalButton.Width = 70;
            globalButton.Height = 20;

            /*
            foreach (Button b in buttonList)
            {
                b.Width = 70;
                b.Height = 20;
                b.Location = new Point((changeButton.Left + changeButton.Width) * buttonList.IndexOf(b) + 5, changeButton.Top);
            }
            
            
            textBox.Left = (this.Width - textBox.Width) / 2;
            textBox.Top = this.Height / 4 - 10;
            changeButton.Left = (this.Width - changeButton.Width) / 2;
            changeButton.Top = this.Height / 2;
            */
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalButton.Width = 100;
            globalButton.Height = 50;

            //globalButton.Location = new Point((changeButton.Left + changeButton.Width) * buttonList.IndexOf(b) + 5, changeButton.Top);

            //ContextMenuStrip k = (ContextMenuStrip)(((((ToolStripDropDownItem)sender).DropDown).OwnerItem).OwnerItem).Owner;
            /*
            ToolStripDropDownMenu t = (ToolStripDropDownMenu)((ToolStripMenuItem)sender).Owner;
            ContextMenuStrip cms = (ContextMenuStrip)((t.OwnerItem).Owner);

            object caller = cms.SourceControl;

            textBox.Text = "Source: " + cms.Text;
            
            
             foreach (Button b in buttonList)
             {
                 b.Width = 100;
                 b.Height = 50;

                 b.Location = new Point((changeButton.Left + changeButton.Width) * buttonList.IndexOf(b) + 5, changeButton.Top);
             }


            textBox.Left = (this.Width - textBox.Width) / 2;
            textBox.Top = this.Height / 4 - 10;
            changeButton.Left = (this.Width - changeButton.Width) / 2;
            changeButton.Top = this.Height / 2 + 10;
            */
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalButton.BackColor = Color.White;
            globalButton.ForeColor = Color.Black;


            /*
            foreach (Button b in buttonList)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.Black;
            }
            */


            //this.BackColor = Color.White;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {

            globalButton.BackColor = Color.Black;
            globalButton.ForeColor = Color.White;

            /*
            foreach (Button b in buttonList)
            {
                b.BackColor = Color.Black;
                b.ForeColor = Color.White;
            }
            */

            //this.BackColor = Color.Black;
        }


        /*================================= form tool strip menu ===============================*/
        private void duplicateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCounter++;

            MainForm newForm = new MainForm();

            newForm.Text = "Form " + formCounter;

            newForm.Show();
        }

        //duplicate button
        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Button newButton = new Button();
            newButton.Text = changeButton.Text;
            newButton.Size = changeButton.Size;

            newButton.BackColor = changeButton.BackColor;
            newButton.ForeColor = changeButton.ForeColor;

            newButton.Location = new Point((changeButton.Left + changeButton.Width + 40) * buttonCounter, changeButton.Top);
            
            newButton.Click += new System.EventHandler(myClickHandler);

            newButton.ContextMenuStrip = this.buttonContextMenuStrip;


            this.Controls.Add(newButton);
            
            newButton.Show();

            buttonList.Add(newButton);

            buttonCounter++;
        }


        //duplicate text box
        private void texboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox newTextBox = new TextBox();

            newTextBox.Width = textBox.Width;
            newTextBox.Height = textBox.Height;
            newTextBox.Text = textBoxString(this.Top, this.Left, this.BackColor);

            newTextBox.Location = new Point((textBox.Left + textBox.Width )* textboxCounter + 5, textBox.Top);

            this.Controls.Add(newTextBox);

            textboxList.Add(newTextBox);

            newTextBox.Show();

            textboxCounter++;
        }
        /*================================= function methods ===============================*/

        private Color RandomColor()
        {
            Color randomColor;

            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            randomColor = Color.FromKnownColor(randomColorName);

            return randomColor;
        }

        private int RandomX()
        {
            int x;

            int avaliableX = Screen.PrimaryScreen.Bounds.Width;

            Random r = new Random();
            int rInt = r.Next(this.Width, avaliableX);

            x = rInt - this.Width;

            return x;
        }

        private int RandomY()
        {
            int y;

            int avaliableY = Screen.PrimaryScreen.Bounds.Height;

            Random r = new Random();
            int rInt = r.Next(this.Height, avaliableY);

            y = rInt - this.Height;

            return y;
        }

        private string textBoxString(int x, int y, Color c)
        {
            string str;

            str = "X: " + x + " | Y: " + y + " | Color: " + ColorTranslator.ToHtml(c);

            return str;
        }

        private void myClickHandler(object sender, EventArgs e)
        {
            

            this.BackColor = RandomColor();

            this.Location = new Point(RandomX(), RandomY());

            foreach (TextBox t in textboxList)
                t.Text = textBoxString(this.Top, this.Left, this.BackColor);
        }

        private void changeButton_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                textBox.Text = "get right click";
            }
            else if (e.Button == MouseButtons.Left)
            {
                textBox.Text = "get left click";
            }
            else if (e.Button == MouseButtons.Middle)
            {
                textBox.Text = "get middle click";
            }
        }

        private void buttonContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip cms = (ContextMenuStrip)sender;

            Button controlButton = (Button)cms.SourceControl;

            this.globalButton = controlButton;
        }
    }
}
