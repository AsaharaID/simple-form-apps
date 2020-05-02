using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FormsApp
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

        private void Button1_Click(object sender, EventArgs e)
        {
            float x1 = float.Parse(textBox1.Text);
            float x2 = float.Parse(textBox2.Text);
            float x3 = float.Parse(textBox3.Text);
            float x4 = float.Parse(textBox4.Text);
            float x5 = float.Parse(textBox5.Text);
            float x6 = float.Parse(textBox6.Text);
            float x7 = float.Parse(textBox7.Text);
            var chart = chart1.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 7;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 1000;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 100;

            chart1.Series.Add("Minggu");
            chart1.Series["Minggu"].ChartType = SeriesChartType.Spline;
            chart1.Series["Minggu"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series["Minggu"].Points.AddXY(1, x1);
            chart1.Series["Minggu"].Points.AddXY(2, x2);
            chart1.Series["Minggu"].Points.AddXY(3, x3);
            chart1.Series["Minggu"].Points.AddXY(4, x4);
            chart1.Series["Minggu"].Points.AddXY(5, x5);
            chart1.Series["Minggu"].Points.AddXY(6, x6);
            chart1.Series["Minggu"].Points.AddXY(7, x7);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            float x8 = float.Parse(textBox8.Text);
            float x9 = float.Parse(textBox9.Text);
            float x10 = float.Parse(textBox10.Text);
            float x11 = float.Parse(textBox11.Text);
            float x12 = float.Parse(textBox12.Text);
            float x13 = float.Parse(textBox13.Text);
            float x14 = float.Parse(textBox14.Text);
            var chart = chart2.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 7;
            chart.AxisY.Minimum = 1000000;
            chart.AxisY.Maximum = 10000000;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 1000000;

            chart2.Series.Add("Minggu");
            chart2.Series["Minggu"].ChartType = SeriesChartType.Area;
            chart2.Series["Minggu"].Color = Color.Blue;
            chart2.Series[0].IsVisibleInLegend = false;
            chart2.Series["Minggu"].Points.AddXY(1, x8);
            chart2.Series["Minggu"].Points.AddXY(2, x9);
            chart2.Series["Minggu"].Points.AddXY(3, x10);
            chart2.Series["Minggu"].Points.AddXY(4, x11);
            chart2.Series["Minggu"].Points.AddXY(5, x12);
            chart2.Series["Minggu"].Points.AddXY(6, x13);
            chart2.Series["Minggu"].Points.AddXY(7, x14);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    };

                    if (control is Chart)
                    {
                        (control as Chart).Series.Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    };
                }
            };
            func(Controls);
        }
    }
}
