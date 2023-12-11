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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
            groupBox4.Show();
            groupBox5.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
            groupBox4.Show();
            groupBox5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (int.Parse(textBox1.Text) > 0) 
            {
                price += 7.99 * double.Parse(textBox1.Text);
            }
            if (int.Parse(textBox2.Text) > 0)
            {
                price += 7.99 * double.Parse(textBox2.Text);
            }
            if (int.Parse(textBox3.Text) > 0)
            {
                price += 4.99 * double.Parse(textBox3.Text);
            }
            if (int.Parse(textBox4.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox4.Text);
            }
            if (int.Parse(txtB5.Text) > 0)
            {
                price += 4.99 * double.Parse(txtB5.Text);
            }
            if (int.Parse(textBox6.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox6.Text);
            }
            if (int.Parse(textBox7.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox7.Text);
            }
            if (int.Parse(textBox8.Text) > 0)
            {
                price += 4.99 * double.Parse(textBox8.Text);
            }
            if (int.Parse(textBox9.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox9.Text);
            }
            if (int.Parse(textBox10.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox10.Text);
            }
            if (int.Parse(textBox11.Text) > 0)
            {
                price += 4.99 * double.Parse(textBox11.Text);
            }
            if (int.Parse(textBox12.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox12.Text);
            }
            if (int.Parse(textBox13.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox13.Text);
            }
            if (int.Parse(textBox14.Text) > 0)
            {
                price += 4.99 * double.Parse(textBox14.Text);
            }
            if (int.Parse(textBox15.Text) > 0)
            {
                price += 3.99 * double.Parse(textBox15.Text);
            }
            MessageBox.Show($"Цена: {price}лв");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Pregled_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                listBox1.Items.Add($"{textBox1.Text}br. {labelpg.Text}");
            }
            if (textBox2.Text != "0")
            {
                listBox1.Items.Add($"{textBox2.Text}br. {labeltk.Text}");
            }
            if (textBox3.Text != "0")
            {
                listBox1.Items.Add($"{textBox3.Text}br. {labelMusaka.Text}");
            }
            if (textBox4.Text != "0")
            {
                listBox1.Items.Add($"{textBox4.Text}br. {labelselsT.Text}");
            }
            if (txtB5.Text != "0")
            {
                listBox1.Items.Add($"{txtB5.Text}br. {labelkadife.Text}");
            }
            if (textBox6.Text != "0")
            {
                listBox1.Items.Add($"{textBox6.Text}br. {labelpldT.Text}");
            }
            if (textBox7.Text != "0")
            {
                listBox1.Items.Add($"{textBox7.Text}br. {labelBira.Text}");
            }
            if (textBox8.Text != "0")
            {
                listBox1.Items.Add($"{textBox8.Text}br. {labelVino.Text}");
            }
            if (textBox9.Text != "0")
            {
                listBox1.Items.Add($"{textBox9.Text}br. {labelSkoch.Text}");
            }
            if (textBox10.Text != "0")
            {
                listBox1.Items.Add($"{textBox10.Text}br. {labelSokKapi.Text}");
            }
            if (textBox11.Text != "0")
            {
                listBox1.Items.Add($"{textBox11.Text}br. {labelFanta.Text}");
            }
            if (textBox12.Text != "0")
            {
                listBox1.Items.Add($"{textBox12.Text}br. {labelKola.Text}");
            }
            if (textBox13.Text != "0")
            {
                listBox1.Items.Add($"{textBox13.Text}br. {labelChajPodov.Text}");
            }
            if (textBox14.Text != "0")
            {
                listBox1.Items.Add($"{textBox14.Text}br. {labelGoreshtShokolad.Text}");
            }
            if (textBox15.Text != "0")
            {
                listBox1.Items.Add($"{textBox15.Text}br. {labelKafe.Text}");
            }
        }
    }
}
