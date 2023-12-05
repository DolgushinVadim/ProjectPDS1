using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Library;
namespace Program
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                double k = Convert.ToDouble(textBoxVark.Text);
                double h = Convert.ToDouble(textBoxVarh.Text);
                double u = Convert.ToDouble(textBoxVaru.Text);
                double Pp = Convert.ToDouble(textBoxVarPp.Text);
                double Pz = Convert.ToDouble(textBoxVarPz.Text);
                double Rk = Convert.ToDouble(textBoxVarRk.Text);
                double r = Convert.ToDouble(textBoxVarr.Text);
                double p = Convert.ToDouble(textBoxVarp.Text);
                double result = ds.Calculate(k, h, u, Pp, Pz, Rk, r, p);
                textBoxResult.Text = Convert.ToString(result);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
