using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsedTimeCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Wh");
            comboBox1.Items.Add("mAh");

        }

        private double batVoltage = 0;
        private void CalculateBut_Click(object sender, EventArgs e)
        {
            if (batVolt.Text.Equals("") || batAmp.Text.Equals("")) { MessageBox.Show("모든 칸을 채워주세요!"); return; }

            batVoltage = Double.Parse(batVolt.Text);
            double batAmpare = Double.Parse(batAmp.Text);
            double outputWatt = batVoltage * batAmpare;

            batW.Text = outputWatt.ToString();
            batWatt.Text = outputWatt.ToString();

            return;
        }

        private void useTimeBut_Click(object sender, EventArgs e)
        {
            if (batW.Text.Equals("") || useW.Text.Equals("")) { MessageBox.Show("모든 칸을 채워주세요!"); return; }

            string val;
            val = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            double inputValue = 0, usingTime = 0; ;
            double batWatts = Double.Parse(batW.Text);

            if (val.Equals("Wh"))
            {
                inputValue = Double.Parse(useW.Text);
                usingTime = batWatts / inputValue;
            }
            else if (val.Equals("mAh"))
            {
                inputValue = Double.Parse(useW.Text);
                usingTime = batWatts / (batVoltage * (inputValue / 1000));
            }



            useTimeVal.Text = usingTime.ToString();


            return;
        }

        private Point mCurrentPosition = new Point(0, 0);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (mCurrentPosition.X + e.X), this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void down_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}