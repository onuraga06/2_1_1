using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1_1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		double kola, cay, bilet, mısır, kasa, toplam;

		private void label21_Click(object sender, EventArgs e)
		{
			
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Sadece Rakam Girme İçin
		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1_Click(this,new EventArgs());
			}
		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			cay = Convert.ToDouble(numericUpDown1.Value);
			kola = Convert.ToDouble(numericUpDown2.Value);
			mısır = Convert.ToDouble(numericUpDown5.Value);
			bilet = Convert.ToDouble(numericUpDown6.Value);

			toplam = ((cay * 5) + (kola * 7) + (mısır * 10) + (bilet * 12));
			kasa = kasa + toplam;
			MessageBox.Show("Hesabınız=" + toplam + "TLl", "Adisyon", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			label15.Text = kasa.ToString()+"TL";
			numericUpDown1.Value = 0;numericUpDown2.Value = 0;numericUpDown5.Value = 0;numericUpDown6.Value = 0;
			label16.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		
	}
}
