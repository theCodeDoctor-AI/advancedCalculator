using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainView
{
    public partial class Fractions : Form
    {
        public Fractions()
        {
            InitializeComponent();
        }

        private void SetUpControls()
        {
            operatorComboBox.Items.AddRange(
                new string[] {
                    "+",
                    "-",
                    "*",
                    "/"
                    }
                );
        }
    }
}
