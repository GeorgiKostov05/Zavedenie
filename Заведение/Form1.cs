using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Заведение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masa = "";
            string plashtane = "";
            int broi = 0;
            if (rdbPushachi.Checked)
            {
                masa = rdbPushachi.Text;
            }
            else
            {
                masa = rdbNePushachi.Text;
            }
            if (rdbKesh.Checked)
            {
                plashtane=rdbKesh.Text;
            }
            else
            {
                plashtane=rdbKarta.Text;
            }
           
            if(txtbBroi.Text=="")
            {
                MessageBox.Show("Error");
                txtbBroi.Focus();
            }
            else
            {
                MessageBox.Show($"Желаете маса {masa} за {txtbBroi.Text} човека и ще платите {plashtane} ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
        }
    }
}
