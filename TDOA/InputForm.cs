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

namespace TDOA
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            IsSaved = false;
        }

        public InputData<double> InputData;
        public bool IsSaved { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            InputData = inputDataControl1.LoadData();
            IsSaved = true;
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            IsSaved = false;
            Close();
        }
    }
}
