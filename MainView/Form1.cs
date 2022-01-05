using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoreLibrary;
using ModelLibrary;
using System.Linq;
using RepositroyLibrary;

namespace MainView
{
    public partial class Form1 : Form
    {
        private const string PATH = "NumberSets.json";
        private readonly NumberSetRepository _numberSetRepository = new NumberSetRepository(PATH);
        private Fractions _fractionView;
        private List<int> inputNumbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
            SetUpDefaults();
            SetUpEvents();
            _fractionView = new Fractions(this);
        }

        #region Button Click Methods

        private void StddevBtn_Click(object sender, EventArgs e)
        {
            stddevTxt.Text = Statistics.Stddev(inputNumbers).ToString();
        }

        private void VarianceBtn_Click(object sender, EventArgs e)
        {
            varianceTxt.Text = Statistics.Variance(inputNumbers).ToString();
        }

        private void IqrBtn_Click(object sender, EventArgs e)
        {
            iqrTxt.Text = (Statistics.Quartile(3, inputNumbers) - Statistics.Quartile(3, inputNumbers)).ToString();
        }

        private void Percentile_Click(object sender, EventArgs e)
        {
            percentileTxt.Text = Statistics.Percentile((double)percentileNumeric.Value / 100, inputNumbers).ToString();
        }

        private void QuartileBtn_Click(object sender, EventArgs e)
        {
            quartileTxt.Text = Statistics.Quartile((int)quartileNumeric.Value, inputNumbers).ToString();
        }

        private void ModeBtn_Click(object sender, EventArgs e)
        {
            modeTxt.Text = "Under Construction";
            //List<int> modeNumbers = Statistics.Mode(inputNumbers);
            //if(modeNumbers.Count == 0)
            //{
            //    modeTxt.Text = "None";
            //}
            //else
            //{
            //    modeTxt.Text = string.Join(',', modeNumbers);                
            //}
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
                    buttonSuccessLabel.Text = "Welcome to Version 0.0.1\nStatistics";
                    buttonSuccessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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

            DisplayInRightBox(inputNumbers);
            DisplayInLeftBox(inputNumbers);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _numberSetRepository.NumberSets.Add(new NumberSet(inputNumbers, setNameTxt.Text));
            _numberSetRepository.Save(PATH);
        }

        // New Views 
        private void FractionsViewBtn_Click(object sender, EventArgs e)
        {
            Hide();
            _fractionView.Show();
        }

        #endregion

        #region Setup and Display

        private void SetUpDefaults()
        {
            welcomeLabel.Text = "Enter a series of numbers separated each by a space \nand then click the button when your all done";
            buttonSuccessLabel.Text = "";
            leftErrorLabel.Text = "";
            rightErrorLabel.Text = "";            

            // Setting up numerical up/downs
            quartileNumeric.Minimum = 1;
            quartileNumeric.Maximum = 3;
            percentileNumeric.Minimum = 1;
            percentileNumeric.Maximum = 99;
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
            fractionsViewBtn.Click += FractionsViewBtn_Click;
            saveBtn.Click += SaveBtn_Click;
        }


        // Display
        public void DisplayInRightBox(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                rightListBox.Items.Add(num);
            }
        }

        public void DisplayInLeftBox(List<int> numbers)
        {
            leftListBox.Items.Clear();
            leftListBox.Items.Add("Some general statistics of your set:");
            leftListBox.Items.Add($"Total entries - {inputNumbers.Count()}");
            leftListBox.Items.Add($"High - {inputNumbers.Max()}");
            leftListBox.Items.Add($"Low - {inputNumbers.Min()}");
        }

        #endregion
    }
}
