using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_4_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int[][] Input(int[][]a, int n)
		{
			Random random = new Random();
			for(int i = 0; i < n; i++)
			{
				a[i] = new int[n];
				for(int j = 0; j < n; j++)
				{
					a[i][j] = random.Next(-100, 100);
				}
			}
			return a;
		}

		void Print1(int[][] a)
		{
			textBox2.Text = "";
			for(int i = 0; i < a.Length; i++)
			{
				for(int j = 0; j < a[i].Length; j++)
				{
					textBox2.Text += string.Format("{0,5}", a[i][j]);
				}
				textBox2.Text += "\r\n";
			}
		}

		void Print2(int[] a)
		{
			textBox3.Text = "";
			for(int i = 0; i < a.Length; i++)
			{
				textBox3.Text += string.Format("{0,5}", a[i]);
			}
		}

		int[] LastEven(int[][]a, int n)
		{
			int[] res = new int[n];
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < a[i].Length; j++)
				{
					if (a[i][j] % 2 == 0)
					{
						res[i] = a[i][j];
					}
				}
			}
			return res;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int n = int.Parse(textBox1.Text);
				if(n <= 0)
				{
					throw new FormatException();
				}
				int[][] myArray = new int[n][];
				myArray = Input(myArray, n);
				Print1(myArray);
				Print2(LastEven(myArray, n));
			}
			catch (FormatException)
			{
				textBox4.Text = string.Format("Введены неверные данные");
			}
			catch
			{
				textBox4.Text = string.Format("Что-то пошло не так...");
			}
		}
	}
}
