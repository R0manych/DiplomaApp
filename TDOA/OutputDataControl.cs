using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDOA
{
    public partial class OutputDataControl : UserControl
    {
        public OutputDataControl()
        {
            InitializeComponent();
        }

        public void SetData(TaskUtilsLib.DataStructures.OutputData<double> outputData) 
        {
            textBoxX.Text = outputData.X.ToString();
            textBoxY.Text = outputData.Y.ToString();
        }
    }
}
