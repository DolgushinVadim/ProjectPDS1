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
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                double k = Convert.ToDouble(textBoxVark.Text);
                double h = Convert.ToDouble(textBoxVarh.Text);
                double u = Convert.ToDouble(textBoxVaru.Text);
                double Pp = Convert.ToDouble(textBoxVarPp.Text);
                double Pz = Convert.ToDouble(textBoxVarPz.Text);
                double Rk = Convert.ToDouble(textBoxVarRk.Text);
                double r = Convert.ToDouble(textBoxVarr.Text);
                double p = Convert.ToDouble(textBoxVarp.Text);
                double result = ds.Calculate(k, h, u, Pp, Pz, Rk, r, p);
                double result2 = 3600 * ds.Calculate(k, h, u, Pp, Pz, Rk, r, p);
                textBoxResult.Text = Convert.ToString(result);
                textBoxResult2.Text = Convert.ToString(result2);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа предназначена для расчёта плоскорадиального притока идеального газа в скважину по формуле Дюпюи. Программа была написана студентами группы ИИПб-23-3 Долгушиным Вадимом, Вележаниным Павлом, Галеевым Тимуром и Осинцевым Константином.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
