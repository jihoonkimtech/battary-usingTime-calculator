using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;

namespace WindowsFormsApp1
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void inputBut_Click(object sender, EventArgs e)
        {

            if (useVolt.Text.Equals("") == true || useAmp.Text.Equals("") == true) 
                return;

            double toNumVolt = double.Parse(useVolt.Text);
            double toNummAmp = double.Parse(useAmp.Text)/1000;
            double resultWat = toNumVolt * toNummAmp;
            useWatt.Text = resultWat.ToString();

            double toNumcVolt = 0.0, toNumcAmp = 0.0, resultcWatt = 0.0; 

            if (carWatt.Text.Equals("") == false)
            {
                resultcWatt = double.Parse(carWatt.Text);
            }
            else if (carWatt.Text.Equals("") == true)
            {
                if(carVolt.Text.Equals("") == true || carAmp.Text.Equals("") == true)
                    return;

                toNumcVolt = double.Parse(carVolt.Text);
                toNumcAmp = double.Parse(carAmp.Text);
                resultcWatt = toNumcVolt * toNumcAmp;
                carWatt.Text = resultcWatt.ToString();
            }

            int usingTime = (int)(resultcWatt / resultWat);
            hours.Text = usingTime.ToString();
            int usingDays = usingTime/24;
            days.Text = usingDays.ToString();
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void downBut_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Point mCurrentPosition = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (mCurrentPosition.X + e.X), this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            useWatt.Text = "";
            carWatt.Text = "";
            hours.Text = "";
            days.Text = "";
            useVolt.Text = "";
            useAmp.Text = "";
            carVolt.Text = "";
            carAmp.Text = "";

        }

        private void dataReset_Click(object sender, EventArgs e)
        {
            useD.Text = "";
            useH.Text = "";
            batWh.Text = "";
            batV.Text = "";
            batA.Text = "";
            batDieV.Text = "";
            deviceV.Text = "";
            deviceA.Text = "";
            deviceW.Text = "";
        }

        private void comp_Click(object sender, EventArgs e)
        {
            if (deviceV.Text.Equals("") == true || deviceA.Text.Equals("") == true)
                return;

            double deV = double.Parse(deviceV.Text);
            double deA = double.Parse(deviceA.Text) / 1000;
            double deW = deV * deA;
            deviceW.Text = deW.ToString();

            if (batV.Text.Equals("") == true || batA.Text.Equals("") == true)
                return;

            double baV = 0.0, baA = 0.0, baWh = 0.0;

            baV = double.Parse(batV.Text);
            baA = double.Parse(batA.Text);
            baWh = baV * baA;
            batWh.Text = baWh.ToString();

            if (batDieV.Text.Equals("") == true)
                return;

            double useTime = baWh / deW;

            double dieV = double.Parse(batDieV.Text);
            double perV = (baV - dieV) / baV;
            double SafeH = perV * useTime;
            useH.Text = SafeH.ToString();
            int SafeD = (int)(SafeH / 24);
            useD.Text = SafeD.ToString();
        }


        private void useVolt_TextChanged(object sender, EventArgs e)
        {

        }

        private void carAmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void inputBut_Click_1(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
