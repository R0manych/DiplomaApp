using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDOA
{
    public partial class InputTaylorForm : Form
    {
        public InputTaylorForm()
        {
            InitializeComponent();
        }

        public bool IsSaved = false;
        public double Xn { get; set; }
        public double Yn { get; set; }
        public double D { get; set; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            teylorInputControl1.SetData();
            Xn = teylorInputControl1.Xn;
            Yn = teylorInputControl1.Yn;
            D = teylorInputControl1.Delta;
            IsSaved = true;
            Close();
        }
    }
}
