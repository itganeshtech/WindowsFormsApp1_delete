using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1_delete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2Button1.Text == "OFF")
            {
                guna2Button1.Text = "ON";
                button1.Visible = false;
                firstControl11.Visible = false;
            }
            else
            {
                button1.Visible= true;
                firstControl11.Visible = true;
                guna2Button1.Text = "OFF";
            }
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            firstControl11.Visible = false;
        }
    }
}
