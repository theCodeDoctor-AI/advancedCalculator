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
        Form1 mainView;
        public Fractions(Form1 main)
        {
            InitializeComponent();
            SetUpControls();
            SetUpEvents();
            mainView = main;
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

        private void SetUpEvents()
        {
            mainViewBtn.Click += MainViewBtn_Click;
        }

        private void MainViewBtn_Click(object sender, EventArgs e)
        {
            Hide();
            mainView.Show();
        }
    }
}
