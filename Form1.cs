using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sorting_algo
{
	public partial class Form1 : Form
	{
		int[] numbers = new int[10];
		public Form1()
		{
			InitializeComponent();
			listView1.View = View.Details;
			//listView1.FullRowSelect = true;


			listView1.Columns.Add("Index");
			listView1.Columns.Add("Columns");

		}

		private void button1_Click(object sender, EventArgs e)
		{
	
			Random r = new Random();
			for (int i = 0; i < numbers.Length; i++)
			{

				numbers[i] = r.Next(1, 100);
			}

			string strRnd = "";
			
			for (int i = 0; i < (numbers.Length - 1); i++)

			{
				strRnd += numbers[i].ToString() + ",";
			}
			strRnd += numbers[numbers.Length - 1].ToString();


			label2.Text = strRnd;


		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private bool swap(ref int top, ref int bottom)
		{
			int temp;

			if (top < bottom)
				return false;

			temp = top;
			top = bottom;
			bottom = temp;
			return true;
		}
		private void btnbubble_Click(object sender, EventArgs e)
		{
			bubble();
			
		}
		 void bubble()
		{
			Stopwatch s = new Stopwatch();
			Random r = new Random();
			s.Start();
			bool inorder = false;

			while (!inorder)
			{
				inorder = true;
				for (int i = 0; i < (numbers.Length - 1); i++)
				{
					if (swap(ref numbers[i], ref numbers[i + 1]))
						inorder = false;
				}
			}

			string strSorted = " ";
			for (int i = 0; i < (numbers.Length - 1); i++)
			{
				strSorted += numbers[i].ToString() + ",";
			}
			s.Stop();

			strSorted += numbers[numbers.Length - 1].ToString();
			label3.Text = strSorted;
			label5.Text = (s.Elapsed.TotalMilliseconds + " ");
		}
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		static void step()
		{

		}
		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
			for (int i = 1; i < num.Length; i++)
			{
				int key = num[i];
				int j = i - 1;
				while (j >= 0 && num[j] > key)
				{
					//loop
					num[j + 1] = num[j];
					j--;
				}
				num[j + 1] = key;
			}

			//display
			foreach (var item in num)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			

			//int[] items = new int[5];
			//for (int i = 0; i < items.Length; i++)
			//{
			//	items[i] = i;
			//	ListViewItem l = new ListViewItem(items.ToString());
			//	listView1.Items.Add(textBox1.Text);

			//}
			//int[] arr = new int[] { };
			//ListViewItem l = new ListViewItem(arr.ToString());
			//listView1.Items.Add(textBox1.Text);



		}

		private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}
	}
}
