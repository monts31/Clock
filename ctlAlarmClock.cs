using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlClockLib
{
    public partial class ctlAlarmClock : ctlClockLib.ctlClock
    {
        private DateTime dteAlarmTime;
        private bool blnAlarmSet;
        private bool blnColorTicker;

        public DateTime AlarmTime
        {
            get { return dteAlarmTime; }
            set { dteAlarmTime = value; }
        }

        public bool AlarmSet
        {
            get { return blnAlarmSet; }
            set { blnAlarmSet = value; }
        }
        public ctlAlarmClock()
        {
            InitializeComponent();
        }
        protected override void timer1_Tick(object sender, System.EventArgs e)
        {

            base.timer1_Tick(sender, e);
            if (AlarmSet == false)
                return;
            else
            {
                if (AlarmTime.Date == DateTime.Now.Date && AlarmTime.Hour ==
                DateTime.Now.Hour && AlarmTime.Minute == DateTime.Now.Minute)
                {
                    lblAlarm.Visible = true;
                    if (blnColorTicker == false)
                    {
                        lblAlarm.BackColor = Color.Red;
                        blnColorTicker = true;
                    }
                    else
                    {
                        lblAlarm.BackColor = Color.Blue;
                        blnColorTicker = false;
                    }
                }
                else
                {
                    lblAlarm.Visible = false;
                }
            }
        }

        private void btnAlarmOff_Click(object sender, EventArgs e)
        {
            AlarmSet = false;
            lblAlarm.Visible=false;
        }
    }
}
