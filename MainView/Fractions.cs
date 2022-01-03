using System;
using CoreLibrary;
using ModelLibrary;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MainView
{
    public partial class Fractions : Form
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction();
        Fraction result = new Fraction();

        List<TextBox> textboxes = new List<TextBox>();

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

            textboxes.Add(firstNumTxt);
            textboxes.Add(firstDenTxt);
            textboxes.Add(secondNumTxt);
            textboxes.Add(secondDenTxt);
        }

        private void SetUpEvents()
        {
            mainViewBtn.Click += MainViewBtn_Click;
            equalsButton.Click += EqualsButton_Click;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            // Terminate method if any numerator / denominator is not an integer
            if (!ValidateNumericals()) { return; }

            // clear error label first
            operatorErrorLabel.Text = "";
            // check to make sure operator is selected
            try
            {
                string operation = operatorComboBox.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                operatorErrorLabel.Text = "Please select an operator first!";
            }

            // evaluate the 
            switch (operation)
            {
            }
        }

        private void MainViewBtn_Click(object sender, EventArgs e)
        {
            Hide();
            mainView.Show();
        }

        private bool ValidateNumericals()
        {
            foreach (TextBox tb in textboxes)
            {
                if (!int.TryParse(tb.Text, out int _)) { return false; }
            }
            return true;
        }
    }
}
