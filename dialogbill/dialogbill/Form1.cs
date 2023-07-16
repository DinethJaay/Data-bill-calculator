using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogbill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double monthlyrental = 200;
            double monthlyrental2 = 400;
            double mintax = 250;
            double maxtax = 350;
            double mintax2 = 350;
            double maxtax2 = 450;
            double total=0;


            int daytimedata = Convert.ToInt32(txtunitatday.Text);
            int nighttime = Convert.ToInt32(txtunitatnight.Text);

            if(cmbdatapack.SelectedIndex==0)
            {
                if (daytimedata<=50)
                {
                    total = 400;
                }
                else
                {
                    total=monthlyrental+(daytimedata-50)*10;
                }
                if(nighttime<=10)
                {
                    total = 200;
                }
                else
                {
                    total = monthlyrental + (nighttime - 10) * 10;
                }
                total = total + monthlyrental;

                if (total <= 1000)
                {
                    total = total + mintax;
                }
                else if (total >= 1000)
                {
                    total = total + maxtax;
                }

            }

            if (cmbdatapack.SelectedIndex==1)
            {
                if (daytimedata <= 10)
                {
                    total = 200;
                }
                else
                {
                    total = monthlyrental2+(daytimedata - 20) * 20;
                }
                if (nighttime >= 100)
                {
                    total = 600;
                }
                else
                {
                    total = monthlyrental2 + (nighttime - 100) * 10;
                }

                if(total<=1500)
                {
                    total = total + mintax2;
                }
                else if(total>=1500)
                {
                    total=total+ maxtax2;
                }
            }
            txttotal.Text =Convert.ToString(total);


        }
    }
}
