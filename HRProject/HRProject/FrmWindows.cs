using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRProject
{
    public partial class FrmWindows : Form
    {
        public FrmWindows()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Class1 sample = new Class1();

            sample.pcname = listBox1.SelectedItem.ToString();
            
        }
    }
}
