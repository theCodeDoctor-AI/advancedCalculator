using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoreLibrary;

namespace MainView
{
    public partial class Form1 : Form
    {

        private List<int> inputNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
            SetUpDefaults();
            SetUpEvents();
        }

        private void StddevBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void VarianceBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void IqrBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Percentile_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void QuartileBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ModeBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MedianBtn_Click(object sender, EventArgs e)
        {
            medianTxt.Text = Statistics.Median(inputNumbers).ToString();
        }

        private void MeanBtn_Click(object sender, EventArgs e)
        {
            meanTxt.Text = Statistics.FindMean(inputNumbers).ToString();
        }

        private void AllDoneButton_Click(object sender, EventArgs e)
        {
            inputNumbers.Clear();
            string inputString = inputTxt.Text;

            string[] array = inputString.Split(' ');
            foreach (string s in array)
            {
                string sTrim = s.Trim();
                try
                {
                    if (int.TryParse(sTrim, out int i))
                    {
                        inputNumbers.Add(i);
                    }
                    else
                    {
                        ArgumentException ae = new ArgumentException("Something you entered is not a number.  Check the output on the right before proceeding");
                        inputTxt.Text = "";
                        throw ae;
                    }
                }
                catch(ArgumentException ae)
                {
                    leftErrorLabel.Text = ae.Message;
                }
                finally
                {
                    inputTxt.Text = "";
                }                
            }

            DisplayInLeftBox(inputNumbers);
        }

        public void DisplayInLeftBox(List<int> numbers)
        {
            foreach(int num in numbers)
            {
                rightListBox.Items.Add(num);
            }
        }

        private void SetUpDefaults()
        {
            welcomeLabel.Text = "Enter a series of numbers separated each by a space \nand then click the button when your all done";
            buttonSuccessLabel.Text = "";
            leftErrorLabel.Text = "";
            rightErrorLabel.Text = "";
        }

        private void SetUpEvents()
        {
            allDoneButton.Click += AllDoneButton_Click;
            meanBtn.Click += MeanBtn_Click;
            medianBtn.Click += MedianBtn_Click;
            modeBtn.Click += ModeBtn_Click;
            quartileBtn.Click += QuartileBtn_Click;
            percentileBtn.Click += Percentile_Click;
            iqrBtn.Click += IqrBtn_Click;
            varianceBtn.Click += VarianceBtn_Click;
            stddevBtn.Click += StddevBtn_Click;
        }
    }
}
