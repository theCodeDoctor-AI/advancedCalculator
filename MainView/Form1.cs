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
        private readonly Fractions _fractionView;
        private List<int> _inputNumbers = new List<int>();
        private List<NumberSet> _savedNumberSets = new List<NumberSet>();

        public Form1()
        {
            _fractionView = new Fractions(this);
            _savedNumberSets = _numberSetRepository.NumberSets;

            InitializeComponent();
            SetUpDefaults();
            SetUpEvents();
        }

        #region Button Click Methods

        private void StddevBtn_Click(object sender, EventArgs e)
        {
            stddevTxt.Text = Statistics.Stddev(_inputNumbers).ToString();
        }

        private void VarianceBtn_Click(object sender, EventArgs e)
        {
            varianceTxt.Text = Statistics.Variance(_inputNumbers).ToString();
        }

        private void IqrBtn_Click(object sender, EventArgs e)
        {
            iqrTxt.Text = (Statistics.Quartile(3, _inputNumbers) - Statistics.Quartile(3, _inputNumbers)).ToString();
        }

        private void Percentile_Click(object sender, EventArgs e)
        {
            percentileTxt.Text = Statistics.Percentile((double)percentileNumeric.Value / 100, _inputNumbers).ToString();
        }

        private void QuartileBtn_Click(object sender, EventArgs e)
        {
            quartileTxt.Text = Statistics.Quartile((int)quartileNumeric.Value, _inputNumbers).ToString();
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
            medianTxt.Text = Statistics.Median(_inputNumbers).ToString();
        }

        private void MeanBtn_Click(object sender, EventArgs e)
        {
            meanTxt.Text = Statistics.FindMean(_inputNumbers).ToString();
        }

        private void AllDoneButton_Click(object sender, EventArgs e)
        {
            _inputNumbers.Clear();
            string inputString = inputTxt.Text;

            string[] array = inputString.Split(' ');
            foreach (string s in array)
            {
                string sTrim = s.Trim();
                try
                {
                    if (int.TryParse(sTrim, out int i))
                    {
                        _inputNumbers.Add(i);
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

            DisplayInRightBox(_inputNumbers);
            DisplayInLeftBox(_inputNumbers);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _numberSetRepository.NumberSets.Add(new NumberSet(_inputNumbers, setNameTxt.Text));
            _numberSetRepository.Save(PATH);
        }

        private void LoadNumberSetBtn_Click(object sender, EventArgs e)
        {
            _inputNumbers = (savedNumberSetListBox.SelectedItem as NumberSet).Numbers;
            DisplayInRightBox(_inputNumbers);
            loadSuccessLabel.Text = "Load Success";
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

            PopulateSavedListBox();
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
            loadNumberSetBtn.Click += LoadNumberSetBtn_Click;
        }       


        // Display
        private void DisplayInRightBox(List<int> numbers)
        {
            rightListBox.Items.Clear(); 
            foreach (int num in numbers)
            {
                rightListBox.Items.Add(num);
            }
        }

        private void DisplayInLeftBox(List<int> numbers)
        {
            leftListBox.Items.Clear();
            leftListBox.Items.Add("Some general statistics of your set:");
            leftListBox.Items.Add($"Total entries - {_inputNumbers.Count()}");
            leftListBox.Items.Add($"High - {_inputNumbers.Max()}");
            leftListBox.Items.Add($"Low - {_inputNumbers.Min()}");
        }

        // For refreshing saved number set list box
        public void PopulateSavedListBox()
        {
            foreach (NumberSet ns in _savedNumberSets)
            {
                savedNumberSetListBox.Items.Add(ns);
            }
            savedNumberSetListBox.DisplayMember = nameof(NumberSet.NumberSetName);
        }

        #endregion
    }
}
