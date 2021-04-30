using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remainder
{
    public partial class FormMain : Form
    {
        int StepTime = 0;
        Timer TimerMain;
        bool EnabelTMP, FHide = false;
        public FormMain()
        {
            InitializeComponent();
            TimerMain = new Timer();
            TimerMain.Enabled = true;
            TimerMain.Interval = 1000;
            TimerMain.Tick += TimerMain_Tick;
            TimerMain.Stop();
        }
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            try
            {
                if (EnabelTMP)
                    StepTime ++;
                else
                    StepTime --;

                ValueTime.Value = (int)(StepTime / 60) + 1;

                TimeSpan timesp = TimeSpan.FromSeconds(StepTime);
                ViewTime.Text = timesp.ToString(@"hh\:mm\:ss");

                if (StepTime == 0 && EnabelTMP == false && FHide == true)
                {
                    //new FormMain().Show();
                    Show();
                    FHide = false;
                }

                if (StepTime == 0 && EnabelTMP == false)
                {
                    TimerMain.Stop();
                    PicAni.Hide();
                    System.Media.SystemSounds.Asterisk.Play();
                    Console.Beep(3000, 1000);
                    MessageBox.Show("End Alarm !", "Remiander");
                    ViewTime.Text = "Clock";
                    ValueTime.Value = 0;
                    BtnStop.Text = "Stop";
                    BtnStart.Enabled = true;
                    BtnStop.BackColor = Color.FromArgb(192, 0, 0);
                }
            }
            catch (Exception ex)
            {
                TimerMain.Stop();
                MessageBox.Show(ex.Message, "Error Timer");
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            PicAni.Hide();
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 100;
            timer.Start();
            timer.Tick += delegate
            {
                LabelTime.Text = DateTime.Now.ToLongTimeString() + " - " + DateTime.Now.ToLongDateString();
            };
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            PicAni.Show();
            BtnStart.Enabled = false;
            if (ValueTime.Value > 0)
            {
                StepTime = (ValueTime.Value * 60);
                TimerMain.Start();
                EnabelTMP = false;
            }
            else if (ValueTime.Value == 0)
            {
                EnabelTMP = true;
                TimerMain.Start();
            }
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (StepTime > 0)
            {
                TimerMain.Enabled = !TimerMain.Enabled;
                if (TimerMain.Enabled)
                {
                    PicAni.Show();
                    BtnStop.Text = "Stop";
                    BtnStop.BackColor = Color.FromArgb(192, 0, 0);
                }
                else
                {
                    PicAni.Hide();
                    BtnStop.BackColor = Color.Orange;
                    BtnStop.Text = "Continue";
                }
            }
        }
        private void BtnClaer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا میخواهید یادآور پاک شود ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                PicAni.Hide();
                BtnStart.Enabled = true;
                StepTime = 0;
                ValueTime.Value = 0;
                TimerMain.Stop();
                ViewTime.Text = "Clock";
                groupBox1.Text = "Alarm";
                BtnStop.Text = "Stop";
                BtnStop.BackColor = Color.FromArgb(192, 0, 0);
            }
        }

        private void ValueTime_ValueChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Alarm Time is : " + ValueTime.Value + " ' Minute";
        }

        private void BtnHide_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا میخواهید برنامه مخفی شود ؟", "پنهان شدن", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                FHide = true;
                Hide();
            }
        }
    }
}
