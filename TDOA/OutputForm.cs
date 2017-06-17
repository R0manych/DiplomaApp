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
    public partial class OutputForm : Form
    {
        public OutputForm()
        {
            InitializeComponent();
        }

        public OutputForm(OutputData<double> outputData)
        {
            InitializeComponent();
            outputDataControl1.SetData(outputData);
        }
    }
}
