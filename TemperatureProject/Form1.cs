using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureProject
{
    public partial class v : Form
    {
        TemperatureManagament temperature = new TemperatureManagament();
        public v()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                temperature.Add(new Temperature());
            }
        }

        private void txtAddT_Click(object sender, EventArgs e)
        {

        }

        private void txtGetTemp_Click(object sender, EventArgs e)
        {
            double temp = temperature[8];
        }
    }
}
