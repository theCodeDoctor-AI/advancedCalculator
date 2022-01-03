using System;
using CoreLibrary;
using ModelLibrary;
using System.Windows.Forms;

namespace MainView
{
    public partial class Fractions : Form
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction();
        Fraction result = new Fraction();

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
            operatorErrorLabel.Text = "";
            numberInputErrorLabel.Text = "";
        }

        private void SetUpEvents()
        {
            mainViewBtn.Click += MainViewBtn_Click;
            equalsButton.Click += EqualsButton_Click;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            string operation = operatorComboBox.SelectedItem.ToString();

            switch(operation)
            {
            }
        }

        private void MainViewBtn_Click(object sender, EventArgs e)
        {
            Hide();
            mainView.Show();
        }
    }
}
