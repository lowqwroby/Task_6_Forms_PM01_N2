using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_1_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int[] Input1m()
		{
			int n = int.Parse(textBox1.Text);
			string[] a = textBox2.Text.Split(' ');
			if(n != a.Length)
			{
				throw new Exception();
			}
			int[] arr = new int[n];
			for(int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(a[i]); 
			}
			return arr;
		}

		void Print1m(int[] a)
		{
			textBox2.Text = "";
			for(int i = 0; i < a.Length; i++)
			{
				textBox2.Text += string.Format("{0} ", a[i]);
			}
			textBox2.Text += string.Format("\n");
		}

		int Change1m(int[] a, int b, int c)
		{
			int index = 0;

			for(int i = 0; i < a.Length; i++)
			{
				if (a[i] < b || a[i] > c)
				{
					index++;
				}
			}
			return index;
		}

		int[,] Input2m()
		{
			int n = int.Parse(textBox10.Text);
			int m = int.Parse(textBox11.Text);
			string[] str = textBox9.Text.Split(' ');
			if (str.Length != n * m)
			{
				throw new Exception();
			}
			int index = 0;
			int[,] a = new int[n, m];
			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < m; j++)
				{
					a[i, j] = int.Parse(str[index]);
					index++;
				}
			}
			return a;
		}

		void Print2m(int[,] a)
		{
			textBox9.Text = "";
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					textBox9.Text += string.Format("{0} ", a[i, j]);
				}
				textBox9.Text += string.Format("\r\n");
			}
		}

		int Change2m(int[,] a, int b1, int c1)
		{
			int index = 0;
			for(int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
				{
					if (a[i, j] >= b1 && a[i, j] <= c1)
					{
						index++;
					}
				}
			}
			return a.Length - index;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				//Одномерный массив
				int[] myArray = Input1m();
				int b = int.Parse(textBox3.Text);
				int c = int.Parse(textBox4.Text);
				if (b > c)
				{
					int temp = c;
					c = b;
					b = temp;
				}
				Print1m(myArray);
				textBox5.Text = string.Format("{0}", Change1m(myArray, b, c));
			}
			catch (FormatException)
			{
				textBox5.Text = string.Format("Введены неверные данные");
			}
			catch
			{
				textBox5.Text = string.Format("Что-то пошло не так...");
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				//Двумерный массив
				int[,] myArray = Input2m();
				int b = int.Parse(textBox8.Text);
				int c = int.Parse(textBox7.Text);
				if(b > c)
				{
					int temp = c;
					c = b;
					b = temp;
				}
				Print2m(myArray);
				textBox6.Text = string.Format("{0}", Change2m(myArray, b, c));
			}
			catch (FormatException)
			{
				textBox6.Text = string.Format("Введены неверные данные");
			}
			catch
			{
				textBox6.Text = string.Format("Что-то пошло не так...");
			}
			
		}
	}
}
