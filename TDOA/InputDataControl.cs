using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskUtilsLib.DataStructures;

namespace TDOA
{
    public partial class InputDataControl : UserControl
    {
        public InputDataControl()
        {
            InitializeComponent();
        }

        public InputData<double> LoadData()
        {
            return new InputData<double>(
               Convert.ToDouble(numericUpDownX1.Value),
               Convert.ToDouble(numericUpDownX2.Value),
               Convert.ToDouble(numericUpDownX3.Value),
               Convert.ToDouble(numericUpDownY1.Value),
               Convert.ToDouble(numericUpDownY2.Value),
               Convert.ToDouble(numericUpDownY3.Value),
               Convert.ToDouble(numericUpDownM2.Value),
               Convert.ToDouble(numericUpDownM3.Value)
               );
        }
    }
}
