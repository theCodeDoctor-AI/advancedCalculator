using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetUpDefaults();
        }

        private void SetUpDefaults()
        {
            welcomeLabel.Text = "Enter a series of numbers separated each by a space \nand then click the button when your all done";
            buttonSuccessLabel.Text = "";
            buttonSuccessLabel.Visible = false;
        }
    }
}
