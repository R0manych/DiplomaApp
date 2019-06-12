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
    public partial class TeylorInputControl : UserControl
    {
        public TeylorInputControl()
        {
            InitializeComponent();
        }

        public double Xn { get; set; }

        public double Yn { get; set; }

        public double Delta { get; set; }

        public void SetData()
        {
            Xn = Convert.ToDouble(numericUpDownX1.Value);
            Yn = Convert.ToDouble(numericUpDownX2.Value);
            Delta = Convert.ToDouble(numericUpDownY1.Value);
        }
    }
}
