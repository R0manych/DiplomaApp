using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskUtilsLib.Services;

namespace TDOA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private SolutionService _solutionService;

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var input = inputDataControl1.LoadData();
            _solutionService = new SolutionService(input);
            var output = _solutionService.Solve();
            outputDataControl1.SetData(output);
        }
    }
}
