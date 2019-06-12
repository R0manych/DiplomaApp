using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskUtilsLib.DataStructures;
using TaskUtilsLib.Services;

namespace TDOA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsDataSet = false;
        }

        InputData<double> _inputData;
        public bool IsDataSet { get; set; }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private SolutionService _solutionService;

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            /*var input = inputDataControl1.LoadData();
            _solutionService = new SolutionService(input);
            var output = _solutionService.Solve();
            outputDataControl1.SetData(output);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var detailsForm = new DetailsForm();
            detailsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inputForm = new InputForm();
            
            inputForm.ShowDialog(this);
            
            if (inputForm.IsSaved)
            {
                _inputData = inputForm.InputData;
                IsDataSet = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsDataSet)
            {
                MessageBox.Show("Не введены данные");
            }
            else
            {
                _solutionService = new SolutionService(_inputData);
                var outputdata = _solutionService.Solve();
                var outputForm = new OutputForm(outputdata);
                outputForm.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!IsDataSet)
            {
                MessageBox.Show("Не введены данные");
            }
            else
            {
                var inputForm = new InputTaylorForm();

                inputForm.ShowDialog(this);

                if (inputForm.IsSaved)
                {
                    var inputTeylorData = new InputDataTeylor<double>(_inputData, inputForm.D, inputForm.Xn, inputForm.Yn);
                    var solutiontayleService = new SolutionTaylorService(inputTeylorData);
                    var outputdata = solutiontayleService.Solve();
                    var outputForm = new OutputForm(outputdata);
                    outputForm.Show();
                }
                else
                {
                    MessageBox.Show("Не введены данные");
                }
            }
        }
    }
}
