using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_GiaiPTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtc.Text = trackBar3.Value.ToString();
        }

        private void btngiaipt_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double delta, x1, x2;
            if ( a == 0){
                if (b == 0){
                    if (c != 0){
                        lblketqua.Text = "Phương trình vô nghiệm";
                    }
                    else {
                        lblketqua.Text = "Phương trình có vô số nghiệm";
                    }
                } else {
                   
                    lblketqua.Text = "Phương trình có nghiệm x1 = x2: ;"+((-c) / b).ToString();
                }
            } else {
                delta = b * b - 4 * a * c;
                if (delta < 0) {
                    lblketqua.Text = "Phương trình vô nghiệm";
                }
                else 
                if (delta == 0) {
 
                    lblketqua.Text = "Phương trình có nghiệm kép x1 = x2 =" + ((-b) / (2 * a)).ToString();

                } 
                else {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * b);
                    lblketqua.Text = "Phương trình có 2 nghiệm/n"+ "x1 =" + x1 + "\nx2 = " + x2;
                  
                }
            }
        }

        private void lblketqua_Click(object sender, EventArgs e)
        {

        }
    }
}
