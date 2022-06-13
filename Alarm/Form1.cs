using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Alarm : Form
    {
        private Boolean isSet = false;
        private System.Media.SoundPlayer sound;
        public Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl2.Text = DateTime.Now.ToLongTimeString();
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            isSet = true;
            AlarmBox.Enabled = false;
            set_btn.Enabled = false;
            alarm_status.Text = "On";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           if(isSet == true)
            {
                if(time_lbl2.Text == AlarmBox.Text)
                {
                    sound = new System.Media.SoundPlayer();
                    sound.SoundLocation = "alarm.wav";
                    sound.Play();
                }
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            isSet = false;
            set_btn.Enabled = true;
            AlarmBox.Enabled = true;
            sound.Stop();
            alarm_status.Text = "Off";
            

        }
    }
}
