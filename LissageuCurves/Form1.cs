using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LissageuCurves
{
    public partial class Form1 : Form
    {
        private double Amplitude = 10;
        private double xFrequency = 1, yFrequency = 1, phase = 0;
        private double iter = 0, step = 0.05;

        public Form1()
        {
            InitializeComponent();
        }
        private void set_fields()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = -(Amplitude + 5);
            chart1.ChartAreas[0].AxisY.Maximum = Amplitude + 5;
            chart1.ChartAreas[0].AxisX.Minimum = -(Amplitude + 5);
            chart1.ChartAreas[0].AxisX.Maximum = Amplitude + 5;
            chart1.Series[1].Points.AddXY(0, 0);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            set_fields();

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            double x = Amplitude * Math.Sin(xFrequency * iter + phase);
            double y = Amplitude * Math.Sin(yFrequency * iter);
            chart1.Series[0].Points.AddXY(x, y);
            iter += step;

        }
        private void Button_Stop_Click(object sender, EventArgs e)
        {
            buttonStart.Text = "Start";
            buttonStart.Text = "Start";
            timer1.Stop();
            set_fields();

        }
        private void Button_Start_Click_1(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {


                timer1.Enabled = false;
                buttonStart.Text = "Start";
            }
            else
            {
                set_fields();
                timer1.Enabled = true;
                buttonStart.Text = "Stop";
            }
        }
        private void RadioButton1_Click(object sender, EventArgs e)
        {
            xFrequency = 1;
            yFrequency = 2;
            phase = Math.PI / 2;
            //   step = 0.1;
            iter = 0;
        }
        private void RadioButton2_Click(object sender, EventArgs e)
        {
            xFrequency = 3;
            yFrequency = 2;
            iter = 0;
            //step = 0.1;
            phase = Math.PI / 2;
        }
        private void RadioButton3_Click(object sender, EventArgs e)
        {
            xFrequency = 3;
            yFrequency = 4;
            iter = 0;
            phase = Math.PI / 2;
        }
        private void RadioButton4_Click(object sender, EventArgs e)
        {
            xFrequency = 5;
            yFrequency = 4;
            iter = 0;
            phase = Math.PI / 2;
        }

       
        private void RadioButton5_Click(object sender, EventArgs e)
        {
            xFrequency = 5;
            yFrequency = 6;
            iter = 0;
            //    step = 0.03;
            phase = Math.PI / 2;
        }
        private void RadioButton6_Click(object sender, EventArgs e)
        {
            xFrequency = 9;
            yFrequency = 8;
            iter = 0;
            //    step = 0.03;

            phase = Math.PI / 2;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            chart1.Series[0].Points.Clear();

            xFrequency = (double)frequencyXNumeric.Value;
            yFrequency = (double)frequencyYNumeric.Value;
            Amplitude = (double)amplitudeNumeric.Value;
            phase = (double)phaseNumeric.Value;
            if (timer1.Enabled)
            {

                chart1.Series[1].Points.AddXY(0, 0);


                timer1.Enabled = false;
                buttonStart.Text = "Start";
            }
            else
            {
                set_fields();
                timer1.Enabled = true;
                buttonStart.Text = "Stop";
            }

        }

    }
}

