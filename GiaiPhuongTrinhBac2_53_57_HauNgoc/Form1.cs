using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTrinhBac2_53_57_HauNgoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntPlay_53_57_HauNgoc_Click(object sender, EventArgs e)
        {
            double a_53_57_HauNgoc, b_53_57_HauNgoc, c_53_57_HauNgoc;
            a_53_57_HauNgoc= int.Parse(txtA_53_57_HauNgoc.Text);
            b_53_57_HauNgoc = int.Parse(txtB_53_57_HauNgoc.Text);
            c_53_57_HauNgoc = int.Parse(txtC_53_57_HauNgoc.Text);
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(a_53_57_HauNgoc, b_53_57_HauNgoc, c_53_57_HauNgoc);
            txtResult_53_57_HauNgoc.Text = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            Console.WriteLine(ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc());

        }
    }
}
