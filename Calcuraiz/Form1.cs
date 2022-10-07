using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuraiz
{
    public partial class Form1 : Form
    {
        double b = 0;
        double x = 0;
        double temp = 0;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtEntrarnumero.Text);
            b = x;
            for (cont = 0; cont < 1000; cont++)
            {
                b = 0.5 * ((x / b) + b);
                txtresultado.Text = Convert.ToString(b);
            }
        }
    }
}
