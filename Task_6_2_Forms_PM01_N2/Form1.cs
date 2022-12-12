using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_2_Forms_PM01_N2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				textBox2.Text = "";
				string[] str = textBox1.Text.Split(' ');
				int n = str.Length;

				double[] arr = new double[n];
				for (int i = 0; i < n; i++)
				{
					arr[i] = Convert.ToDouble(str[i]);
					textBox2.Text += string.Format("{0,5}", arr[i]);
				}

				double min = arr[0];
				int index = 0;
				for (int i = 1; i < arr.Length; i++)
				{
					if (arr[i] <= min)
					{
						min = arr[i];
						index = i;
					}
				}

				textBox2.Text += "\r\nИндекс последнего минимального элемента в массиве: " + index;
			}
			catch (FormatException)
			{
				textBox2.Text = "Введен неправильный формат";
			}
			catch
			{
				textBox2.Text = "Непредвиденная ошибка";
			}
			
		}
	}
}
