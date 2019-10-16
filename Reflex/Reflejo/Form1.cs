using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflejo
{
	public partial class Form1 : Form
	{
		Stopwatch stopWatch = new Stopwatch();
		bool enabled = false;
		public Form1()
		{
			InitializeComponent();
			pictureBox1.BackColor = Color.Red;
			timer1.Enabled = false;
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			var totalSeconds = stopWatch.ElapsedMilliseconds / 1000.0;
			label1.Text = totalSeconds.ToString();
			enabled = true;

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			timer2.Interval = rnd.Next(10000,20000);
			timer2.Enabled = true;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			if (enabled)
			{
				timer1.Enabled = false;
				stopWatch.Stop();
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Timer2_Tick(object sender, EventArgs e)
		{
			pictureBox1.BackColor = Color.Green;
			timer1.Enabled = true;
			stopWatch.Start();
			timer2.Enabled = false;
		}
	}
}
