using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11с
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string elems = tbInputLength.Text;
            if (!Algorithm.InputElems(elems))
            {
                MessageBox.Show("Ошибки при вводе длин отрезков!");
                tbInputLength.Focus();
                return;
            }
            int M = int.Parse(tBInputM.Text);
            if (M < 3)
            {
                MessageBox.Show("Сторон должно быть минимум 3!");
                tBInputM.Focus();
                return;
            }
            int P = int.Parse(tBInputP.Text);
            if (P < 3)
            {
                MessageBox.Show("Дайте шанс! Отрезков должно быть минимум 3!");
                tBInputP.Focus();
                return;
            }
            if (M > Algorithm.N)
            {
                MessageBox.Show("Слишком большой многоугольник! "+M+"-угольник не может состоять из "+Algorithm.N+" отрезков!");
                tbInputLength.Focus();
                return;
            }
            if (!Algorithm.FindSides(M, P))
            {
                MessageBox.Show("Не получится составить " + M + "-угольник :((");
                return;
            }
            MessageBox.Show("ПОЛУЧИЛОСЬ!!!\n"+Algorithm.ShowResultToStr());
        }
    }
}
