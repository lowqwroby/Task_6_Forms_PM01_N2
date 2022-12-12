using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_3_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int[,] Input(out int n)
		{
			n = int.Parse(textBox1.Text);
			int[,] a = new int[n, n];
			Random random = new Random();

			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
					a[i, j] = random.Next(-20, 20);
				}
			}
			return a;
		}

		void Print(int[,] a)
		{
			textBox2.Text = "";
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					textBox2.Text += string.Format("{0}  ", a[i, j]);
				}
				textBox2.Text += "\r\n";
			}
		}

		void Print1(int[,] a)
		{
			textBox3.Text = "";
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					textBox3.Text += string.Format("{0}\t", a[i, j]);
				}
				textBox3.Text += "\r\n";
			}
		}

		int[,] Result(int[,] a, int n)
		{
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					a[i, j] = (int)Math.Pow(a[i, j], n);
				}
			}
			return a;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int n;
				int[,] myArray = Input(out n);

				if(n <= 0)
				{
					throw new FormatException();
				}

				Print(myArray);
				Result(myArray, n);
				Print1(myArray);
			}
			catch (FormatException)
			{
				textBox4.Text = string.Format("Неверный ввод данных");
			}
			catch
			{
				textBox4.Text = string.Format("Что-то пошло не так");
			}
		}
	}
}
