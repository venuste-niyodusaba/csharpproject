using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CientificCalculator
{
    public partial class Form1 : Form
    {
        Double enterFirstvalue, entersecondvalue;
        String op;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width =340;
            this.Height = 440;
           this. txtresult.Width = 290;
        }

        private void enterNumbers(object sender, EventArgs e)
        {
            Button num=(Button)sender;
            if (txtresult.Text == "0")
                txtresult.Text = " ";
            {
                if (num.Text == ".")
                {
                    if (!txtresult.Text.Contains("."))

                        txtresult.Text = txtresult.Text + num.Text;
                    
                }
                else
                {
                 txtresult.Text = txtresult.Text + num.Text;
                }
            }
        }

        private void numberoper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstvalue = Convert.ToDouble(txtresult.Text);
            op = num.Text;
            txtresult.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
        }

        private void btnclearEntry_Click(object sender, EventArgs e)
        {
            txtresult.Text = "0";
            String f, s;
            f = Convert.ToString(enterFirstvalue);
            s= Convert.ToString(entersecondvalue);
            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
             double q= Convert.ToDouble(txtresult.Text);
            txtresult.Text= Convert.ToString(-1*q);
        } 

        private void btnBs_Click(object sender, EventArgs e)
        {
            if (txtresult.Text.Length > 0)
            {
                txtresult.Text = txtresult.Text.Remove( txtresult.Text.Length-1,1);
            }
            if (txtresult.Text == "")
            {
                txtresult.Text = "0";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 295;
            this.Height = 440;
            this.txtresult.Width = 288;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 640;
            this.Height = 440;
            this.txtresult.Width = 580;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitcal;
            exitcal = MessageBox.Show("comform if you want to exit","scientific calculator",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if( exitcal==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Sqrt(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        

        private void btnsqt_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
           sq = Math.Sqrt(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Double logg = Convert.ToDouble(txtresult.Text);
            logg = Math.Log10(logg);
            txtresult.Text = Convert.ToString(logg);
        }

        private void btnsinh_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Sinh(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            txtresult.Text = "3.141592653589976232";
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Sin(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btnpwr2_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(txtresult.Text);
            x = Convert.ToDouble(txtresult.Text)* Convert.ToDouble(txtresult.Text);
            txtresult.Text = x.ToString();
        }

        private void btnpwr3_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(txtresult.Text);
            x = (Convert.ToDouble(txtresult.Text) * Convert.ToDouble(txtresult.Text))* Convert.ToDouble(txtresult.Text);
            txtresult.Text = x.ToString();
        }

        private void btnconh_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Cosh(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btntah_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Tanh(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Cos(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Tan(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btninverse_Click(object sender, EventArgs e)
        {
            Double c = Convert.ToDouble(1.0/ Convert.ToDouble(txtresult.Text));
            txtresult.Text = Convert.ToString(c);
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            Double sq = Convert.ToDouble(txtresult.Text);
            sq = Math.Log(sq);
            txtresult.Text = Convert.ToString(sq);
        }

        private void btnperc_Click(object sender, EventArgs e)
        {
            Double c = Convert.ToDouble(txtresult.Text)/Convert.ToDouble(100);
            txtresult.Text = Convert.ToString(c);
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            Double c = Convert.ToDouble(txtresult.Text);
            int d = Convert.ToInt32(c);
            int i = (int)c;
            txtresult.Text = Convert.ToString(i);
        }

        private void btnbin_Click(object sender, EventArgs e)
        {
            int c = int.Parse(txtresult.Text);
            txtresult.Text = Convert.ToString(c,2);
        }

        private void btnhex_Click(object sender, EventArgs e)
        {
            int c = int.Parse(txtresult.Text);
            txtresult.Text = Convert.ToString(c, 16);
        }

        private void btnoct_Click(object sender, EventArgs e)
        {
            int c = int.Parse(txtresult.Text);
            txtresult.Text = Convert.ToString(c, 8);
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            Double v =  Convert.ToDouble(txtresult.Text);
            entersecondvalue = v;
            switch (op)
            {
                case "+":
                    txtresult.Text = (enterFirstvalue + entersecondvalue).ToString();
                 break;
                case"-":
                    txtresult.Text = (enterFirstvalue - entersecondvalue).ToString();
                    break;
                case "*":
                    txtresult.Text = (enterFirstvalue * entersecondvalue).ToString();
                    break;
                case "/":
                    txtresult.Text = (enterFirstvalue / entersecondvalue).ToString();
                    break;
                case "mod":
                    txtresult.Text = (enterFirstvalue % entersecondvalue).ToString();
                    break;
                case "exp":
                    double i = Convert.ToDouble(txtresult.Text);
                    double j= entersecondvalue;
                    txtresult.Text = Math.Exp(i*Math.Log(j*4)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
